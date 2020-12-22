﻿/*
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

        public frmEditCategory()
        {
            InitializeComponent();
        }

        private async void frmEditCategory_Load(object sender, EventArgs e)
        {
            SetupData();
        }

        public async void SetupData()
        {
            listBoxCategory.DataSource = categories;
            listBoxCategory.DisplayMember = "Name";

            await LoadCategories();
        }

        private async Task LoadCategories()
        {
            categories.Clear();

            var cats = await categoryData.LoadAllCategories();
            cats.ForEach(x => categories.Add(x));
        }

        private void btnAddCat_Click(object sender, EventArgs e)
        {
            CategoryModel cat = new CategoryModel();
            cat.Name = textBoxCategory.Text;

            categoryData.AddCategory(cat);

            textBoxCategory.Text = string.Empty;
            LoadCategories();
        }

        private void buttonAddSubCat_Click(object sender, EventArgs e)
        {

        }

        private async void btnDeleteCat_Click(object sender, EventArgs e)
        {
            CategoryModel selectedCat = (CategoryModel)listBoxCategory.SelectedItem;

            if(selectedCat == null)
            {
                return;
            }

            await categoryData.RemoveCategory(selectedCat);

            LoadCategories();
        }
    }
}