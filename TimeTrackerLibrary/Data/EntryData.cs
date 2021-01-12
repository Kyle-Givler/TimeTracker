using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using TimeTrackerLibrary.DataAccess;
using TimeTrackerLibrary.Models;

namespace TimeTrackerLibrary.Data
{
    public class EntryData : IEntryData
    {
        private readonly IDataAccess dataAccess;

        public EntryData(IDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        public Task<int> CreateEntry(EntryModel entry)
        {
            DynamicParameters p = new DynamicParameters();

            p.Add("ProjectId", entry.ProjectId);
            p.Add("HoursSpent", entry.HoursSpent);
            p.Add("Date", entry.Date);
            p.Add("Notes", entry.Notes);
            p.Add("Id", 0, DbType.Int32, direction: ParameterDirection.Output);

            return dataAccess.SaveData("dbo.spEntry_Insert", p);
        }

        public async Task<List<EntryModel>> LoadAllEntries()
        {
            var entries = await dataAccess.LoadData<EntryModel, dynamic>("dbo.spEntry_GetAll", new { });

            foreach (var e in entries)
            {
                await RehydrateObjects(e);
            }
            
            return entries;
        }

        public Task<List<EntryModel>> LoadEntriesByCategory(CategoryModel category)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<EntryModel>> LoadEntriesByProject(ProjectModel project)
        {
            var entries = await dataAccess.LoadData<EntryModel, dynamic>("dbo.spEntry_GetByProjectId", new { ProjectId = project.Id });

            foreach (var e in entries)
            {
                await RehydrateObjects(e);
            }

            return entries;
        }

        public Task<List<EntryModel>> LoadEntriesBySubcategory(SubcategoryModel subcategory)
        {
            throw new System.NotImplementedException();
        }

        public Task RemoveEntry(EntryModel entry)
        {
            return dataAccess.SaveData("spEntry_Delete", new { Id = entry.Id });
        }

        public Task RemoveEntryByProject(ProjectModel project)
        {
            return dataAccess.SaveData("spEntry_DeleteByProject", new { ProjectId = project.Id});
        }

        private async Task RehydrateObjects(EntryModel e)
        {
            // TODO find a better way to do this with Dapper
            var p = await dataAccess.QueryRawSQL<ProjectModel, dynamic>("SELECT * FROM Project WHERE ID = @Id", new { Id = e.ProjectId });
            e.Project = p.First();
            var c = await dataAccess.QueryRawSQL<CategoryModel, dynamic>("SELECT * FROM Category WHERE ID = @Id", new { Id = e.Project.CategoryId });
            e.Project.Category = c.First();
            var s = await dataAccess.QueryRawSQL<SubcategoryModel, dynamic>("SELECT * FROM Subcategory WHERE ID = @Id", new { Id = e.Project.SubcategoryId });
            e.Project.Subcategory = s.FirstOrDefault();
        }
    }
}
