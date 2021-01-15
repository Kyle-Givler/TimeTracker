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
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTrackerLibrary;
using TimeTrackerLibrary.Data;
using TimeTrackerLibrary.Interfaces;
using TimeTrackerLibrary.Models;
using TimeTrackerLibrary.Services;

namespace TimeTrackerUI
{
    public partial class frmEditCategory : Form, INavigatable
    {
        private readonly BindingList<CategoryModel> categories = new BindingList<CategoryModel>();
        private readonly BindingList<SubcategoryModel> subcategories = new BindingList<SubcategoryModel>();

        private readonly ICategoryService categoryService;
        private readonly ISubcategoryService subcategoryService;
        private readonly ICategoryData categoryData;
        private readonly ISubcategoryData subcategoryData;
        private readonly IConfig config;

        private bool editingCategory = false;
        private bool editingSubcategory = false;

        public frmEditCategory(ICategoryService categoryService, 
            ISubcategoryService subcategoryService, 
            ICategoryData categoryData,
            ISubcategoryData subcategoryData,
            IConfig config)
        {
            InitializeComponent();
            this.categoryService = categoryService;
            this.subcategoryService = subcategoryService;
            this.categoryData = categoryData;
            this.subcategoryData = subcategoryData;
            this.config = config;
        }

        private async void frmEditCategory_Load(object sender, EventArgs e)
        {
            await SetupData();
        }

        private async Task SetupData()
        {
            listBoxCategory.DataSource = categories;
            listBoxCategory.DisplayMember = nameof(CategoryModel.Name);

            listBoxSubcategory.DataSource = subcategories;
            listBoxSubcategory.DisplayMember = nameof(SubcategoryModel.Name);

            await LoadCategories();
            await LoadSubcategories();
            UpdateCategoryLabel();
        }

        private async Task LoadCategories()
        {
            categories.Clear();

            var cats = await categoryService.LoadAllCategories();
            cats.ForEach(x => categories.Add(x));
        }

        private async Task LoadSubcategories()
        {
            if (listBoxCategory.SelectedItem == null)
            {
                return;
            }

            CategoryModel selectedCat = (CategoryModel)listBoxCategory.SelectedItem;

            subcategories.Clear();

            var subCats = await subcategoryService.LoadSubcategories(selectedCat);
            subCats.ForEach(x => subcategories.Add(x));
        }

        private async void btnAddCat_Click(object sender, EventArgs e)
        {
            if (editingCategory)
            {
                await EditCategory();
            }
            else
            {
                await AddCategory();
            }

            await LoadCategories();
            await LoadSubcategories();

            UpdateCategoryLabel();
        }

        private async Task AddCategory()
        {
            CategoryModel cat = new CategoryModel();

            if (textBoxCategory.Text != string.Empty)
            {
                cat.Name = textBoxCategory.Text;
            }
            else
            {
                MessageBox.Show("Please enter a valid category.");
                return;
            }

            await categoryData.AddCategory(cat);

            textBoxCategory.Text = string.Empty;
        }

        private async Task EditCategory()
        {
            CategoryModel cat = (CategoryModel)listBoxCategory.SelectedItem;

            if (cat == null)
            {
                return;
            }

            if (textBoxCategory.Text == string.Empty)
            {
                MessageBox.Show("Please enter a valid category name");
                return;
            }

            cat.Name = textBoxCategory.Text;

            await categoryData.UpdateCategory(cat);

            editingCategory = false;

            listBoxCategory.Enabled = true;

            btnAddCat.Text = "Add Category";
            textBoxCategory.Text = string.Empty;
        }

        private async void buttonAddSubCat_Click(object sender, EventArgs e)
        {
            if (editingSubcategory)
            {
                await EditSubcategory();
            }
            else
            {
                await AddSubcategory();
            }

            LoadSubcategories();
        }

        private async Task EditSubcategory()
        {
            SubcategoryModel subcat = (SubcategoryModel)listBoxSubcategory.SelectedItem;

            if (subcat == null)
            {
                return;
            }

            if (textBoxSubcategory.Text == string.Empty)
            {
                MessageBox.Show("Please enter a valid subcategory name");
                return;
            }

            subcat.Name = textBoxSubcategory.Text;

            await subcategoryData.UpdateSubcategory(subcat);

            editingSubcategory = false;

            listBoxSubcategory.Enabled = true;

            btnAddSubCat.Text = "Add Category";
            textBoxSubcategory.Text = string.Empty;
        }

