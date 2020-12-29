
namespace TimeTrackerUI
{
    partial class frmEditProject
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
            this.lblProjManagement = new System.Windows.Forms.Label();
            this.btnDeleteProj = new System.Windows.Forms.Button();
            this.lblProject = new System.Windows.Forms.Label();
            this.listBoxProject = new System.Windows.Forms.ListBox();
            this.btnAddProj = new System.Windows.Forms.Button();
            this.textBoxProject = new System.Windows.Forms.TextBox();
            this.lblNewProject = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblSubcategory = new System.Windows.Forms.Label();
            this.comboBoxSubcategory = new System.Windows.Forms.ComboBox();
            this.groupBoxAddProject = new System.Windows.Forms.GroupBox();
            this.groupBoxSelectedProject = new System.Windows.Forms.GroupBox();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.lblProjectSubCategory = new System.Windows.Forms.Label();
            this.lblProjectCategory = new System.Windows.Forms.Label();
            this.lblProjectNameValue = new System.Windows.Forms.Label();
            this.lblSubcategoryValue = new System.Windows.Forms.Label();
            this.lblCategoryValue = new System.Windows.Forms.Label();
            this.groupBoxAddProject.SuspendLayout();
            this.groupBoxSelectedProject.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProjManagement
            // 
            this.lblProjManagement.AutoSize = true;
            this.lblProjManagement.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProjManagement.Location = new System.Drawing.Point(12, 9);
            this.lblProjManagement.Name = "lblProjManagement";
            this.lblProjManagement.Size = new System.Drawing.Size(198, 25);
            this.lblProjManagement.TabIndex = 15;
            this.lblProjManagement.Text = "Project Management";
            // 
            // btnDeleteProj
            // 
            this.btnDeleteProj.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteProj.Location = new System.Drawing.Point(30, 346);
            this.btnDeleteProj.Name = "btnDeleteProj";
            this.btnDeleteProj.Size = new System.Drawing.Size(181, 44);
            this.btnDeleteProj.TabIndex = 18;
            this.btnDeleteProj.Text = "Delete Selected Project";
            this.btnDeleteProj.UseVisualStyleBackColor = true;
            this.btnDeleteProj.Click += new System.EventHandler(this.btnDeleteProj_Click);
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(12, 39);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(66, 21);
            this.lblProject.TabIndex = 17;
            this.lblProject.Text = "Project:";
            // 
            // listBoxProject
            // 
            this.listBoxProject.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBoxProject.FormattingEnabled = true;
            this.listBoxProject.ItemHeight = 17;
            this.listBoxProject.Location = new System.Drawing.Point(12, 63);
            this.listBoxProject.Name = "listBoxProject";
            this.listBoxProject.Size = new System.Drawing.Size(217, 276);
            this.listBoxProject.TabIndex = 16;
            this.listBoxProject.SelectedIndexChanged += new System.EventHandler(this.listBoxProject_SelectedIndexChanged);
            this.listBoxProject.DoubleClick += new System.EventHandler(this.listBoxProject_DoubleClick);
            // 
            // btnAddProj
            // 
            this.btnAddProj.Location = new System.Drawing.Point(80, 209);
            this.btnAddProj.Name = "btnAddProj";
            this.btnAddProj.Size = new System.Drawing.Size(164, 37);
            this.btnAddProj.TabIndex = 21;
            this.btnAddProj.Text = "Add Project";
            this.btnAddProj.UseVisualStyleBackColor = true;
            this.btnAddProj.Click += new System.EventHandler(this.btnAddProj_Click);
            // 
            // textBoxProject
            // 
            this.textBoxProject.Location = new System.Drawing.Point(21, 58);
            this.textBoxProject.Name = "textBoxProject";
            this.textBoxProject.Size = new System.Drawing.Size(293, 29);
            this.textBoxProject.TabIndex = 19;
            // 
            // lblNewProject
            // 
            this.lblNewProject.AutoSize = true;
            this.lblNewProject.Location = new System.Drawing.Point(21, 31);
            this.lblNewProject.Name = "lblNewProject";
            this.lblNewProject.Size = new System.Drawing.Size(101, 21);
            this.lblNewProject.TabIndex = 20;
            this.lblNewProject.Text = "Add Project:";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(21, 120);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(293, 25);
            this.comboBoxCategory.TabIndex = 22;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(21, 93);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(82, 21);
            this.lblCategory.TabIndex = 24;
            this.lblCategory.Text = "Category:";
            // 
            // lblSubcategory
            // 
            this.lblSubcategory.AutoSize = true;
            this.lblSubcategory.Location = new System.Drawing.Point(21, 151);
            this.lblSubcategory.Name = "lblSubcategory";
            this.lblSubcategory.Size = new System.Drawing.Size(108, 21);
            this.lblSubcategory.TabIndex = 26;
            this.lblSubcategory.Text = "Subcategory:";
            // 
            // comboBoxSubcategory
            // 
            this.comboBoxSubcategory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSubcategory.FormattingEnabled = true;
            this.comboBoxSubcategory.Location = new System.Drawing.Point(21, 178);
            this.comboBoxSubcategory.Name = "comboBoxSubcategory";
            this.comboBoxSubcategory.Size = new System.Drawing.Size(293, 25);
            this.comboBoxSubcategory.TabIndex = 25;
            // 
            // groupBoxAddProject
            // 
            this.groupBoxAddProject.Controls.Add(this.lblNewProject);
            this.groupBoxAddProject.Controls.Add(this.lblSubcategory);
            this.groupBoxAddProject.Controls.Add(this.textBoxProject);
            this.groupBoxAddProject.Controls.Add(this.comboBoxSubcategory);
            this.groupBoxAddProject.Controls.Add(this.btnAddProj);
            this.groupBoxAddProject.Controls.Add(this.lblCategory);
            this.groupBoxAddProject.Controls.Add(this.comboBoxCategory);
            this.groupBoxAddProject.Location = new System.Drawing.Point(257, 63);
            this.groupBoxAddProject.Name = "groupBoxAddProject";
            this.groupBoxAddProject.Size = new System.Drawing.Size(334, 276);
            this.groupBoxAddProject.TabIndex = 27;
            this.groupBoxAddProject.TabStop = false;
            this.groupBoxAddProject.Text = "New Project";
            // 
            // groupBoxSelectedProject
            // 
            this.groupBoxSelectedProject.Controls.Add(this.lblProjectNameValue);
            this.groupBoxSelectedProject.Controls.Add(this.lblSubcategoryValue);
            this.groupBoxSelectedProject.Controls.Add(this.lblCategoryValue);
            this.groupBoxSelectedProject.Controls.Add(this.lblProjectName);
            this.groupBoxSelectedProject.Controls.Add(this.lblProjectSubCategory);
            this.groupBoxSelectedProject.Controls.Add(this.lblProjectCategory);
            this.groupBoxSelectedProject.Location = new System.Drawing.Point(612, 63);
            this.groupBoxSelectedProject.Name = "groupBoxSelectedProject";
            this.groupBoxSelectedProject.Size = new System.Drawing.Size(339, 276);
            this.groupBoxSelectedProject.TabIndex = 28;
            this.groupBoxSelectedProject.TabStop = false;
            this.groupBoxSelectedProject.Text = "Selected Project";
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Location = new System.Drawing.Point(6, 31);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(66, 21);
            this.lblProjectName.TabIndex = 27;
            this.lblProjectName.Text = "Project:";
            // 
            // lblProjectSubCategory
            // 
            this.lblProjectSubCategory.AutoSize = true;
            this.lblProjectSubCategory.Location = new System.Drawing.Point(6, 93);
            this.lblProjectSubCategory.Name = "lblProjectSubCategory";
            this.lblProjectSubCategory.Size = new System.Drawing.Size(108, 21);
            this.lblProjectSubCategory.TabIndex = 29;
            this.lblProjectSubCategory.Text = "Subcategory:";
            // 
            // lblProjectCategory
            // 
            this.lblProjectCategory.AutoSize = true;
            this.lblProjectCategory.Location = new System.Drawing.Point(6, 61);
            this.lblProjectCategory.Name = "lblProjectCategory";
            this.lblProjectCategory.Size = new System.Drawing.Size(82, 21);
            this.lblProjectCategory.TabIndex = 28;
            this.lblProjectCategory.Text = "Category:";
            // 
            // lblProjectNameValue
            // 
            this.lblProjectNameValue.AutoSize = true;
            this.lblProjectNameValue.Location = new System.Drawing.Point(123, 31);
            this.lblProjectNameValue.Name = "lblProjectNameValue";
            this.lblProjectNameValue.Size = new System.Drawing.Size(60, 21);
            this.lblProjectNameValue.TabIndex = 30;
            this.lblProjectNameValue.Text = "{name}";
            // 
            // lblSubcategoryValue
            // 
            this.lblSubcategoryValue.AutoSize = true;
            this.lblSubcategoryValue.Location = new System.Drawing.Point(123, 93);
            this.lblSubcategoryValue.Name = "lblSubcategoryValue";
            this.lblSubcategoryValue.Size = new System.Drawing.Size(112, 21);
            this.lblSubcategoryValue.TabIndex = 32;
            this.lblSubcategoryValue.Text = "{subcategory}";
            // 
            // lblCategoryValue
            // 
            this.lblCategoryValue.AutoSize = true;
            this.lblCategoryValue.Location = new System.Drawing.Point(123, 61);
            this.lblCategoryValue.Name = "lblCategoryValue";
            this.lblCategoryValue.Size = new System.Drawing.Size(86, 21);
            this.lblCategoryValue.TabIndex = 31;
            this.lblCategoryValue.Text = "{category}";
            // 
            // frmEditProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(966, 414);
            this.Controls.Add(this.groupBoxSelectedProject);
            this.Controls.Add(this.groupBoxAddProject);
            this.Controls.Add(this.btnDeleteProj);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.listBoxProject);
            this.Controls.Add(this.lblProjManagement);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Name = "frmEditProject";
            this.Text = "Edit Projects";
            this.Load += new System.EventHandler(this.frmEditProject_Load);
            this.groupBoxAddProject.ResumeLayout(false);
            this.groupBoxAddProject.PerformLayout();
            this.groupBoxSelectedProject.ResumeLayout(false);
            this.groupBoxSelectedProject.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProjManagement;
        private System.Windows.Forms.Button btnDeleteProj;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.ListBox listBoxProject;
        private System.Windows.Forms.Button btnAddProj;
        private System.Windows.Forms.TextBox textBoxProject;
        private System.Windows.Forms.Label lblNewProject;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblSubcategory;
        private System.Windows.Forms.ComboBox comboBoxSubcategory;
        private System.Windows.Forms.GroupBox groupBoxAddProject;
        private System.Windows.Forms.GroupBox groupBoxSelectedProject;
        private System.Windows.Forms.Label lblProjectNameValue;
        private System.Windows.Forms.Label lblSubcategoryValue;
        private System.Windows.Forms.Label lblCategoryValue;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Label lblProjectSubCategory;
        private System.Windows.Forms.Label lblProjectCategory;
    }
}