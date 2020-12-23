
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
            // 
            // btnAddProj
            // 
            this.btnAddProj.Location = new System.Drawing.Point(319, 241);
            this.btnAddProj.Name = "btnAddProj";
            this.btnAddProj.Size = new System.Drawing.Size(164, 37);
            this.btnAddProj.TabIndex = 21;
            this.btnAddProj.Text = "Add Project";
            this.btnAddProj.UseVisualStyleBackColor = true;
            // 
            // textBoxProject
            // 
            this.textBoxProject.Location = new System.Drawing.Point(260, 90);
            this.textBoxProject.Name = "textBoxProject";
            this.textBoxProject.Size = new System.Drawing.Size(293, 29);
            this.textBoxProject.TabIndex = 19;
            // 
            // lblNewProject
            // 
            this.lblNewProject.AutoSize = true;
            this.lblNewProject.Location = new System.Drawing.Point(260, 63);
            this.lblNewProject.Name = "lblNewProject";
            this.lblNewProject.Size = new System.Drawing.Size(101, 21);
            this.lblNewProject.TabIndex = 20;
            this.lblNewProject.Text = "Add Project:";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(260, 152);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(293, 25);
            this.comboBoxCategory.TabIndex = 22;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(260, 125);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(82, 21);
            this.lblCategory.TabIndex = 24;
            this.lblCategory.Text = "Category:";
            // 
            // lblSubcategory
            // 
            this.lblSubcategory.AutoSize = true;
            this.lblSubcategory.Location = new System.Drawing.Point(260, 183);
            this.lblSubcategory.Name = "lblSubcategory";
            this.lblSubcategory.Size = new System.Drawing.Size(108, 21);
            this.lblSubcategory.TabIndex = 26;
            this.lblSubcategory.Text = "Subcategory:";
            // 
            // comboBoxSubcategory
            // 
            this.comboBoxSubcategory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSubcategory.FormattingEnabled = true;
            this.comboBoxSubcategory.Location = new System.Drawing.Point(260, 210);
            this.comboBoxSubcategory.Name = "comboBoxSubcategory";
            this.comboBoxSubcategory.Size = new System.Drawing.Size(293, 25);
            this.comboBoxSubcategory.TabIndex = 25;
            // 
            // frmEditProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(619, 401);
            this.Controls.Add(this.lblSubcategory);
            this.Controls.Add(this.comboBoxSubcategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.btnAddProj);
            this.Controls.Add(this.textBoxProject);
            this.Controls.Add(this.lblNewProject);
            this.Controls.Add(this.btnDeleteProj);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.listBoxProject);
            this.Controls.Add(this.lblProjManagement);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Name = "frmEditProject";
            this.Text = "Edit Projects";
            this.Load += new System.EventHandler(this.frmEditProject_Load);
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
    }
}