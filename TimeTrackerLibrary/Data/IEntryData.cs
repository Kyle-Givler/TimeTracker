using System.Collections.Generic;
using System.Threading.Tasks;
using TimeTrackerLibrary.Models;

namespace TimeTrackerLibrary.Data
{
    public interface IEntryData
    {
        Task CreateEntry(EntryModel entry);

        Task<List<EntryModel>> LoadAllEntries();
    }
}