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

using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using TimeTrackerLibrary.DataAccess;
using TimeTrackerLibrary.Models;

namespace TimeTrackerLibrary.Data
{
    public class SubcategoryData : ISubcategoryData
    {
        private readonly IDataAccess dataAccess;

        public SubcategoryData(IDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        public async Task<int> AddSubcategory(SubcategoryModel subcategory)
        {
            DynamicParameters p = new DynamicParameters();

            p.Add("Name", subcategory.Name);
            p.Add("CategoryId", subcategory.Category.Id);
            p.Add("Id", 0, DbType.Int32, direction: ParameterDirection.Output);

            await dataAccess.SaveData("dbo.spSubcategory_Insert", p);

            return p.Get<int>("Id");
        }

        public Task<List<SubcategoryModel>> LoadSubcategories(CategoryModel category)
        {
            return dataAccess.LoadData<SubcategoryModel, dynamic>("dbo.spSubcategory_GetByCategoryId", new { CategoryId = category.Id });
        }

        public Task RemoveSubcategory(SubcategoryModel subcategory)
        {
            return dataAccess.SaveData("dbo.spSubcategory_Delete", new { Id = subcategory.Id });
        }
    }
}
