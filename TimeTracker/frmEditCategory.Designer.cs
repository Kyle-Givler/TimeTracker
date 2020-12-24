
namespace TimeTrackerUI
{
    partial class frmEditCategory
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
            this.listBoxCategory = new System.Windows.Forms.ListBox();
            this.listBoxSubcategory = new System.Windows.Forms.ListBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblSubCategory = new System.Windows.Forms.Label();
            this.lblNewCategory = new System.Windows.Forms.Label();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.textBoxSubcategory = new System.Windows.Forms.TextBox();
            this.lblAddSubcategory = new System.Windows.Forms.Label();
            this.btnAddCat = new System.Windows.Forms.Button();
            this.btnAddSubCat = new System.Windows.Forms.Button();
            this.btnDeleteCat = new System.Windows.Forms.Button();
            this.btnDeleteSubCat = new System.Windows.Forms.Button();
            this.lblCatManagement = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxCategory
            // 
            this.listBoxCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBoxCategory.FormattingEnabled = true;
            this.listBoxCategory.ItemHeight = 17;
            this.listBoxCategory.Location = new System.Drawing.Point(12, 65);
            this.listBoxCategory.Name = "listBoxCategory";
            this.listBoxCategory.Size = new System.Drawing.Size(217, 276);
            this.listBoxCategory.TabIndex = 0;
            this.listBoxCategory.SelectedIndexChanged += new System.EventHandler(this.listBoxCategory_SelectedIndexChanged);
            this.listBoxCategory.DoubleClick += new System.EventHandler(this.listBoxCategory_DoubleClick);
            // 
            // listBoxSubcategory
            // 
            this.listBoxSubcategory.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBoxSubcategory.FormattingEnabled = true;
            this.listBoxSubcategory.ItemHeight = 17;
            this.listBoxSubcategory.Location = new System.Drawing.Point(237, 65);
            this.listBoxSubcategory.Name = "listBoxSubcategory";
            this.listBoxSubcategory.Size = new System.Drawing.Size(251, 276);
            this.listBoxSubcategory.TabIndex = 1;
            this.listBoxSubcategory.DoubleClick += new System.EventHandler(this.listBoxSubcategory_DoubleClick);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(12, 41);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(82, 21);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category:";
            // 
            // lblSubCategory
            // 
            this.lblSubCategory.AutoSize = true;
            this.lblSubCategory.Location = new System.Drawing.Point(237, 41);
            this.lblSubCategory.Name = "lblSubCategory";
            this.lblSubCategory.Size = new System.Drawing.Size(108, 21);
            this.lblSubCategory.TabIndex = 3;
            this.lblSubCategory.Text = "Subcategory:";
            // 
            // lblNewCategory
            // 
            this.lblNewCategory.AutoSize = true;
            this.lblNewCategory.Location = new System.Drawing.Point(506, 41);
            this.lblNewCategory.Name = "lblNewCategory";
            this.lblNewCategory.Size = new System.Drawing.Size(117, 21);
            this.lblNewCategory.TabIndex = 4;
            this.lblNewCategory.Text = "Add Category:";
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Location = new System.Drawing.Point(506, 65);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(293, 29);
            this.textBoxCategory.TabIndex = 0;
            // 
            // textBoxSubcategory
            // 
            this.textBoxSubcategory.Location = new System.Drawing.Point(506, 173);
            this.textBoxSubcategory.Name = "textBoxSubcategory";
            this.textBoxSubcategory.Size = new System.Drawing.Size(293, 29);
            this.textBoxSubcategory.TabIndex = 1;
            // 
            // lblAddSubcategory
            // 
            this.lblAddSubcategory.AutoSize = true;
            this.lblAddSubcategory.Location = new System.Drawing.Point(506, 149);
            this.lblAddSubcategory.Name = "lblAddSubcategory";
            this.lblAddSubcategory.Size = new System.Drawing.Size(301, 21);
            this.lblAddSubcategory.TabIndex = 6;
            this.lblAddSubcategory.Text = "Add Subcategory to selected Category:";
            // 
            // btnAddCat
            // 
            this.btnAddCat.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddCat.Location = new System.Drawing.Point(506, 100);
            this.btnAddCat.Name = "btnAddCat";
            this.btnAddCat.Size = new System.Drawing.Size(164, 37);
            this.btnAddCat.TabIndex = 10;
            this.btnAddCat.Text = "Add Category";
            this.btnAddCat.UseVisualStyleBackColor = true;
            this.btnAddCat.Click += new System.EventHandler(this.btnAddCat_Click);
            // 
            // btnAddSubCat
            // 
            this.btnAddSubCat.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddSubCat.Location = new System.Drawing.Point(506, 208);
            this.btnAddSubCat.Name = "btnAddSubCat";
            this.btnAddSubCat.Size = new System.Drawing.Size(164, 37);
            this.btnAddSubCat.TabIndex = 11;
            this.btnAddSubCat.Text = "Add Subcategory";
            this.btnAddSubCat.UseVisualStyleBackColor = true;
            this.btnAddSubCat.Click += new System.EventHandler(this.buttonAddSubCat_Click);
            // 
            // btnDeleteCat
            // 
            this.btnDeleteCat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteCat.Location = new System.Drawing.Point(30, 348);
            this.btnDeleteCat.Name = "btnDeleteCat";
            this.btnDeleteCat.Size = new System.Drawing.Size(181, 44);
            this.btnDeleteCat.TabIndex = 12;
            this.btnDeleteCat.Text = "Delete Selected Category";
            this.btnDeleteCat.UseVisualStyleBackColor = true;
            this.btnDeleteCat.Click += new System.EventHandler(this.btnDeleteCat_Click);
            // 
            // btnDeleteSubCat
            // 
            this.btnDeleteSubCat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteSubCat.Location = new System.Drawing.Point(272, 347);
            this.btnDeleteSubCat.Name = "btnDeleteSubCat";
            this.btnDeleteSubCat.Size = new System.Drawing.Size(181, 44);
            this.btnDeleteSubCat.TabIndex = 13;
            this.btnDeleteSubCat.Text = "Delete Selected Subcategory";
            this.btnDeleteSubCat.UseVisualStyleBackColor = true;
            this.btnDeleteSubCat.Click += new System.EventHandler(this.btnDeleteSubCat_Click);
            // 
            // lblCatManagement
            // 
            this.lblCatManagement.AutoSize = true;
            this.lblCatManagement.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCatManagement.Location = new System.Drawing.Point(12, 9);
            this.lblCatManagement.Name = "lblCatManagement";
            this.lblCatManagement.Size = new System.Drawing.Size(217, 25);
            this.lblCatManagement.TabIndex = 14;
            this.lblCatManagement.Text = "Category Management";
            // 
            // frmEditCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(828, 405);
            this.Controls.Add(this.lblCatManagement);
            this.Controls.Add(this.btnDeleteSubCat);
            this.Controls.Add(this.btnDeleteCat);
            this.Controls.Add(this.btnAddSubCat);
            this.Controls.Add(this.btnAddCat);
            this.Controls.Add(this.textBoxSubcategory);
            this.Controls.Add(this.lblAddSubcategory);
            this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.lblNewCategory);
            this.Controls.Add(this.lblSubCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.listBoxSubcategory);
            this.Controls.Add(this.listBoxCategory);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Name = "frmEditCategory";
            this.Text = "Edit Categories";
            this.Load += new System.EventHandler(this.frmEditCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCategory;
        private System.Windows.Forms.ListBox listBoxSubcategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblSubCategory;
        private System.Windows.Forms.Label lblNewCategory;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.TextBox textBoxSubcategory;
        private System.Windows.Forms.Label lblAddSubcategory;
        private System.Windows.Forms.Button btnAddCat;
        private System.Windows.Forms.Button btnAddSubCat;
        private System.Windows.Forms.Button btnDeleteCat;
        private System.Windows.Forms.Button btnDeleteSubCat;
        private System.Windows.Forms.Label lblCatManagement;
    }
}