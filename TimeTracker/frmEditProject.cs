using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTrackerLibrary;
using TimeTrackerLibrary.Data;
using TimeTrackerLibrary.Models;
using System.Linq;

namespace TimeTrackerUI
{
    public partial class frmEditProject : Form
    {
        private readonly BindingList<CategoryModel> categories = new BindingList<CategoryModel>();
        private readonly BindingList<SubcategoryModel> subcategories = new BindingList<SubcategoryModel>();
        private readonly BindingList<ProjectModel> projects = new BindingList<ProjectModel>();

        private readonly ICategoryData categoryData = new CategoryData(GlobalConfig.Connection);
        private readonly ISubcategoryData subcategoryData = new SubcategoryData(GlobalConfig.Connection);
        private readonly IProjectData projectData = new ProjectData(GlobalConfig.Connection);

        private bool editingProject = false;

        public frmEditProject()
        {
            InitializeComponent();
        }

        private void frmEditProject_Load(object sender, EventArgs e)
        {
            SetupData();
        }

        private async Task SetupData()
        {
            comboBoxCategory.DataSource = categories;
            comboBoxCategory.DisplayMember = nameof(CategoryModel.Name);

            comboBoxSubcategory.DataSource = subcategories;
            comboBoxSubcategory.DisplayMember = nameof(SubcategoryModel.Name);

            listBoxProject.DataSource = projects;
            listBoxProject.DisplayMember = nameof(ProjectModel.Name);

            await LoadCategories();
            await LoadSubcategories((CategoryModel)comboBoxCategory.SelectedItem);
            await LoadProjects();
        }

        private async Task LoadProjects()
        {
            projects.Clear();

            var proj = await projectData.LoadAllProjects();
            proj.OrderBy(x => x.Name);
            proj.ForEach(x => projects.Add(x));
        }

        private async Task LoadCategories()
        {
            categories.Clear();

            var cats = await categoryData.LoadAllCategories();
            cats = cats.OrderBy(x => x.Name).ToList();
            cats.ForEach(x => categories.Add(x));
        }

        private async Task LoadSubcategories(CategoryModel category)
        {
            if (category == null)
            {
                return;
            }

            subcategories.Clear();

            var subCats = await subcategoryData.LoadSubcategories(category);
            subCats = subCats.OrderBy(x => x.Name).ToList();
            subCats.ForEach(x => subcategories.Add(x));
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (!editingProject)
            //{
                // Without the if then this will run when we change the selected item
                // and this results in duplicates in the list

                LoadSubcategories((CategoryModel)comboBoxCategory.SelectedItem);
            //}
        }

        private async void btnAddProj_Click(object sender, EventArgs e)
        {
            var cat = (CategoryModel)comboBoxCategory.SelectedItem;
            var subcat = (SubcategoryModel)comboBoxSubcategory.SelectedItem;

            if (editingProject)
            {
                ProjectModel proj = (ProjectModel)listBoxProject.SelectedItem;

                if(proj == null)
                {
                    return;
                }    

                if(textBoxProject.Text == string.Empty)
                {
                    MessageBox.Show("Please enter a valid project name");
                    return;
                }

                if (cat == null || subcat == null)
                {
                    MessageBox.Show("Please select a valid category and subcategory");
                    return;
                }

                proj.Name = textBoxProject.Text;
                proj.Category = cat;
                proj.CategoryId = cat.Id;
                proj.Subcategory = subcat;
                proj.SubcategoryId = subcat.Id;

                await projectData.UpdateProject(proj);

                editingProject = false;

                listBoxProject.Enabled = true;

                btnAddProj.Text = "Add Project";
                textBoxProject.Text = string.Empty;
            }
            else
            {
                if (cat == null || subcat == null)
                {
                    MessageBox.Show("Please select a valid category and subcategory");
                    return;
                }

                if (textBoxProject.Text == string.Empty)
                {
                    MessageBox.Show("Please enter a valid project name");
                    return;
                }

                ProjectModel project = new ProjectModel();

                project.Name = textBoxProject.Text;
                project.Category = cat;
                project.CategoryId = cat.Id;
                project.Subcategory = subcat;
                project.SubcategoryId = subcat.Id;

                projectData.AddProject(project);
            }

            textBoxProject.Text = string.Empty;
            LoadProjects();
        }

        private async void btnDeleteProj_Click(object sender, EventArgs e)
        {
            ProjectModel selectedProj = (ProjectModel)listBoxProject.SelectedItem;

            if (selectedProj == null)
            {
                MessageBox.Show("No Project is selected!");
                return;
            }

            var res = MessageBox.Show($"Delete project {selectedProj.Name}?", "Delete Project", MessageBoxButtons.YesNo);

            if(res == DialogResult.No)
            {
                return;
            }

            await projectData.RemoveProject(selectedProj);

            LoadProjects();
        }

        private async void listBoxProject_DoubleClick(object sender, EventArgs e)
        {
            ProjectModel selectedProj = (ProjectModel)listBoxProject.SelectedItem;

            if (selectedProj == null)
            {
                return;
            }

            editingProject = true;
            listBoxProject.Enabled = false;

            btnAddProj.Text = "Update Project";

            textBoxProject.Text = selectedProj.Name;

            var cat = categories.Where(x => x.Id == selectedProj.Category.Id).First();
            comboBoxCategory.SelectedItem = cat;

            await LoadSubcategories(selectedProj.Category);

            var subCat = subcategories.Where(x => x.Id == selectedProj.Subcategory.Id).First();
            comboBoxSubcategory.SelectedItem = subCat;
        }
    }
}
