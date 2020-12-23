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
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTrackerLibrary;
using TimeTrackerLibrary.Data;
using TimeTrackerLibrary.Models;

namespace TimeTrackerUI
{
    public partial class frmEditCategory : Form
    {
        private readonly BindingList<CategoryModel> categories = new BindingList<CategoryModel>();
        private readonly BindingList<SubcategoryModel> subcategories = new BindingList<SubcategoryModel>();

        private readonly ICategoryData categoryData = new CategoryData(GlobalConfig.Connection);
        private readonly ISubcategoryData subcategoryData = new SubcategoryData(GlobalConfig.Connection);

        public frmEditCategory()
        {
            InitializeComponent();
        }

        private async void frmEditCategory_Load(object sender, EventArgs e)
        {
            SetupData();
        }

        private async Task SetupData()
        {
            listBoxCategory.DataSource = categories;
            listBoxCategory.DisplayMember = nameof(CategoryModel.Name);

            listBoxSubcategory.DataSource = subcategories;
            listBoxSubcategory.DisplayMember = nameof(SubcategoryModel.Name);

            await LoadCategories();
            await LoadSubcategories();
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
            if(listBoxCategory.SelectedItem == null)
            {
                return;
            }

            CategoryModel selectedCat = (CategoryModel)listBoxCategory.SelectedItem;

            subcategories.Clear();

            var subCats = await subcategoryData.LoadSubcategories(selectedCat);
            subCats = subCats.OrderBy(x => x.Name).ToList();
            subCats.ForEach(x => subcategories.Add(x));
        }

        private async void btnAddCat_Click(object sender, EventArgs e)
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
            LoadCategories();
        }

        private async void buttonAddSubCat_Click(object sender, EventArgs e)
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
            LoadSubcategories();
        }

        private async void btnDeleteCat_Click(object sender, EventArgs e)
        {
            // TODO - Don't allow a category to be deleted if it has subcategories
            // Currently throws an exception if you try to

            CategoryModel selectedCat = (CategoryModel)listBoxCategory.SelectedItem;

            if(selectedCat == null)
            {
                MessageBox.Show("No category is selected!");
                return;
            }

            await categoryData.RemoveCategory(selectedCat);

            LoadCategories();
        }

        private void listBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSubcategories();
        }

        private async void btnDeleteSubCat_Click(object sender, EventArgs e)
        {
            var selectedSubCat = (SubcategoryModel) listBoxSubcategory.SelectedItem;

            if(selectedSubCat == null)
            {
                MessageBox.Show("No subcategory is selected!");
                return;
            }

            await subcategoryData.RemoveSubcategory(selectedSubCat);

            LoadSubcategories();
        }
    }
}
