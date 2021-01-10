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
using TimeTrackerLibrary.Data;
using TimeTrackerLibrary.Services;
using TimeTrackerLibrary.Models;
using System.Diagnostics;
using System.Linq;
using TimeTrackerLibrary.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace TimeTrackerUI
{
    public partial class frmMain : Form, INavigatable
    {
        private readonly BindingList<EntryModel> entries = new BindingList<EntryModel>();
        private readonly BindingList<ProjectModel> projects = new BindingList<ProjectModel>();
        private readonly BindingList<CategoryModel> categories = new BindingList<CategoryModel>();
        private readonly BindingList<SubcategoryModel> subcategories = new BindingList<SubcategoryModel>();

        private readonly IEntryData entryData;
        private readonly ICategoryService categoryService;
        private readonly ISubcategoryService subcategoryService;
        private readonly IProjectService projectService;
        private readonly IEntryService entryService;
        private readonly INavigationService navigationService;

        public frmMain(IEntryData entryData, 
            ICategoryService categoryService,
            ISubcategoryService subcategoryService,
            IProjectService projectService, 
            IEntryService entryService,
            INavigationService navigationService)
        {
            InitializeComponent();
            this.entryData = entryData;
            this.categoryService = categoryService;
            this.subcategoryService = subcategoryService;
            this.projectService = projectService;
            this.entryService = entryService;
            this.navigationService = navigationService;
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
            listBoxEntries.DisplayMember = nameof(EntryModel.FormattedDate);

            await LoadCategories();
            await LoadSubcategories((CategoryModel)comboBoxCategory.SelectedItem);
        }

        private async Task LoadCategories()
        {
            categories.Clear();

            var cats = await categoryService.LoadAllCategories();
            cats.ForEach(x => categories.Add(x));
        }

        private async Task LoadSubcategories(CategoryModel category)
        {
            if (category == null)
            {
                return;
            }

            subcategories.Clear();

            var subCats = await subcategoryService.LoadSubcategories(category);
            subCats.ForEach(x => subcategories.Add(x));

            LoadProjects();
        }

        private async Task LoadProjects()
        {
            projects.Clear();

            CategoryModel selectedCat = (CategoryModel)comboBoxCategory.SelectedItem;
            SubcategoryModel selectedSubCat = (SubcategoryModel)comboBoxSubcategory.SelectedItem;

            var projs = await projectService.LoadProjects(selectedCat, selectedSubCat, checkBoxAllProjects.Checked);
            projs.ForEach(x => projects.Add(x));

            await LoadEntries();
            PopulateEntryLabels();
        }

        private async Task LoadEntries()
        {
            var selectedProject = (ProjectModel)listBoxProject.SelectedItem;

            entries.Clear();

            if (selectedProject == null)
            {
                PopulateEntryLabels();
                return;
            }

            var allEntries = await entryData.LoadEntriesByProject(selectedProject);
            allEntries = allEntries.OrderByDescending(x => x.Date).ToList();
            allEntries.ForEach(x => entries.Add(x));

            PopulateEntryLabels();
        }

        private void btnAddEntry_Click(object sender, EventArgs e)
        {
            var selectedProject = (ProjectModel)listBoxProject.SelectedItem;
            var frm = navigationService.NavigateTo<frmAddEntry>();

            frm.InitialProject = selectedProject;

            //frmAddEntry frm = new frmAddEntry(selectedProject);
            frm.ShowDialog(this);

            LoadEntries();
        }

        private async void btnEditCat_Click(object sender, EventArgs e)
        {
            //frmEditCategory frm = new frmEditCategory();
            var frm = navigationService.NavigateTo<frmEditCategory>();

            frm.ShowDialog(this);

            await LoadCategories();
            LoadSubcategories((CategoryModel)comboBoxCategory.SelectedItem);
        }

        private void btnEditProjects_Click(object sender, EventArgs e)
        {
            //frmEditProject frm = new frmEditProject();
            var frm = navigationService.NavigateTo<frmEditProject>();

            frm.ShowDialog(this);

            LoadProjects();
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

        private async Task PopulateEntryLabels()
        {
            var selectedEntry = (EntryModel)listBoxEntries.SelectedItem;

            if (selectedEntry == null || listBoxProject.SelectedItem == null)
            {
                lblProjectValue.Text = string.Empty;
                lblCategoryValue.Text = string.Empty;
                lblsubcategoryValue.Text = string.Empty;
                lblEntryDateValue.Text = string.Empty;
                lblTimeSpentValue.Text = string.Empty;
                textBoxNotes.Text = string.Empty;

                lblAllTimeValue.Text = string.Empty;
                lblProjectTotalValue.Text = string.Empty;
                lblCategoryTimeValue.Text = string.Empty;
                lblSubcategoryTotalValue.Text = string.Empty;
                return;
            }

            lblProjectValue.Text = selectedEntry.Project.Name;
            lblCategoryValue.Text = selectedEntry.Project.Category.Name;
            lblsubcategoryValue.Text = selectedEntry.Project.Subcategory == null ? "(none)" : selectedEntry.Project.Subcategory.Name;
            lblEntryDateValue.Text = selectedEntry.FormattedDate;
            lblTimeSpentValue.Text = $"{selectedEntry.HoursSpent:N2} hours";
            textBoxNotes.Text = selectedEntry.Notes;

            lblAllTimeValue.Text = $"{await entryService.GetTotalTimeAllEntries():N2} hours";
            lblProjectTotalValue.Text = $"{await entryService.GetTimeByProject(selectedEntry.Project):N2} hours";
            lblCategoryTimeValue.Text = $"{await entryService.GetTimeByCategory(selectedEntry.Project.Category):N2} hours";

            if (selectedEntry.Project.Subcategory != null)
            {
                lblSubcategoryTotalValue.Text = $"{await entryService.GetTimeBySubcategory(selectedEntry.Project.Subcategory):N2} hours";
            }
            else
            {
                lblSubcategoryTotalValue.Text = "N/A";
            }
        }

        private async void listBoxProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxProject.SelectedItem == null)
            {
                return;
            }

            await LoadEntries();
            PopulateEntryLabels();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedEntry = (EntryModel)listBoxEntries.SelectedItem;

            if(selectedEntry == null)
            {
                return;
            }

            var res = MessageBox.Show("Confirm Enty Deletion", "Delete Entry", MessageBoxButtons.YesNo);
            if(res == DialogResult.No)
            {
                return;
            }

            entryData.RemoveEntry(selectedEntry);

            LoadEntries();
        }

        private void linkLabelGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/JoyfulReaper") { UseShellExecute = true });
        }

        private async void checkBoxEntries_CheckedChanged(object sender, EventArgs e)
        {
            entries.Clear();

            if(checkBoxEntries.Checked)
            {
                comboBoxCategory.Enabled = false;
                comboBoxSubcategory.Enabled = false;
                listBoxProject.Enabled = false;
                checkBoxAllProjects.Enabled = false;

                var allEntries = await entryData.LoadAllEntries();
                allEntries = allEntries.OrderBy(x => x.Date).ToList();
                allEntries.ForEach(x => entries.Add(x));
            }
            else
            {
                comboBoxCategory.Enabled = true;
                comboBoxSubcategory.Enabled = true;
                listBoxProject.Enabled = true;
                checkBoxAllProjects.Enabled = true;

                LoadEntries();
            }

            PopulateEntryLabels();
        }

        public void Navigate()
        {
            Show();
        }
    }
}