        private async Task AddSubcategory()
        {
            var selectedCat = (CategoryModel)listBoxCategory.SelectedItem;

            if (selectedCat == null)
            {
                MessageBox.Show("No category is selected!");
                return;
            }

            if (textBoxSubcategory.Text == string.Empty)
            {
                MessageBox.Show("Please enter a valid subcategory.");
                return;
            }

            SubcategoryModel subCat = new SubcategoryModel();

            subCat.Name = textBoxSubcategory.Text;
            subCat.Category = selectedCat;
            subCat.CategoryId = selectedCat.Id;

            await subcategoryData.AddSubcategory(subCat);

            textBoxSubcategory.Text = string.Empty;
        }

        private async void btnDeleteCat_Click(object sender, EventArgs e)
        {
            CategoryModel selectedCat = (CategoryModel)listBoxCategory.SelectedItem;

            if (selectedCat == null)
            {
                MessageBox.Show("No category is selected!");
                return;
            }

            var rows = await config.Connection.QueryRawSQL<int, dynamic>($"SELECT COUNT (Id) FROM Subcategory WHERE CategoryId = {selectedCat.Id};", new { });

            if (rows.First() != 0)
            {
                MessageBox.Show($"{selectedCat.Name} cannot be deleted until all of the subcategories have been deleted.");
                return;
            }

            var confrim = MessageBox.Show($"Confirm Deletion of: {selectedCat.Name}?", "Delete Category", MessageBoxButtons.YesNo);
            if (confrim == DialogResult.No)
            {
                return;
            }

            await categoryData.RemoveCategory(selectedCat);

            LoadCategories();
        }

        private void listBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCategoryLabel();
            LoadSubcategories();
        }

        private void UpdateCategoryLabel()
        {
            var selectedCat = (CategoryModel)listBoxCategory.SelectedItem;

            if (selectedCat == null)
            {
                lblCategoryValue.Text = string.Empty;
                return;
            }

            lblCategoryValue.Text = selectedCat.Name;
        }

        private async void btnDeleteSubCat_Click(object sender, EventArgs e)
        {
            var selectedSubCat = (SubcategoryModel)listBoxSubcategory.SelectedItem;

            if (selectedSubCat == null)
            {
                MessageBox.Show("No subcategory is selected!");
                return;
            }

            var confrim = MessageBox.Show($"Confirm Deletion of: {selectedSubCat.Name}?", "Delete Category", MessageBoxButtons.YesNo);
            if (confrim == DialogResult.No)
            {
                return;
            }

            var rows = await config.Connection.QueryRawSQL<int, dynamic>($"SELECT COUNT (Id) FROM Project WHERE SubcategoryId = {selectedSubCat.Id};", new { });

            if (rows.First() != 0)
            {
                MessageBox.Show($"{selectedSubCat.Name} cannot be deleted until all of the projects under it have been deleted.");
                return;
            }

            await subcategoryData.RemoveSubcategory(selectedSubCat);

            LoadSubcategories();
        }

        private void listBoxCategory_DoubleClick(object sender, EventArgs e)
        {
            CategoryModel selectedCat = (CategoryModel)listBoxCategory.SelectedItem;

            if (selectedCat == null)
            {
                return;
            }

            editingCategory = true;
            listBoxCategory.Enabled = false;

            btnAddCat.Text = "Update Category";
            textBoxCategory.Text = selectedCat.Name;
        }

        private void listBoxSubcategory_DoubleClick(object sender, EventArgs e)
        {
            SubcategoryModel selectedSubcat = (SubcategoryModel)listBoxSubcategory.SelectedItem;

            if (selectedSubcat == null)
            {
                return;
            }

            editingSubcategory = true;
            listBoxSubcategory.Enabled = false;

            btnAddSubCat.Text = "Update Subcategory";
            textBoxSubcategory.Text = selectedSubcat.Name;
        }

        public void Navigate()
        {
            Show();
        }
    }
}