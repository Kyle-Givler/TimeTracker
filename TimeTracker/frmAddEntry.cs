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
using TimeTrackerLibrary.Services;

namespace TimeTrackerUI
{
    public partial class frmAddEntry : Form
    {
        private readonly BindingList<ProjectModel> projects = new BindingList<ProjectModel>();
        private readonly BindingList<CategoryModel> categories = new BindingList<CategoryModel>();
        private readonly BindingList<SubcategoryModel> subcategories = new BindingList<SubcategoryModel>();

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
            projects.Clear();

            CategoryModel selectedCat = (CategoryModel)comboBoxCategory.SelectedItem;
            SubcategoryModel selectedSubCat = (SubcategoryModel)comboBoxSubcategory.SelectedItem;

            var projs = await ProjectService.GetInstance.LoadProjects(selectedCat, selectedSubCat, checkBoxAllProjects.Checked);
            projs.ForEach(x => projects.Add(x));
        }

        private async Task LoadCategories()
        {
            categories.Clear();

            var cats = await CategoryService.GetInstance.LoadAllCategories();
            cats.ForEach(x => categories.Add(x));
        }

        private async Task LoadSubcategories()
        {
            if (comboBoxCategory.SelectedItem == null)
            {
                return;
            }

            CategoryModel selectedCat = (CategoryModel)comboBoxCategory.SelectedItem;

            subcategories.Clear();

            var subCats = await SubcategoryService.GetInstance.LoadSubcategories(selectedCat);
            subCats.ForEach(x => subcategories.Add(x));
        }

        private async void comboBoxCategory_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            await LoadSubcategories();
            await LoadProjects();
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

        private async void comboBoxSubcategory_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            await LoadProjects();
        }
    }
}
