using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TimeTrackerLibrary.Data;
using TimeTrackerLibrary.Interfaces;
using TimeTrackerLibrary.Models;
using TimeTrackerLibrary.Services;

namespace TimeTrackerUI
{
    public partial class frmEditEntry : Form, INavigatable
    {
        public EntryModel EntryToEdit
        {
            set
            {
                if(entryToEdit != null)
                {
                    throw new InvalidOperationException("EntryToEdit has already been assigned");
                }

                entryToEdit = value;
                UpdateControls();
            }

            get
            {
                return entryToEdit;
            }
        }

        private readonly IProjectService projectService;
        private readonly IEntryData entryData;
        private EntryModel entryToEdit = null;

        public frmEditEntry(IProjectService projectService,
            IEntryData entryData)
        {
            InitializeComponent();
            this.projectService = projectService;
            this.entryData = entryData;
        }

        private void UpdateControls()
        {
            if(entryToEdit == null)
            {
                throw new InvalidOperationException("EntryToEdit is not set");
            }

            textBoxNotes.Text = entryToEdit.Notes;
            textBoxHoursSpent.Text = entryToEdit.HoursSpent.ToString();
            dateTimePickerDate.Value = entryToEdit.Date.DateTime;
        }

        public void Navigate()
        {
            Show();
        }

        private void btnUpdateEntry_Click(object sender, EventArgs e)
        {
            if (!DataIsValid())
                return;

            entryToEdit.Date = dateTimePickerDate.Value;
            entryToEdit.HoursSpent = double.Parse(textBoxHoursSpent.Text);
            entryToEdit.Notes = textBoxNotes.Text;

            entryData.UpdateEntry(entryToEdit);

            this.Close();
        }

        private bool DataIsValid()
        {
            if(!double.TryParse(textBoxHoursSpent.Text, out _))
            {
                MessageBox.Show("Please entry a valid number of hours spent.");
                return false;
            }

            return true;
        }
    }
}
