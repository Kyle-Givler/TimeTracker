
namespace TimeTrackerUI
{
    partial class frmAddEntry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblCreateEntry = new System.Windows.Forms.Label();
            this.lblProject = new System.Windows.Forms.Label();
            this.listBoxProject = new System.Windows.Forms.ListBox();
            this.lblSubcategory = new System.Windows.Forms.Label();
            this.comboBoxSubcategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.checkBoxAllProjects = new System.Windows.Forms.CheckBox();
            this.groupBoxSelectProj = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnAddEntry = new System.Windows.Forms.Button();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.groupBoxEntry = new System.Windows.Forms.GroupBox();
            this.lblHoursSpent = new System.Windows.Forms.Label();
            this.textBoxHoursSpent = new System.Windows.Forms.TextBox();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.timerTimeSpent = new System.Windows.Forms.Timer(this.components);
            this.groupBoxMethod = new System.Windows.Forms.GroupBox();
            this.lblSecondsValue = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.lblMinutesValue = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblHoursValue = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblTimerHoursValue = new System.Windows.Forms.Label();
            this.lblTimerHours = new System.Windows.Forms.Label();
            this.btnStopTimer = new System.Windows.Forms.Button();
            this.buttonStartTimer = new System.Windows.Forms.Button();
            this.radioButtonHours = new System.Windows.Forms.RadioButton();
            this.radioButtonTimes = new System.Windows.Forms.RadioButton();
            this.radioButtonTimer = new System.Windows.Forms.RadioButton();
            this.groupBoxSelectProj.SuspendLayout();
            this.groupBoxEntry.SuspendLayout();
            this.groupBoxMethod.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCreateEntry
            // 
            this.lblCreateEntry.AutoSize = true;
            this.lblCreateEntry.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCreateEntry.Location = new System.Drawing.Point(12, 9);
            this.lblCreateEntry.Name = "lblCreateEntry";
            this.lblCreateEntry.Size = new System.Drawing.Size(122, 25);
            this.lblCreateEntry.TabIndex = 16;
            this.lblCreateEntry.Text = "Create Entry";
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(23, 172);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(66, 21);
            this.lblProject.TabIndex = 19;
            this.lblProject.Text = "Project:";
            // 
            // listBoxProject
            // 
            this.listBoxProject.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBoxProject.FormattingEnabled = true;
            this.listBoxProject.ItemHeight = 17;
            this.listBoxProject.Location = new System.Drawing.Point(23, 196);
            this.listBoxProject.Name = "listBoxProject";
            this.listBoxProject.Size = new System.Drawing.Size(293, 276);
            this.listBoxProject.TabIndex = 18;
            // 
            // lblSubcategory
            // 
            this.lblSubcategory.AutoSize = true;
            this.lblSubcategory.Location = new System.Drawing.Point(23, 83);
            this.lblSubcategory.Name = "lblSubcategory";
            this.lblSubcategory.Size = new System.Drawing.Size(108, 21);
            this.lblSubcategory.TabIndex = 30;
            this.lblSubcategory.Text = "Subcategory:";
            // 
            // comboBoxSubcategory
            // 
            this.comboBoxSubcategory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSubcategory.FormattingEnabled = true;
            this.comboBoxSubcategory.Location = new System.Drawing.Point(23, 110);
            this.comboBoxSubcategory.Name = "comboBoxSubcategory";
            this.comboBoxSubcategory.Size = new System.Drawing.Size(293, 25);
            this.comboBoxSubcategory.TabIndex = 29;
            this.comboBoxSubcategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubcategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(23, 25);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(82, 21);
            this.lblCategory.TabIndex = 28;
            this.lblCategory.Text = "Category:";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(23, 52);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(293, 25);
            this.comboBoxCategory.TabIndex = 27;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // checkBoxAllProjects
            // 
            this.checkBoxAllProjects.AutoSize = true;
            this.checkBoxAllProjects.Location = new System.Drawing.Point(23, 141);
            this.checkBoxAllProjects.Name = "checkBoxAllProjects";
            this.checkBoxAllProjects.Size = new System.Drawing.Size(155, 25);
            this.checkBoxAllProjects.TabIndex = 31;
            this.checkBoxAllProjects.Text = "Show All Projects";
            this.checkBoxAllProjects.UseVisualStyleBackColor = true;
            this.checkBoxAllProjects.CheckedChanged += new System.EventHandler(this.checkBoxAllProjects_CheckedChanged);
            // 
            // groupBoxSelectProj
            // 
            this.groupBoxSelectProj.Controls.Add(this.lblCategory);
            this.groupBoxSelectProj.Controls.Add(this.checkBoxAllProjects);
            this.groupBoxSelectProj.Controls.Add(this.listBoxProject);
            this.groupBoxSelectProj.Controls.Add(this.lblSubcategory);
            this.groupBoxSelectProj.Controls.Add(this.lblProject);
            this.groupBoxSelectProj.Controls.Add(this.comboBoxSubcategory);
            this.groupBoxSelectProj.Controls.Add(this.comboBoxCategory);
            this.groupBoxSelectProj.Location = new System.Drawing.Point(12, 37);
            this.groupBoxSelectProj.Name = "groupBoxSelectProj";
            this.groupBoxSelectProj.Size = new System.Drawing.Size(365, 482);
            this.groupBoxSelectProj.TabIndex = 32;
            this.groupBoxSelectProj.TabStop = false;
            this.groupBoxSelectProj.Text = "Select Project";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.CalendarFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerDate.Location = new System.Drawing.Point(23, 48);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(269, 27);
            this.dateTimePickerDate.TabIndex = 33;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(23, 25);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(48, 21);
            this.lblDate.TabIndex = 34;
            this.lblDate.Text = "Date:";
            // 
            // btnAddEntry
            // 
            this.btnAddEntry.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddEntry.Location = new System.Drawing.Point(72, 377);
            this.btnAddEntry.Name = "btnAddEntry";
            this.btnAddEntry.Size = new System.Drawing.Size(164, 37);
            this.btnAddEntry.TabIndex = 37;
            this.btnAddEntry.Text = "Add Entry";
            this.btnAddEntry.UseVisualStyleBackColor = true;
            this.btnAddEntry.Click += new System.EventHandler(this.btnAddEntry_Click);
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(23, 165);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(269, 206);
            this.textBoxNotes.TabIndex = 39;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(23, 141);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(58, 21);
            this.lblNotes.TabIndex = 38;
            this.lblNotes.Text = "Notes:";
            // 
            // groupBoxEntry
            // 
            this.groupBoxEntry.Controls.Add(this.lblDate);
            this.groupBoxEntry.Controls.Add(this.textBoxNotes);
            this.groupBoxEntry.Controls.Add(this.dateTimePickerDate);
            this.groupBoxEntry.Controls.Add(this.lblNotes);
            this.groupBoxEntry.Controls.Add(this.btnAddEntry);
            this.groupBoxEntry.Location = new System.Drawing.Point(383, 37);
            this.groupBoxEntry.Name = "groupBoxEntry";
            this.groupBoxEntry.Size = new System.Drawing.Size(308, 482);
            this.groupBoxEntry.TabIndex = 32;
            this.groupBoxEntry.TabStop = false;
            this.groupBoxEntry.Text = "Add Entry";
            // 
            // lblHoursSpent
            // 
            this.lblHoursSpent.AutoSize = true;
            this.lblHoursSpent.Location = new System.Drawing.Point(6, 31);
            this.lblHoursSpent.Name = "lblHoursSpent";
            this.lblHoursSpent.Size = new System.Drawing.Size(105, 21);
            this.lblHoursSpent.TabIndex = 38;
            this.lblHoursSpent.Text = "Hours Spent:";
            // 
            // textBoxHoursSpent
            // 
            this.textBoxHoursSpent.Location = new System.Drawing.Point(6, 55);
            this.textBoxHoursSpent.Name = "textBoxHoursSpent";
            this.textBoxHoursSpent.Size = new System.Drawing.Size(105, 29);
            this.textBoxHoursSpent.TabIndex = 37;
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(6, 113);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(89, 21);
            this.lblStartTime.TabIndex = 40;
            this.lblStartTime.Text = "Start Time:";
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(6, 181);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(81, 21);
            this.lblEndTime.TabIndex = 42;
            this.lblEndTime.Text = "End Time:";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.CustomFormat = "h:mm tt";
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStart.Location = new System.Drawing.Point(6, 137);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.ShowUpDown = true;
            this.dateTimePickerStart.Size = new System.Drawing.Size(128, 29);
            this.dateTimePickerStart.TabIndex = 43;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.CustomFormat = "h:mm tt";
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(6, 202);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.ShowUpDown = true;
            this.dateTimePickerEnd.Size = new System.Drawing.Size(128, 29);
            this.dateTimePickerEnd.TabIndex = 44;
            // 
            // timerTimeSpent
            // 
            this.timerTimeSpent.Interval = 1000;
            this.timerTimeSpent.Tick += new System.EventHandler(this.timerTimeSpent_Tick);
            // 
            // groupBoxMethod
            // 
            this.groupBoxMethod.Controls.Add(this.lblSecondsValue);
            this.groupBoxMethod.Controls.Add(this.lblSeconds);
            this.groupBoxMethod.Controls.Add(this.lblMinutesValue);
            this.groupBoxMethod.Controls.Add(this.lblMinutes);
            this.groupBoxMethod.Controls.Add(this.lblHoursValue);
            this.groupBoxMethod.Controls.Add(this.lblHours);
            this.groupBoxMethod.Controls.Add(this.lblTimerHoursValue);
            this.groupBoxMethod.Controls.Add(this.lblTimerHours);
            this.groupBoxMethod.Controls.Add(this.btnStopTimer);
            this.groupBoxMethod.Controls.Add(this.buttonStartTimer);
            this.groupBoxMethod.Controls.Add(this.radioButtonHours);
            this.groupBoxMethod.Controls.Add(this.radioButtonTimes);
            this.groupBoxMethod.Controls.Add(this.radioButtonTimer);
            this.groupBoxMethod.Controls.Add(this.lblHoursSpent);
            this.groupBoxMethod.Controls.Add(this.dateTimePickerEnd);
            this.groupBoxMethod.Controls.Add(this.textBoxHoursSpent);
            this.groupBoxMethod.Controls.Add(this.dateTimePickerStart);
            this.groupBoxMethod.Controls.Add(this.lblStartTime);
            this.groupBoxMethod.Controls.Add(this.lblEndTime);
            this.groupBoxMethod.Location = new System.Drawing.Point(718, 37);
            this.groupBoxMethod.Name = "groupBoxMethod";
            this.groupBoxMethod.Size = new System.Drawing.Size(251, 470);
            this.groupBoxMethod.TabIndex = 45;
            this.groupBoxMethod.TabStop = false;
            this.groupBoxMethod.Text = "Entry Method";
            // 
            // lblSecondsValue
            // 
            this.lblSecondsValue.AutoSize = true;
            this.lblSecondsValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSecondsValue.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblSecondsValue.Location = new System.Drawing.Point(108, 418);
            this.lblSecondsValue.Name = "lblSecondsValue";
            this.lblSecondsValue.Size = new System.Drawing.Size(72, 20);
            this.lblSecondsValue.TabIndex = 58;
            this.lblSecondsValue.Text = "{seconds}";
            this.lblSecondsValue.Visible = false;
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblSeconds.Location = new System.Drawing.Point(27, 417);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(76, 21);
            this.lblSeconds.TabIndex = 57;
            this.lblSeconds.Text = "Seconds:";
            this.lblSeconds.Visible = false;
            // 
            // lblMinutesValue
            // 
            this.lblMinutesValue.AutoSize = true;
            this.lblMinutesValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMinutesValue.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblMinutesValue.Location = new System.Drawing.Point(109, 397);
            this.lblMinutesValue.Name = "lblMinutesValue";
            this.lblMinutesValue.Size = new System.Drawing.Size(71, 20);
            this.lblMinutesValue.TabIndex = 56;
            this.lblMinutesValue.Text = "{minutes}";
            this.lblMinutesValue.Visible = false;
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblMinutes.Location = new System.Drawing.Point(27, 396);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(73, 21);
            this.lblMinutes.TabIndex = 55;
            this.lblMinutes.Text = "Minutes:";
            this.lblMinutes.Visible = false;
            // 
            // lblHoursValue
            // 
            this.lblHoursValue.AutoSize = true;
            this.lblHoursValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHoursValue.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblHoursValue.Location = new System.Drawing.Point(109, 376);
            this.lblHoursValue.Name = "lblHoursValue";
            this.lblHoursValue.Size = new System.Drawing.Size(55, 20);
            this.lblHoursValue.TabIndex = 54;
            this.lblHoursValue.Text = "{hours}";
            this.lblHoursValue.Visible = false;
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblHours.Location = new System.Drawing.Point(27, 375);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(58, 21);
            this.lblHours.TabIndex = 53;
            this.lblHours.Text = "Hours:";
            this.lblHours.Visible = false;
            // 
            // lblTimerHoursValue
            // 
            this.lblTimerHoursValue.AutoSize = true;
            this.lblTimerHoursValue.Location = new System.Drawing.Point(120, 350);
            this.lblTimerHoursValue.Name = "lblTimerHoursValue";
            this.lblTimerHoursValue.Size = new System.Drawing.Size(61, 21);
            this.lblTimerHoursValue.TabIndex = 52;
            this.lblTimerHoursValue.Text = "{hours}";
            this.lblTimerHoursValue.Visible = false;
            // 
            // lblTimerHours
            // 
            this.lblTimerHours.AutoSize = true;
            this.lblTimerHours.Location = new System.Drawing.Point(6, 350);
            this.lblTimerHours.Name = "lblTimerHours";
            this.lblTimerHours.Size = new System.Drawing.Size(108, 21);
            this.lblTimerHours.TabIndex = 51;
            this.lblTimerHours.Text = "Timer Hours: ";
            this.lblTimerHours.Visible = false;
            // 
            // btnStopTimer
            // 
            this.btnStopTimer.Location = new System.Drawing.Point(6, 311);
            this.btnStopTimer.Name = "btnStopTimer";
            this.btnStopTimer.Size = new System.Drawing.Size(114, 33);
            this.btnStopTimer.TabIndex = 50;
            this.btnStopTimer.Text = "Stop Timer";
            this.btnStopTimer.UseVisualStyleBackColor = true;
            this.btnStopTimer.Click += new System.EventHandler(this.btnStopTimer_Click);
            // 
            // buttonStartTimer
            // 
            this.buttonStartTimer.Location = new System.Drawing.Point(6, 265);
            this.buttonStartTimer.Name = "buttonStartTimer";
            this.buttonStartTimer.Size = new System.Drawing.Size(114, 33);
            this.buttonStartTimer.TabIndex = 49;
            this.buttonStartTimer.Text = "Start Timer";
            this.buttonStartTimer.UseVisualStyleBackColor = true;
            this.buttonStartTimer.Click += new System.EventHandler(this.buttonStartTimer_Click);
            // 
            // radioButtonHours
            // 
            this.radioButtonHours.AutoSize = true;
            this.radioButtonHours.Checked = true;
            this.radioButtonHours.Location = new System.Drawing.Point(154, 56);
            this.radioButtonHours.Name = "radioButtonHours";
            this.radioButtonHours.Size = new System.Drawing.Size(94, 25);
            this.radioButtonHours.TabIndex = 48;
            this.radioButtonHours.TabStop = true;
            this.radioButtonHours.Text = "By Hours";
            this.radioButtonHours.UseVisualStyleBackColor = true;
            // 
            // radioButtonTimes
            // 
            this.radioButtonTimes.AutoSize = true;
            this.radioButtonTimes.Location = new System.Drawing.Point(154, 179);
            this.radioButtonTimes.Name = "radioButtonTimes";
            this.radioButtonTimes.Size = new System.Drawing.Size(86, 25);
            this.radioButtonTimes.TabIndex = 47;
            this.radioButtonTimes.Text = "By Time";
            this.radioButtonTimes.UseVisualStyleBackColor = true;
            // 
            // radioButtonTimer
            // 
            this.radioButtonTimer.AutoSize = true;
            this.radioButtonTimer.Location = new System.Drawing.Point(148, 293);
            this.radioButtonTimer.Name = "radioButtonTimer";
            this.radioButtonTimer.Size = new System.Drawing.Size(92, 25);
            this.radioButtonTimer.TabIndex = 46;
            this.radioButtonTimer.Text = "By Timer";
            this.radioButtonTimer.UseVisualStyleBackColor = true;
            // 
            // frmAddEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(981, 532);
            this.Controls.Add(this.groupBoxMethod);
            this.Controls.Add(this.groupBoxEntry);
            this.Controls.Add(this.groupBoxSelectProj);
            this.Controls.Add(this.lblCreateEntry);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Name = "frmAddEntry";
            this.Text = "Add Entry";
            this.Load += new System.EventHandler(this.frmAddEntry_Load);
            this.groupBoxSelectProj.ResumeLayout(false);
            this.groupBoxSelectProj.PerformLayout();
            this.groupBoxEntry.ResumeLayout(false);
            this.groupBoxEntry.PerformLayout();
            this.groupBoxMethod.ResumeLayout(false);
            this.groupBoxMethod.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreateEntry;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.ListBox listBoxProject;
        private System.Windows.Forms.Label lblSubcategory;
        private System.Windows.Forms.ComboBox comboBoxSubcategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.CheckBox checkBoxAllProjects;
        private System.Windows.Forms.GroupBox groupBoxSelectProj;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnAddEntry;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.GroupBox groupBoxEntry;
        private System.Windows.Forms.Label lblHoursSpent;
        private System.Windows.Forms.TextBox textBoxHoursSpent;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Timer timerTimeSpent;
        private System.Windows.Forms.GroupBox groupBoxMethod;
        private System.Windows.Forms.RadioButton radioButtonHours;
        private System.Windows.Forms.RadioButton radioButtonTimes;
        private System.Windows.Forms.RadioButton radioButtonTimer;
        private System.Windows.Forms.Button btnStopTimer;
        private System.Windows.Forms.Button buttonStartTimer;
        private System.Windows.Forms.Label lblTimerHours;
        private System.Windows.Forms.Label lblTimerHoursValue;
        private System.Windows.Forms.Label lblSecondsValue;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Label lblMinutesValue;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblHoursValue;
        private System.Windows.Forms.Label lblHours;
    }
}