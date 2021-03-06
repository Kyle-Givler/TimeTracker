﻿/*
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
using TimeTrackerLibrary.Data;
using TimeTrackerLibrary.Interfaces;
using TimeTrackerLibrary.Models;
using TimeTrackerLibrary.Services;

namespace TimeTrackerUI
{
    public partial class frmAddEntry : Form, INavigatable
    {
        private readonly BindingList<ProjectModel> projects = new BindingList<ProjectModel>();
        private readonly BindingList<CategoryModel> categories = new BindingList<CategoryModel>();
        private readonly BindingList<SubcategoryModel> subcategories = new BindingList<SubcategoryModel>();

        private readonly IProjectService projectService;
        private readonly ICategoryService categoryService;
        private readonly ISubcategoryService subcategoryService;
        private readonly IEntryData entryData;

        private uint timerSeconds = 0;

        private bool processIndexChange = true;
        private bool projectAssigned = false;

        private ProjectModel project;

        public ProjectModel InitialProject {
            set
            {
                if (projectAssigned)
                {
                    throw new InvalidOperationException("Project has already been assigned");
                }

                project = value;
            }

            get 
            {
                return project;
            }
        }

        public frmAddEntry(IProjectService projectService,
            ICategoryService categoryService,
            ISubcategoryService subcategoryService,
            IEntryData entryData)
        {
            InitializeComponent();
            this.projectService = projectService;
            this.categoryService = categoryService;
            this.subcategoryService = subcategoryService;
            this.entryData = entryData;
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
            processIndexChange = false;

            await LoadCategories();
            comboBoxCategory.SelectedItem = categories.Where(x => x.Id == project.Category.Id).FirstOrDefault();

            await LoadSubcategories();
            comboBoxSubcategory.SelectedItem = subcategories.Where(x => x.Id == project.Subcategory.Id).FirstOrDefault();

            await LoadProjects();
            listBoxProject.SelectedItem = projects.Where(x => x.Id == project.Id).FirstOrDefault();

            processIndexChange = true;
        }

        private async Task LoadProjects()
        {
            projects.Clear();

            CategoryModel selectedCat = (CategoryModel)comboBoxCategory.SelectedItem;
            SubcategoryModel selectedSubCat = (SubcategoryModel)comboBoxSubcategory.SelectedItem;

            if(selectedCat == null)
            {
                return;
            }

            var projs = await projectService.LoadProjects(selectedCat, selectedSubCat, checkBoxAllProjects.Checked);
            projs.ForEach(x => projects.Add(x));
        }

        private async Task LoadCategories()
        {
            categories.Clear();

            var cats = await categoryService.LoadAllCategories();
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

            var subCats = await subcategoryService.LoadSubcategories(selectedCat);
            subCats.ForEach(x => subcategories.Add(x));

        }

        private async void comboBoxCategory_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (processIndexChange)
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
                valid = AddEntryByTimer();
            }

            if (valid)
            {
                this.Close();
            }
        }

        private bool AddEntryByTimer()
        {
            if (timerTimeSpent.Enabled)
            {
                MessageBox.Show("Please stop the timer first!");
                return false;
            }

            ProjectModel selectedProject = (ProjectModel)listBoxProject.SelectedItem;
            EntryModel entry = new EntryModel();

            entry.Project = selectedProject;
            entry.ProjectId = selectedProject.Id;
            entry.Date = dateTimePickerDate.Value;
            entry.Notes = textBoxNotes.Text;
            entry.HoursSpent = Math.Round(timerSeconds / 3600d, 2);

            entryData.CreateEntry(entry);
            textBoxNotes.Text = string.Empty;

            return true;
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
            if (processIndexChange)
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
                return;
            }

            lblTimerHours.Visible = true;
            lblTimerHoursValue.Visible = true;

            lblHours.Visible = true;
            lblHoursValue.Visible = true;
            lblMinutes.Visible = true;
            lblMinutesValue.Visible = true;
            lblSeconds.Visible = true;
            lblSecondsValue.Visible = true;

            UpdateTimerLabels();

            timerTimeSpent.Enabled = true;
            timerTimeSpent.Start();
        }

        private void timerTimeSpent_Tick(object sender, System.EventArgs e)
        {
            timerSeconds++;
            UpdateTimerLabels();
        }

        private void btnStopTimer_Click(object sender, EventArgs e)
        {
            timerTimeSpent.Stop();
        }

        private void UpdateTimerLabels()
        {
            TimeSpan time = TimeSpan.FromSeconds(timerSeconds);

            lblTimerHoursValue.Text = $"{(timerSeconds / 3600d):F4}";

            lblHoursValue.Text = $"{time.Hours}";
            lblMinutesValue.Text = $"{time.Minutes}";
            lblSecondsValue.Text = $"{time.Seconds}";
        }

        public void Navigate()
        {
            Show();
        }
    }
}