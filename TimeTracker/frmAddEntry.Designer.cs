
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
            this.textBoxHoursSpent = new System.Windows.Forms.TextBox();
            this.lblHoursSpent = new System.Windows.Forms.Label();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.groupBoxEntry = new System.Windows.Forms.GroupBox();
            this.groupBoxSelectProj.SuspendLayout();
            this.groupBoxEntry.SuspendLayout();
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
            this.dateTimePickerDate.Location = new System.Drawing.Point(23, 64);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(269, 27);
            this.dateTimePickerDate.TabIndex = 33;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(23, 41);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(48, 21);
            this.lblDate.TabIndex = 34;
            this.lblDate.Text = "Date:";
            // 
            // btnAddEntry
            // 
            this.btnAddEntry.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddEntry.Location = new System.Drawing.Point(86, 412);
            this.btnAddEntry.Name = "btnAddEntry";
            this.btnAddEntry.Size = new System.Drawing.Size(164, 37);
            this.btnAddEntry.TabIndex = 37;
            this.btnAddEntry.Text = "Add Entry";
            this.btnAddEntry.UseVisualStyleBackColor = true;
            // 
            // textBoxHoursSpent
            // 
            this.textBoxHoursSpent.Location = new System.Drawing.Point(23, 123);
            this.textBoxHoursSpent.Name = "textBoxHoursSpent";
            this.textBoxHoursSpent.Size = new System.Drawing.Size(269, 29);
            this.textBoxHoursSpent.TabIndex = 35;
            // 
            // lblHoursSpent
            // 
            this.lblHoursSpent.AutoSize = true;
            this.lblHoursSpent.Location = new System.Drawing.Point(23, 99);
            this.lblHoursSpent.Name = "lblHoursSpent";
            this.lblHoursSpent.Size = new System.Drawing.Size(105, 21);
            this.lblHoursSpent.TabIndex = 36;
            this.lblHoursSpent.Text = "Hours Spent:";
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(23, 185);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(269, 206);
            this.textBoxNotes.TabIndex = 39;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(23, 161);
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
            this.groupBoxEntry.Controls.Add(this.lblHoursSpent);
            this.groupBoxEntry.Controls.Add(this.btnAddEntry);
            this.groupBoxEntry.Controls.Add(this.textBoxHoursSpent);
            this.groupBoxEntry.Location = new System.Drawing.Point(383, 37);
            this.groupBoxEntry.Name = "groupBoxEntry";
            this.groupBoxEntry.Size = new System.Drawing.Size(337, 483);
            this.groupBoxEntry.TabIndex = 32;
            this.groupBoxEntry.TabStop = false;
            this.groupBoxEntry.Text = "Add Entry";
            // 
            // frmAddEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(733, 532);
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
        private System.Windows.Forms.TextBox textBoxHoursSpent;
        private System.Windows.Forms.Label lblHoursSpent;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.GroupBox groupBoxEntry;
    }
}