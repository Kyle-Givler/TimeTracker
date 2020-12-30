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
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTrackerLibrary;
using TimeTrackerLibrary.Data;
using TimeTrackerLibrary.Models;

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
            UpdateSelectedProjectLabels();
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

        private async void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadSubcategories((CategoryModel)comboBoxCategory.SelectedItem);
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

                proj.Name = textBoxProject.Text;
                proj.Category = cat;
                proj.CategoryId = cat.Id;
                proj.Subcategory = subcat;
                proj.SubcategoryId = subcat?.Id;

                await projectData.UpdateProject(proj);

                editingProject = false;

                listBoxProject.Enabled = true;

                btnAddProj.Text = "Add Project";
                textBoxProject.Text = string.Empty;
            }
            else
            {
                if (cat == null)
                {
                    MessageBox.Show("Please select a valid category");
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
                project.SubcategoryId = subcat?.Id;

                projectData.AddProject(project);
            }

            textBoxProject.Text = string.Empty;
            await LoadProjects();
            UpdateSelectedProjectLabels();
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

            if (selectedProj.Subcategory != null)
            {
                var subCat = subcategories.Where(x => x.Id == selectedProj.Subcategory.Id).First();
                comboBoxSubcategory.SelectedItem = subCat;
            }
        }

        private void listBoxProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSelectedProjectLabels();
        }

        private void UpdateSelectedProjectLabels()
        {
            ProjectModel selectedProject = (ProjectModel)listBoxProject.SelectedItem;

            if (selectedProject == null)
            {
                return;
            }

            lblProjectNameValue.Text = selectedProject.Name;
            lblCategoryValue.Text = selectedProject.Category.Name;
            lblSubcategoryValue.Text = selectedProject.Subcategory == null ? "(none)" : selectedProject.Subcategory.Name;
        }
    }
}
