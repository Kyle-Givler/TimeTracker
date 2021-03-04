using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
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
        private EntryModel entryToEdit = null;

        public frmEditEntry(IProjectService projectService)
        {
            InitializeComponent();
            this.projectService = projectService;
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
    }
}
