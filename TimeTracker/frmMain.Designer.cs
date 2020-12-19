
namespace TimeTracker
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
            this.listBox1 = new System.Windows.Forms.ListBox();
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
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(50, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(246, 424);
            this.listBox1.TabIndex = 0;
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(322, 12);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(66, 21);
            this.lblProject.TabIndex = 1;
            this.lblProject.Text = "Project:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(322, 43);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(82, 21);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Category:";
            // 
            // lblSubCategory
            // 
            this.lblSubCategory.AutoSize = true;
            this.lblSubCategory.Location = new System.Drawing.Point(322, 74);
            this.lblSubCategory.Name = "lblSubCategory";
            this.lblSubCategory.Size = new System.Drawing.Size(108, 21);
            this.lblSubCategory.TabIndex = 1;
            this.lblSubCategory.Text = "Subcategory:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(322, 106);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(90, 21);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Entry Date:";
            // 
            // lblTimeSpent
            // 
            this.lblTimeSpent.AutoSize = true;
            this.lblTimeSpent.Location = new System.Drawing.Point(322, 142);
            this.lblTimeSpent.Name = "lblTimeSpent";
            this.lblTimeSpent.Size = new System.Drawing.Size(97, 21);
            this.lblTimeSpent.TabIndex = 1;
            this.lblTimeSpent.Text = "Time Spent:";
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(322, 230);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(245, 206);
            this.textBoxNotes.TabIndex = 2;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(322, 206);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(58, 21);
            this.lblNotes.TabIndex = 1;
            this.lblNotes.Text = "Notes:";
            // 
            // lblTimeSpentValue
            // 
            this.lblTimeSpentValue.AutoSize = true;
            this.lblTimeSpentValue.Location = new System.Drawing.Point(432, 142);
            this.lblTimeSpentValue.Name = "lblTimeSpentValue";
            this.lblTimeSpentValue.Size = new System.Drawing.Size(98, 21);
            this.lblTimeSpentValue.TabIndex = 3;
            this.lblTimeSpentValue.Text = "{time spent}";
            // 
            // lblEntryDateValue
            // 
            this.lblEntryDateValue.AutoSize = true;
            this.lblEntryDateValue.Location = new System.Drawing.Point(432, 106);
            this.lblEntryDateValue.Name = "lblEntryDateValue";
            this.lblEntryDateValue.Size = new System.Drawing.Size(96, 21);
            this.lblEntryDateValue.TabIndex = 4;
            this.lblEntryDateValue.Text = "{entry date}";
            // 
            // lblsubcategoryValue
            // 
            this.lblsubcategoryValue.AutoSize = true;
            this.lblsubcategoryValue.Location = new System.Drawing.Point(432, 74);
            this.lblsubcategoryValue.Name = "lblsubcategoryValue";
            this.lblsubcategoryValue.Size = new System.Drawing.Size(112, 21);
            this.lblsubcategoryValue.TabIndex = 5;
            this.lblsubcategoryValue.Text = "{subcategory}";
            // 
            // lblCategoryValue
            // 
            this.lblCategoryValue.AutoSize = true;
            this.lblCategoryValue.Location = new System.Drawing.Point(432, 43);
            this.lblCategoryValue.Name = "lblCategoryValue";
            this.lblCategoryValue.Size = new System.Drawing.Size(86, 21);
            this.lblCategoryValue.TabIndex = 6;
            this.lblCategoryValue.Text = "{category}";
            // 
            // lblProjectValue
            // 
            this.lblProjectValue.AutoSize = true;
            this.lblProjectValue.Location = new System.Drawing.Point(432, 12);
            this.lblProjectValue.Name = "lblProjectValue";
            this.lblProjectValue.Size = new System.Drawing.Size(73, 21);
            this.lblProjectValue.TabIndex = 7;
            this.lblProjectValue.Text = "{project}";
            // 
            // btnAddEntry
            // 
            this.btnAddEntry.Location = new System.Drawing.Point(421, 450);
            this.btnAddEntry.Name = "btnAddEntry";
            this.btnAddEntry.Size = new System.Drawing.Size(146, 37);
            this.btnAddEntry.TabIndex = 8;
            this.btnAddEntry.Text = "New Entry";
            this.btnAddEntry.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(50, 450);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(146, 37);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(616, 499);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddEntry);
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
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Name = "frmMain";
            this.Text = "Time Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
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
    }
}