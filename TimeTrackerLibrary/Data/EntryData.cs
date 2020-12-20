using System;
using System.Collections.Generic;
using System.Text;
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

        public async Task<List<EntryModel>> LoadAllEntries()
        {
            var entries = await dataAccess.LoadData<EntryModel, dynamic>("dbo.spEntry_GetAll", new { });

            return entries;
        }
    }
}
