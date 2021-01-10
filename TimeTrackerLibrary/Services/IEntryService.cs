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

using System.Threading.Tasks;
using TimeTrackerLibrary.Models;

namespace TimeTrackerLibrary.Services
{
    public interface IEntryService
    {
        /// <summary>
        /// Get the number of hours tracked in a given category
        /// </summary>
        /// <param name="category">The category to get total hours tracked for</param>
        /// <returns>The number of hours tracked in the given category</returns>
        Task<double> GetTimeByCategory(CategoryModel category);

        /// <summary>
        /// Get the number of hours tracked in a given category
        /// </summary>
        /// <param name="project">The project to get total hours tracked for</param>
        /// <returns>The number of hours tracked in the given project</returns>
        Task<double> GetTimeByProject(ProjectModel project);

        /// <summary>
        /// Get the number of hours tracked in a given subcategory
        /// </summary>
        /// <param name="subcategory">The subcategory to get total hours tracked for</param>
        /// <returns>The number of hours tracked in the given subcategory</returns>
        Task<double> GetTimeBySubcategory(SubcategoryModel subcategory);

        /// <summary>
        /// Get the number of hours tracked by the application
        /// </summary>
        /// <returns>The number of hours tracked by the application</returns>
        Task<double> GetTotalTimeAllEntries();
    }
}