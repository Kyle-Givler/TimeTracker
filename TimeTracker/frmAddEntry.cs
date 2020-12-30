/*
MIT License

Copyright(c) 2020 Kyle Givler
https://github.com/JoyfulReaper

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

using System.Windows.Forms;
using System.ComponentModel;
using TimeTrackerLibrary.Models;
using TimeTrackerLibrary.Data;
using TimeTrackerLibrary;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

namespace TimeTrackerUI
{
    public partial class frmAddEntry : Form
    {
        private readonly BindingList<ProjectModel> projects = new BindingList<ProjectModel>();
        private readonly BindingList<CategoryModel> categories = new BindingList<CategoryModel>();
        private readonly BindingList<SubcategoryModel> subcategories = new BindingList<SubcategoryModel>();

        private readonly ICategoryData categoryData = new CategoryData(GlobalConfig.Connection);
        private readonly ISubcategoryData subcategoryData = new SubcategoryData(GlobalConfig.Connection);
        private readonly IProjectData projectData = new ProjectData(GlobalConfig.Connection);
        private readonly IEntryData entryData = new EntryData(GlobalConfig.Connection);

        public frmAddEntry()
        {
            InitializeComponent();
        }

        private void frmAddEntry_Load(object sender, System.EventArgs e)
        {
            SetupData();
        }

        private async Task SetupData()
        {
            listBoxProject.DataSource = projects;
            listBoxProject.DisplayMember = nameof(ProjectModel.Name);

            comboBoxCategory.DataSource = categories;
            comboBoxCategory.DisplayMember = nameof(CategoryModel.Name);

            comboBoxSubcategory.DataSource = subcategories;
            comboBoxSubcategory.DisplayMember = nameof(SubcategoryModel.Name);

            await LoadCategories();
            await LoadSubcategories();
            await LoadProjects();
        }

        private async Task LoadProjects()
        {
            CategoryModel selectedCat = (CategoryModel)comboBoxCategory.SelectedItem;
            SubcategoryModel selectedSubCat = (SubcategoryModel)comboBoxSubcategory.SelectedItem;

            List<ProjectModel> projs;

            if (selectedCat == null)
            {
                return;
            }

            projects.Clear();

            if(checkBoxAllProjects.Checked)
            {
                projs = await projectData.LoadAllProjects();
            }
            else if (selectedSubCat == null)
            {
                projs = await projectData.LoadProjectsByCategory(selectedCat);
            }
            else
            {
                projs = await projectData.LoadProjectsBySubCategory(selectedSubCat);
            }

            projs = projs.OrderBy(x => x.Name).ToList();
            projs.ForEach(x => projects.Add(x));
        }

        private async Task LoadCategories()
        {
            categories.Clear();

            var cats = await categoryData.LoadAllCategories();
            cats = cats.OrderBy(x => x.Name).ToList();
            cats.ForEach(x => categories.Add(x));
        }

        private async Task LoadSubcategories()
        {
            if (comboBoxCategory.SelectedItem == null)
            {
                await LoadProjects();
                return;
            }

            CategoryModel selectedCat = (CategoryModel)comboBoxCategory.SelectedItem;

            subcategories.Clear();

            var subCats = await subcategoryData.LoadSubcategories(selectedCat);
            subCats = subCats.OrderBy(x => x.Name).ToList();
            subCats.ForEach(x => subcategories.Add(x));

            await LoadProjects();
        }

        private async void comboBoxCategory_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            await LoadSubcategories();
        }

        private void checkBoxAllProjects_CheckedChanged(object sender, System.EventArgs e)
        {
            if(checkBoxAllProjects.Checked)
            {
                comboBoxCategory.Enabled = false;
                comboBoxSubcategory.Enabled = false;
            }
            else
            {
                comboBoxCategory.Enabled = true;
                comboBoxSubcategory.Enabled = true;
            }

            LoadProjects();
        }

        private void btnAddEntry_Click(object sender, System.EventArgs e)
        {
            if(!int.TryParse(textBoxHoursSpent.Text, out int hours))
            {
                MessageBox.Show("Please enter a valid number of hours");
                return;
            }

            CategoryModel selectedCat = (CategoryModel)comboBoxCategory.SelectedItem;
            SubcategoryModel selectedSubCat = (SubcategoryModel)comboBoxSubcategory.SelectedItem;
            ProjectModel selectedProject = (ProjectModel)listBoxProject.SelectedItem;

            if(selectedProject == null)
            {
                return;
            }

            EntryModel entry = new EntryModel();

            entry.Project = selectedProject;
            entry.ProjectId = selectedProject.Id;
            entry.Date = dateTimePickerDate.Value;
            entry.Notes = textBoxNotes.Text;
            entry.HoursSpent = hours;

            entryData.CreateEntry(entry);

            textBoxHoursSpent.Text = string.Empty;
            textBoxNotes.Text = string.Empty;
        }

        private void comboBoxSubcategory_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            LoadProjects();
        }
    }
}
