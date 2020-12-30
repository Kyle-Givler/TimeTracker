using Dapper;
using System.Collections.Generic;
using System.Data;
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

        public Task CreateEntry(EntryModel entry)
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

            return entries;
        }
    }
}
