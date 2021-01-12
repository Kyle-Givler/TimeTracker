using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTrackerLibrary.DataAccess;
using TimeTrackerLibrary.Models;

namespace TimeTrackerLibrary.Data
{
    public class SQLiteEntryData : IEntryData
    {
        private readonly IDataAccess dataAccess;

        public SQLiteEntryData(IDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        public async Task<int> CreateEntry(EntryModel entry)
        {
            StringBuilder sql = new StringBuilder("insert into Entry (ProjectId, HoursSpent, Date, Notes) ");
            sql.Append("values (@ProjectId, @HoursSpent, @Date, @Notes");

            await dataAccess.ExecuteRawSQL<dynamic>(sql.ToString(), new
            {
                ProjectId = entry.Project.Id,
                HoursSpent = entry.HoursSpent,
                Date = entry.Date,
                Notes = entry.Notes
            });

            entry.Id = (int)dataAccess.QueryRawSQL<Int64, dynamic>("select last_insert_rowid(); ", new { }).Result.ToList().FirstOrDefault();

            return entry.Id;
        }

        public async Task<List<EntryModel>> LoadAllEntries()
        {
            string sql = "select [Id], [ProjectId], [HoursSpent], [Date], [Notes] from Entry;";

            var entries = await dataAccess.QueryRawSQL<EntryModel, dynamic>(sql, new { });

            foreach (var e in entries)
            {
                await RehydrateObjects(e);
            }

            return entries;
        }

        public Task<List<EntryModel>> LoadEntriesByCategory(CategoryModel category)
        {
            throw new NotImplementedException();
        }

        public async Task<List<EntryModel>> LoadEntriesByProject(ProjectModel project)
        {
            string sql = "select [Id], [ProjectId], [HoursSpent], [Date], [Notes] from Entry where ProjectId = @ProjectId;";

            var entries = await dataAccess.QueryRawSQL<EntryModel, dynamic>(sql, new { });

            foreach (var e in entries)
            {
                await RehydrateObjects(e);
            }

            return entries;
        }

        public Task<List<EntryModel>> LoadEntriesBySubcategory(SubcategoryModel subcategory)
        {
            throw new NotImplementedException();
        }

        public Task RemoveEntry(EntryModel entry)
        {
            string sql = "delete from Entry where Id = @Id";

            return dataAccess.ExecuteRawSQL<dynamic>(sql, new { Id = entry.Id });
        }

        public Task RemoveEntryByProject(ProjectModel project)
        {
            string sql = "delete from Entry where ProjectId = @ProjectId";

            return dataAccess.ExecuteRawSQL<dynamic>(sql, new { ProjectId = project.Id });
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
