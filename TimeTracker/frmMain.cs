using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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

        private readonly ICategoryData categoryData = new CategoryData(GlobalConfig.Connection);
        private readonly ISubcategoryData subcategoryData = new SubcategoryData(GlobalConfig.Connection);
        private readonly IProjectData projectData = new ProjectData(GlobalConfig.Connection);
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

            await LoadCategories();
            await LoadSubcategories();
            await LoadProjects();
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
                await LoadProjects();
                return;
            }

            CategoryModel selectedCat = (CategoryModel)comboBoxCategory.SelectedItem;

            subcategories.Clear();

            var subCats = await SubcategoryService.GetInstance.LoadSubcategories(selectedCat);
            subCats.ForEach(x => subcategories.Add(x));

            await LoadProjects();
        }

        private async Task LoadProjects()
        {
            CategoryModel selectedCat = (CategoryModel)comboBoxCategory.SelectedItem;
            SubcategoryModel selectedSubCat = (SubcategoryModel)comboBoxSubcategory.SelectedItem;

            var projs = await ProjectService.GetInstance.LoadProjects(selectedCat, selectedSubCat, checkBoxAllProjects.Checked);

            projs.ForEach(x => projects.Add(x));
        }

        private async Task LoadEntries()
        {
            entries.Clear();
            var allEntries = await entryData.LoadAllEntries();

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
            await LoadSubcategories();
        }
    }
}
