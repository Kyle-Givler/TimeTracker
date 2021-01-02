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

using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTrackerLibrary;
using TimeTrackerLibrary.Data;
using TimeTrackerLibrary.Services;
using TimeTrackerLibrary.Models;

namespace TimeTrackerUI
{
    public partial class frmMain : Form
    {
        private readonly BindingList<EntryModel> entries = new BindingList<EntryModel>();
        private readonly BindingList<ProjectModel> projects = new BindingList<ProjectModel>();
        private readonly BindingList<CategoryModel> categories = new BindingList<CategoryModel>();
        private readonly BindingList<SubcategoryModel> subcategories = new BindingList<SubcategoryModel>();

        private readonly IEntryData entryData = new EntryData(GlobalConfig.Connection);

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
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

            listBoxEntries.DataSource = entries;
            listBoxEntries.DisplayMember = nameof(EntryModel.Date);

            await LoadCategories();
            await LoadSubcategories((CategoryModel)comboBoxCategory.SelectedItem);
        }

        private async Task LoadCategories()
        {
            categories.Clear();

            var cats = await CategoryService.GetInstance.LoadAllCategories();
            cats.ForEach(x => categories.Add(x));
        }

        private async Task LoadSubcategories(CategoryModel category)
        {
            if (category == null)
            {
                return;
            }

            subcategories.Clear();

            var subCats = await SubcategoryService.GetInstance.LoadSubcategories(category);
            subCats.ForEach(x => subcategories.Add(x));

            LoadProjects();
        }

        private async Task LoadProjects()
        {
            projects.Clear();

            CategoryModel selectedCat = (CategoryModel)comboBoxCategory.SelectedItem;
            SubcategoryModel selectedSubCat = (SubcategoryModel)comboBoxSubcategory.SelectedItem;

            var projs = await ProjectService.GetInstance.LoadProjects(selectedCat, selectedSubCat, checkBoxAllProjects.Checked);
            projs.ForEach(x => projects.Add(x));

            await LoadEntries();
            PopulateEntryLabels();
        }

        private async Task LoadEntries()
        {
            var selectedProject = (ProjectModel)listBoxProject.SelectedItem;

            entries.Clear();
            var allEntries = await entryData.LoadEntriesByProject(selectedProject);

            allEntries.ForEach(x => entries.Add(x));
        }

        private void btnAddEntry_Click(object sender, EventArgs e)
        {
            frmAddEntry frm = new frmAddEntry();
            frm.ShowDialog(this);
        }

        private void btnEditCat_Click(object sender, EventArgs e)
        {
            frmEditCategory frm = new frmEditCategory();
            frm.ShowDialog(this);
        }

        private void btnEditProjects_Click(object sender, EventArgs e)
        {
            frmEditProject frm = new frmEditProject();
            frm.ShowDialog(this);
        }

        private async void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxCategory.SelectedItem == null)
            {
                return;
            }

            await LoadSubcategories((CategoryModel) comboBoxCategory.SelectedItem);
        }

        private void checkBoxAllProjects_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAllProjects.Checked)
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

        private void comboBoxSubcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxSubcategory.SelectedItem == null)
            {
                return;
            }

            LoadProjects();
        }

        private void listBoxEntries_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateEntryLabels();
        }

        private void PopulateEntryLabels()
        {
            var selectedEntry = (EntryModel)listBoxEntries.SelectedItem;

            if (selectedEntry == null)
            {
                return;
            }

            lblProjectValue.Text = selectedEntry.Project.Name;
            lblCategoryValue.Text = selectedEntry.Project.Category.Name;
            lblsubcategoryValue.Text = selectedEntry.Project.Subcategory == null ? "(none)" : selectedEntry.Project.Subcategory.Name;
            lblEntryDateValue.Text = selectedEntry.Date.ToString();
            lblTimeSpentValue.Text = selectedEntry.HoursSpent.ToString();
            textBoxNotes.Text = selectedEntry.Notes;
        }

        private void listBoxProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxProject.SelectedItem == null)
            {
                return;
            }

            LoadEntries();
        }
    }
}
