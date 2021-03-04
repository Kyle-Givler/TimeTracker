/*
MIT License

Copyright(c) 2021 Kyle Givler
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

using System;
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
