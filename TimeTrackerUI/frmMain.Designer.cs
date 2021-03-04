﻿
namespace TimeTrackerUI
{
    partial class frmMain
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
            this.listBoxEntries = new System.Windows.Forms.ListBox();
            this.lblProject = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblSubCategory = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTimeSpent = new System.Windows.Forms.Label();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblTimeSpentValue = new System.Windows.Forms.Label();
            this.lblEntryDateValue = new System.Windows.Forms.Label();
            this.lblsubcategoryValue = new System.Windows.Forms.Label();
            this.lblCategoryValue = new System.Windows.Forms.Label();
            this.lblProjectValue = new System.Windows.Forms.Label();
            this.btnAddEntry = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblEntries = new System.Windows.Forms.Label();
            this.btnEditCat = new System.Windows.Forms.Button();
            this.btnEditProjects = new System.Windows.Forms.Button();
            this.groupBoxSelectProj = new System.Windows.Forms.GroupBox();
            this.lblCat = new System.Windows.Forms.Label();
            this.checkBoxAllProjects = new System.Windows.Forms.CheckBox();
            this.listBoxProject = new System.Windows.Forms.ListBox();
            this.lblSubCat = new System.Windows.Forms.Label();
            this.lblProj = new System.Windows.Forms.Label();
            this.comboBoxSubcategory = new System.Windows.Forms.ComboBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.lblTimeTracker = new System.Windows.Forms.Label();
            this.linkLabelGitHub = new System.Windows.Forms.LinkLabel();
            this.checkBoxEntries = new System.Windows.Forms.CheckBox();
            this.lblProjectTotalValue = new System.Windows.Forms.Label();
            this.lblProjectTotal = new System.Windows.Forms.Label();
            this.lblCategoryTimeValue = new System.Windows.Forms.Label();
            this.lblCategoryTime = new System.Windows.Forms.Label();
            this.lblSubcategoryTotalValue = new System.Windows.Forms.Label();
            this.lblsubcategoryTotal = new System.Windows.Forms.Label();
            this.lblAllTimeValue = new System.Windows.Forms.Label();
            this.lblAllTime = new System.Windows.Forms.Label();
            this.groupBoxSelectProj.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxEntries
            // 
            this.listBoxEntries.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBoxEntries.FormattingEnabled = true;
            this.listBoxEntries.ItemHeight = 17;
            this.listBoxEntries.Location = new System.Drawing.Point(382, 83);
            this.listBoxEntries.Name = "listBoxEntries";
            this.listBoxEntries.Size = new System.Drawing.Size(218, 429);
            this.listBoxEntries.TabIndex = 0;
            this.listBoxEntries.SelectedIndexChanged += new System.EventHandler(this.listBoxEntries_SelectedIndexChanged);
            this.listBoxEntries.DoubleClick += new System.EventHandler(this.listBoxEntries_DoubleClick);
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(625, 63);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(66, 21);
            this.lblProject.TabIndex = 1;
            this.lblProject.Text = "Project:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(625, 120);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(82, 21);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Category:";
            // 
            // lblSubCategory
            // 
            this.lblSubCategory.AutoSize = true;
            this.lblSubCategory.Location = new System.Drawing.Point(625, 178);
            this.lblSubCategory.Name = "lblSubCategory";
            this.lblSubCategory.Size = new System.Drawing.Size(108, 21);
            this.lblSubCategory.TabIndex = 1;
            this.lblSubCategory.Text = "Subcategory:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(625, 230);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(90, 21);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Entry Date:";
            // 
            // lblTimeSpent
            // 
            this.lblTimeSpent.AutoSize = true;
            this.lblTimeSpent.Location = new System.Drawing.Point(625, 252);
            this.lblTimeSpent.Name = "lblTimeSpent";
            this.lblTimeSpent.Size = new System.Drawing.Size(97, 21);
            this.lblTimeSpent.TabIndex = 1;
            this.lblTimeSpent.Text = "Time Spent:";
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(625, 345);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(409, 164);
            this.textBoxNotes.TabIndex = 2;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(625, 321);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(58, 21);
            this.lblNotes.TabIndex = 1;
            this.lblNotes.Text = "Notes:";
            // 
            // lblTimeSpentValue
            // 
            this.lblTimeSpentValue.AutoSize = true;
            this.lblTimeSpentValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTimeSpentValue.Location = new System.Drawing.Point(728, 253);
            this.lblTimeSpentValue.Name = "lblTimeSpentValue";
            this.lblTimeSpentValue.Size = new System.Drawing.Size(89, 20);
            this.lblTimeSpentValue.TabIndex = 3;
            this.lblTimeSpentValue.Text = "{time spent}";
            // 
            // lblEntryDateValue
            // 
            this.lblEntryDateValue.AutoSize = true;
            this.lblEntryDateValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEntryDateValue.Location = new System.Drawing.Point(721, 231);
            this.lblEntryDateValue.Name = "lblEntryDateValue";
            this.lblEntryDateValue.Size = new System.Drawing.Size(86, 20);
            this.lblEntryDateValue.TabIndex = 4;
            this.lblEntryDateValue.Text = "{entry date}";
            // 
            // lblsubcategoryValue
            // 
            this.lblsubcategoryValue.AutoSize = true;
            this.lblsubcategoryValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblsubcategoryValue.Location = new System.Drawing.Point(739, 179);
            this.lblsubcategoryValue.Name = "lblsubcategoryValue";
            this.lblsubcategoryValue.Size = new System.Drawing.Size(100, 20);
            this.lblsubcategoryValue.TabIndex = 5;
            this.lblsubcategoryValue.Text = "{subcategory}";
            // 
            // lblCategoryValue
            // 
            this.lblCategoryValue.AutoSize = true;
            this.lblCategoryValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCategoryValue.Location = new System.Drawing.Point(713, 121);
            this.lblCategoryValue.Name = "lblCategoryValue";
            this.lblCategoryValue.Size = new System.Drawing.Size(77, 20);
            this.lblCategoryValue.TabIndex = 6;
            this.lblCategoryValue.Text = "{category}";
            // 
            // lblProjectValue
            // 
            this.lblProjectValue.AutoSize = true;
            this.lblProjectValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProjectValue.Location = new System.Drawing.Point(697, 64);
            this.lblProjectValue.Name = "lblProjectValue";
            this.lblProjectValue.Size = new System.Drawing.Size(66, 20);
            this.lblProjectValue.TabIndex = 7;
            this.lblProjectValue.Text = "{project}";
            // 
            // btnAddEntry
            // 
            this.btnAddEntry.Location = new System.Drawing.Point(316, 525);
            this.btnAddEntry.Name = "btnAddEntry";
            this.btnAddEntry.Size = new System.Drawing.Size(146, 37);
            this.btnAddEntry.TabIndex = 8;
            this.btnAddEntry.Text = "New Entry";
            this.btnAddEntry.UseVisualStyleBackColor = true;
            this.btnAddEntry.Click += new System.EventHandler(this.btnAddEntry_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(468, 525);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(146, 37);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblEntries
            // 
            this.lblEntries.AutoSize = true;
            this.lblEntries.Location = new System.Drawing.Point(382, 59);
            this.lblEntries.Name = "lblEntries";
            this.lblEntries.Size = new System.Drawing.Size(63, 21);
            this.lblEntries.TabIndex = 10;
            this.lblEntries.Text = "Entries:";
            // 
            // btnEditCat
            // 
            this.btnEditCat.Location = new System.Drawing.Point(12, 525);
            this.btnEditCat.Name = "btnEditCat";
            this.btnEditCat.Size = new System.Drawing.Size(146, 37);
            this.btnEditCat.TabIndex = 11;
            this.btnEditCat.Text = "Edit Categories";
            this.btnEditCat.UseVisualStyleBackColor = true;
            this.btnEditCat.Click += new System.EventHandler(this.btnEditCat_Click);
            // 
            // btnEditProjects
            // 
            this.btnEditProjects.Location = new System.Drawing.Point(164, 525);
            this.btnEditProjects.Name = "btnEditProjects";
            this.btnEditProjects.Size = new System.Drawing.Size(146, 37);
            this.btnEditProjects.TabIndex = 12;
            this.btnEditProjects.Text = "Edit Projects";
            this.btnEditProjects.UseVisualStyleBackColor = true;
            this.btnEditProjects.Click += new System.EventHandler(this.btnEditProjects_Click);
            // 
            // groupBoxSelectProj
            // 
            this.groupBoxSelectProj.Controls.Add(this.lblCat);
            this.groupBoxSelectProj.Controls.Add(this.checkBoxAllProjects);
            this.groupBoxSelectProj.Controls.Add(this.listBoxProject);
            this.groupBoxSelectProj.Controls.Add(this.lblSubCat);
            this.groupBoxSelectProj.Controls.Add(this.lblProj);
            this.groupBoxSelectProj.Controls.Add(this.comboBoxSubcategory);
            this.groupBoxSelectProj.Controls.Add(this.comboBoxCategory);
            this.groupBoxSelectProj.Location = new System.Drawing.Point(12, 37);
            this.groupBoxSelectProj.Name = "groupBoxSelectProj";
            this.groupBoxSelectProj.Size = new System.Drawing.Size(339, 482);
            this.groupBoxSelectProj.TabIndex = 33;
            this.groupBoxSelectProj.TabStop = false;
            this.groupBoxSelectProj.Text = "Select Project";
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Location = new System.Drawing.Point(23, 25);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(82, 21);
            this.lblCat.TabIndex = 28;
            this.lblCat.Text = "Category:";
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
            // listBoxProject
            // 
            this.listBoxProject.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBoxProject.FormattingEnabled = true;
            this.listBoxProject.ItemHeight = 17;
            this.listBoxProject.Location = new System.Drawing.Point(23, 196);
            this.listBoxProject.Name = "listBoxProject";
            this.listBoxProject.Size = new System.Drawing.Size(293, 276);
            this.listBoxProject.TabIndex = 18;
            this.listBoxProject.SelectedIndexChanged += new System.EventHandler(this.listBoxProject_SelectedIndexChanged);
            // 
            // lblSubCat
            // 
            this.lblSubCat.AutoSize = true;
            this.lblSubCat.Location = new System.Drawing.Point(23, 83);
            this.lblSubCat.Name = "lblSubCat";
            this.lblSubCat.Size = new System.Drawing.Size(108, 21);
            this.lblSubCat.TabIndex = 30;
            this.lblSubCat.Text = "Subcategory:";
            // 
            // lblProj
            // 
            this.lblProj.AutoSize = true;
            this.lblProj.Location = new System.Drawing.Point(23, 172);
            this.lblProj.Name = "lblProj";
            this.lblProj.Size = new System.Drawing.Size(66, 21);
            this.lblProj.TabIndex = 19;
            this.lblProj.Text = "Project:";
            // 
            // comboBoxSubcategory
            // 
            this.comboBoxSubcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubcategory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSubcategory.FormattingEnabled = true;
            this.comboBoxSubcategory.Location = new System.Drawing.Point(23, 110);
            this.comboBoxSubcategory.Name = "comboBoxSubcategory";
            this.comboBoxSubcategory.Size = new System.Drawing.Size(293, 25);
            this.comboBoxSubcategory.TabIndex = 29;
            this.comboBoxSubcategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubcategory_SelectedIndexChanged);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(23, 52);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(293, 25);
            this.comboBoxCategory.TabIndex = 27;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // lblTimeTracker
            // 
            this.lblTimeTracker.AutoSize = true;
            this.lblTimeTracker.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTimeTracker.Location = new System.Drawing.Point(12, 9);
            this.lblTimeTracker.Name = "lblTimeTracker";
            this.lblTimeTracker.Size = new System.Drawing.Size(126, 25);
            this.lblTimeTracker.TabIndex = 34;
            this.lblTimeTracker.Text = "Time Tracker";
            // 
            // linkLabelGitHub
            // 
            this.linkLabelGitHub.AutoSize = true;
            this.linkLabelGitHub.Location = new System.Drawing.Point(782, 544);
            this.linkLabelGitHub.Name = "linkLabelGitHub";
            this.linkLabelGitHub.Size = new System.Drawing.Size(252, 21);
            this.linkLabelGitHub.TabIndex = 35;
            this.linkLabelGitHub.TabStop = true;
            this.linkLabelGitHub.Text = "https://github.com/JoyfulReaper";
            this.linkLabelGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGitHub_LinkClicked);
            // 
            // checkBoxEntries
            // 
            this.checkBoxEntries.AutoSize = true;
            this.checkBoxEntries.Location = new System.Drawing.Point(451, 58);
            this.checkBoxEntries.Name = "checkBoxEntries";
            this.checkBoxEntries.Size = new System.Drawing.Size(145, 25);
            this.checkBoxEntries.TabIndex = 36;
            this.checkBoxEntries.Text = "Show All Entries";
            this.checkBoxEntries.UseVisualStyleBackColor = true;
            this.checkBoxEntries.CheckedChanged += new System.EventHandler(this.checkBoxEntries_CheckedChanged);
            // 
            // lblProjectTotalValue
            // 
            this.lblProjectTotalValue.AutoSize = true;
            this.lblProjectTotalValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProjectTotalValue.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblProjectTotalValue.Location = new System.Drawing.Point(749, 84);
            this.lblProjectTotalValue.Name = "lblProjectTotalValue";
            this.lblProjectTotalValue.Size = new System.Drawing.Size(101, 20);
            this.lblProjectTotalValue.TabIndex = 38;
            this.lblProjectTotalValue.Text = "{project total}";
            // 
            // lblProjectTotal
            // 
            this.lblProjectTotal.AutoSize = true;
            this.lblProjectTotal.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblProjectTotal.Location = new System.Drawing.Point(637, 82);
            this.lblProjectTotal.Name = "lblProjectTotal";
            this.lblProjectTotal.Size = new System.Drawing.Size(106, 21);
            this.lblProjectTotal.TabIndex = 37;
            this.lblProjectTotal.Text = "Project Time:";
            // 
            // lblCategoryTimeValue
            // 
            this.lblCategoryTimeValue.AutoSize = true;
            this.lblCategoryTimeValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCategoryTimeValue.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCategoryTimeValue.Location = new System.Drawing.Point(760, 144);
            this.lblCategoryTimeValue.Name = "lblCategoryTimeValue";
            this.lblCategoryTimeValue.Size = new System.Drawing.Size(112, 20);
            this.lblCategoryTimeValue.TabIndex = 40;
            this.lblCategoryTimeValue.Text = "{category total}";
            // 
            // lblCategoryTime
            // 
            this.lblCategoryTime.AutoSize = true;
            this.lblCategoryTime.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCategoryTime.Location = new System.Drawing.Point(637, 143);
            this.lblCategoryTime.Name = "lblCategoryTime";
            this.lblCategoryTime.Size = new System.Drawing.Size(122, 21);
            this.lblCategoryTime.TabIndex = 39;
            this.lblCategoryTime.Text = "Category Time:";
            // 
            // lblSubcategoryTotalValue
            // 
            this.lblSubcategoryTotalValue.AutoSize = true;
            this.lblSubcategoryTotalValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubcategoryTotalValue.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblSubcategoryTotalValue.Location = new System.Drawing.Point(791, 200);
            this.lblSubcategoryTotalValue.Name = "lblSubcategoryTotalValue";
            this.lblSubcategoryTotalValue.Size = new System.Drawing.Size(135, 20);
            this.lblSubcategoryTotalValue.TabIndex = 42;
            this.lblSubcategoryTotalValue.Text = "{subcategory total}";
            // 
            // lblsubcategoryTotal
            // 
            this.lblsubcategoryTotal.AutoSize = true;
            this.lblsubcategoryTotal.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblsubcategoryTotal.Location = new System.Drawing.Point(637, 199);
            this.lblsubcategoryTotal.Name = "lblsubcategoryTotal";
            this.lblsubcategoryTotal.Size = new System.Drawing.Size(148, 21);
            this.lblsubcategoryTotal.TabIndex = 41;
            this.lblsubcategoryTotal.Text = "Subcategory Time:";
            // 
            // lblAllTimeValue
            // 
            this.lblAllTimeValue.AutoSize = true;
            this.lblAllTimeValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAllTimeValue.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblAllTimeValue.Location = new System.Drawing.Point(755, 288);
            this.lblAllTimeValue.Name = "lblAllTimeValue";
            this.lblAllTimeValue.Size = new System.Drawing.Size(84, 20);
            this.lblAllTimeValue.TabIndex = 44;
            this.lblAllTimeValue.Text = "{time total}";
            // 
            // lblAllTime
            // 
            this.lblAllTime.AutoSize = true;
            this.lblAllTime.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblAllTime.Location = new System.Drawing.Point(625, 287);
            this.lblAllTime.Name = "lblAllTime";
            this.lblAllTime.Size = new System.Drawing.Size(134, 21);
            this.lblAllTime.TabIndex = 43;
            this.lblAllTime.Text = "All Tracked Time:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1046, 574);
            this.Controls.Add(this.lblAllTimeValue);
            this.Controls.Add(this.lblAllTime);
            this.Controls.Add(this.lblSubcategoryTotalValue);
            this.Controls.Add(this.lblsubcategoryTotal);
            this.Controls.Add(this.lblCategoryTimeValue);
            this.Controls.Add(this.lblCategoryTime);
            this.Controls.Add(this.lblProjectTotalValue);
            this.Controls.Add(this.lblProjectTotal);
            this.Controls.Add(this.checkBoxEntries);
            this.Controls.Add(this.linkLabelGitHub);
            this.Controls.Add(this.lblTimeTracker);
            this.Controls.Add(this.groupBoxSelectProj);
            this.Controls.Add(this.btnEditProjects);
            this.Controls.Add(this.btnEditCat);
            this.Controls.Add(this.btnAddEntry);
            this.Controls.Add(this.lblEntries);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblTimeSpentValue);
            this.Controls.Add(this.lblEntryDateValue);
            this.Controls.Add(this.lblsubcategoryValue);
            this.Controls.Add(this.lblCategoryValue);
            this.Controls.Add(this.lblProjectValue);
            this.Controls.Add(this.textBoxNotes);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.lblTimeSpent);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblSubCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.listBoxEntries);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Name = "frmMain";
            this.Text = "Time Tracker";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBoxSelectProj.ResumeLayout(false);
            this.groupBoxSelectProj.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxEntries;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblSubCategory;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTimeSpent;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblTimeSpentValue;
        private System.Windows.Forms.Label lblEntryDateValue;
        private System.Windows.Forms.Label lblsubcategoryValue;
        private System.Windows.Forms.Label lblCategoryValue;
        private System.Windows.Forms.Label lblProjectValue;
        private System.Windows.Forms.Button btnAddEntry;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblEntries;
        private System.Windows.Forms.Button btnEditCat;
        private System.Windows.Forms.Button btnEditProjects;
        private System.Windows.Forms.GroupBox groupBoxSelectProj;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.CheckBox checkBoxAllProjects;
        private System.Windows.Forms.ListBox listBoxProject;
        private System.Windows.Forms.Label lblSubCat;
        private System.Windows.Forms.Label lblProj;
        private System.Windows.Forms.ComboBox comboBoxSubcategory;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label lblTimeTracker;
        private System.Windows.Forms.LinkLabel linkLabelGitHub;
        private System.Windows.Forms.CheckBox checkBoxEntries;
        private System.Windows.Forms.Label lblProjectTotalValue;
        private System.Windows.Forms.Label lblProjectTotal;
        private System.Windows.Forms.Label lblCategoryTimeValue;
        private System.Windows.Forms.Label lblCategoryTime;
        private System.Windows.Forms.Label lblSubcategoryTotalValue;
        private System.Windows.Forms.Label lblsubcategoryTotal;
        private System.Windows.Forms.Label lblAllTimeValue;
        private System.Windows.Forms.Label lblAllTime;
    }
}