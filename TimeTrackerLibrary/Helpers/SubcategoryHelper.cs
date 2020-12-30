using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTrackerLibrary.Data;
using TimeTrackerLibrary.Models;

namespace TimeTrackerLibrary.Helpers
{
    public static class SubcategoryHelper
    {
        private static readonly ISubcategoryData subcategoryData = new SubcategoryData(GlobalConfig.Connection);

        public static async Task<List<SubcategoryModel>> LoadSubcategories(CategoryModel category)
        {
            if(category == null)
            {
                throw new NullReferenceException("category must not be null");
            }

            var subcategories = await subcategoryData.LoadSubcategories(category);
            subcategories = subcategories.OrderBy(x => x.Name).ToList();

            return subcategories;
        }
    }
}
