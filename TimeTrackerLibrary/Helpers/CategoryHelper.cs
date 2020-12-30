using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTrackerLibrary.Data;

namespace TimeTrackerLibrary.Helpers
{
    public static class CategoryHelper
    {
        private static readonly ICategoryData categoryData = new CategoryData(GlobalConfig.Connection);

        public static async Task<List<Models.CategoryModel>> LoadAllCategories()
        {
            var categories = await categoryData.LoadAllCategories();

            categories = categories.OrderBy(x => x.Name).ToList();
            return categories;
        }
    }
}
