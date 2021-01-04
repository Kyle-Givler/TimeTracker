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

using System;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTrackerLibrary;
using TimeTrackerLibrary.Data;
using TimeTrackerLibrary.Models;
using TimeTrackerLibrary.Services;

namespace TimeTrackerUI
{
    public partial class frmAddEntry : Form
    {
        private readonly BindingList<ProjectModel> projects = new BindingList<ProjectModel>();
        private readonly BindingList<CategoryModel> categories = new BindingList<CategoryModel>();
        private readonly BindingList<SubcategoryModel> subcategories = new BindingList<SubcategoryModel>();

        private readonly IEntryData entryData = new EntryData(GlobalConfig.Connection);
        private readonly ProjectModel project;

        private bool ProcessIndexChange = true;

        public frmAddEntry(ProjectModel project)
        {
            InitializeComponent();
            this.project = project;
        }

        private async void frmAddEntry_Load(object sender, System.EventArgs e)
        {
            dateTimePickerStart.Value = dateTimePickerStart.Value.Date + new TimeSpan(dateTimePickerStart.Value.TimeOfDay.Hours, dateTimePickerStart.Value.TimeOfDay.Minutes, 0);
            dateTimePickerEnd.Value = dateTimePickerEnd.Value.Date + new TimeSpan(dateTimePickerEnd.Value.TimeOfDay.Hours, dateTimePickerEnd.Value.TimeOfDay.Minutes, 0);

            await SetupData();
        }

        private async Task SetupData()
        {
            listBoxProject.DataSource = projects;
            listBoxProject.DisplayMember = nameof(ProjectModel.Name);

            comboBoxCategory.DataSource = categories;
            comboBoxCategory.DisplayMember = nameof(CategoryModel.Name);

            comboBoxSubcategory.DataSource = subcategories;
            comboBoxSubcategory.DisplayMember = nameof(SubcategoryModel.Name);

            if (project != null)
            {
                await SelectProject();
            }
            else
            {
                await LoadCategories();
                await LoadSubcategories();
                await LoadProjects();
            }
        }

        private async Task SelectProject()
        {
            ProcessIndexChange = false;

            await LoadCategories();
            comboBoxCategory.SelectedItem = categories.Where(x => x.Id == project.Category.Id).FirstOrDefault();

            await LoadSubcategories();
            comboBoxSubcategory.SelectedItem = subcategories.Where(x => x.Id == project.Subcategory.Id).FirstOrDefault();

            await LoadProjects();
            listBoxProject.SelectedItem = projects.Where(x => x.Id == project.Id).FirstOrDefault();

            ProcessIndexChange = true;
        }

        private async Task LoadProjects()
        {
            projects.Clear();

            CategoryModel selectedCat = (CategoryModel)comboBoxCategory.SelectedItem;
            SubcategoryModel selectedSubCat = (SubcategoryModel)comboBoxSubcategory.SelectedItem;

            var projs = await ProjectService.GetInstance.LoadProjects(selectedCat, selectedSubCat, checkBoxAllProjects.Checked);
            projs.ForEach(x => projects.Add(x));
        }

        private async Task LoadCategories()
        {
            categories.Clear();

            var cats = await CategoryService.GetInstance.LoadAllCategories();
            cats.ForEach(x => categories.Add(x));
        }

        private async Task LoadSubcategories()
        {
            if (comboBoxCategory.SelectedItem == null)
            {
                return;
            }

            CategoryModel selectedCat = (CategoryModel)comboBoxCategory.SelectedItem;

            subcategories.Clear();

            var subCats = await SubcategoryService.GetInstance.LoadSubcategories(selectedCat);
            subCats.ForEach(x => subcategories.Add(x));

        }

        private async void comboBoxCategory_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (ProcessIndexChange)
            {
                if (comboBoxCategory.SelectedItem == null)
                {
                    return;
                }

                await LoadSubcategories();
                await LoadProjects(); 
            }
        }

        private void checkBoxAllProjects_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkBoxAllProjects.Checked)
            {
                comboBoxCategory.Enabled = false;
                comboBoxSubcategory.Enabled = false;
            }
            else
            {
                comboBoxCategory.Enabled = true;
                comboBoxSubcategory.Enabled = true;
            }

            LoadProjects();
        }

        private void btnAddEntry_Click(object sender, System.EventArgs e)
        {
            bool valid = false;

            if (radioButtonHours.Checked)
            {
                valid = AddEntryByHoursSpent();
            }
            else if (radioButtonTimes.Checked)
            {
                valid = AddEntryByTimes();
            }
            else if (radioButtonTimer.Checked)
            {

            }

            if (valid)
            {
                this.Close();
            }
        }

        private bool AddEntryByTimes()
        {
            var startTime = dateTimePickerStart.Value;
            var endTime = dateTimePickerEnd.Value;

            if (startTime > endTime)
            {
                MessageBox.Show("Start time must be before end time.");
                return false;
            }

            ProjectModel selectedProject = (ProjectModel)listBoxProject.SelectedItem;

            var difference = endTime - startTime;

            EntryModel entry = new EntryModel();

            entry.Project = selectedProject;
            entry.ProjectId = selectedProject.Id;
            entry.Date = dateTimePickerDate.Value;
            entry.Notes = textBoxNotes.Text;
            entry.HoursSpent = Math.Round(difference.TotalHours, 2);

            entryData.CreateEntry(entry);
            textBoxNotes.Text = string.Empty;

            return true;
        }

        private bool AddEntryByHoursSpent()
        {
            if (!double.TryParse(textBoxHoursSpent.Text, out double hours))
            {
                MessageBox.Show("Please enter a valid number of hours");
                return false;
            }

            ProjectModel selectedProject = (ProjectModel)listBoxProject.SelectedItem;

            if (selectedProject == null)
            {
                MessageBox.Show("Please select a project");
                return false;
            }

            EntryModel entry = new EntryModel();

            entry.Project = selectedProject;
            entry.ProjectId = selectedProject.Id;
            entry.Date = dateTimePickerDate.Value;
            entry.Notes = textBoxNotes.Text;
            entry.HoursSpent = hours;

            entryData.CreateEntry(entry);

            textBoxHoursSpent.Text = string.Empty;
            textBoxNotes.Text = string.Empty;

            return true;
        }

        private async void comboBoxSubcategory_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (ProcessIndexChange)
            {
                if (comboBoxSubcategory.SelectedItem == null)
                {
                    return;
                }

                await LoadProjects(); 
            }
        }

        private void buttonStartTimer_Click(object sender, System.EventArgs e)
        {
            if (!radioButtonTimer.Checked)
            {
                MessageBox.Show("Timer method is not selected");
            }

            timerTimeSpent.Tag = 0;
            timerTimeSpent.Enabled = true;
            timerTimeSpent.Start();
            timerUpdateDisplay.Start();
        }

        private void timerUpdateDisplay_Tick(object sender, System.EventArgs e)
        {
            lblTimerTest.Text = timerTimeSpent.Tag.ToString();
        }

        private void timerTimeSpent_Tick(object sender, System.EventArgs e)
        {
            timerTimeSpent.Tag = (int)timerTimeSpent.Tag + 1;
        }
    }
}