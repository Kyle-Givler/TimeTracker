using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTrackerLibrary;
using TimeTrackerLibrary.Data;
using TimeTrackerLibrary.Models;

namespace TimeTracker
{
    public partial class frmMain : Form
    {
        private readonly BindingList<EntryModel> entries = new BindingList<EntryModel>();

        private readonly IEntryData entryData = new EntryData(GlobalConfig.Connection);

        public frmMain()
        {
            InitializeComponent();
        }

        private async void frmMain_Load(object sender, EventArgs e)
        {
            await LoadEntries();
        }

        private async Task LoadEntries()
        {
            entries.Clear();
            var allEntries = await entryData.LoadAllEntries();

            allEntries.ForEach(x => entries.Add(x));
        }
    }
}
