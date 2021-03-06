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
using System.Linq;
using System.Threading.Tasks;
using TimeTrackerLibrary.Data;
using TimeTrackerLibrary.Interfaces;
using TimeTrackerLibrary.Models;

namespace TimeTrackerLibrary.Services
{
    public sealed class CategoryService : ICategoryService
    {
        private readonly ICategoryData categoryData;
        private readonly IConfig config;

        public CategoryService(ICategoryData categoryData, IConfig config)
        {
            this.categoryData = categoryData;
            this.config = config;
        }

        public async Task<List<Models.CategoryModel>> LoadAllCategories()
        {
            var categories = await categoryData.LoadAllCategories();

            categories = categories.OrderBy(x => x.Name).ToList();
            return categories;
        }

        public async Task DeleteCategory(CategoryModel category)
        {
            var rows = await config.Connection.QueryRawSQL<int, dynamic>($"SELECT COUNT (Id) FROM Subcategory WHERE CategoryId = {category.Id};", new { });

            if (rows.First() != 0)
            {
                throw new ArgumentException("Category contains subcategories", "category");
            }

            await categoryData.RemoveCategory(category);
        }
    }
}
