
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
            this.buttonAddSubCat = new System.Windows.Forms.Button();
            this.btnDeleteCat = new System.Windows.Forms.Button();
            this.btnDeleteSubCat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxCategory
            // 
            this.listBoxCategory.FormattingEnabled = true;
            this.listBoxCategory.ItemHeight = 21;
            this.listBoxCategory.Location = new System.Drawing.Point(12, 54);
            this.listBoxCategory.Name = "listBoxCategory";
            this.listBoxCategory.Size = new System.Drawing.Size(181, 277);
            this.listBoxCategory.TabIndex = 0;
            // 
            // listBoxSubcategory
            // 
            this.listBoxSubcategory.FormattingEnabled = true;
            this.listBoxSubcategory.ItemHeight = 21;
            this.listBoxSubcategory.Location = new System.Drawing.Point(199, 54);
            this.listBoxSubcategory.Name = "listBoxSubcategory";
            this.listBoxSubcategory.Size = new System.Drawing.Size(181, 277);
            this.listBoxSubcategory.TabIndex = 1;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(12, 30);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(82, 21);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category:";
            // 
            // lblSubCategory
            // 
            this.lblSubCategory.AutoSize = true;
            this.lblSubCategory.Location = new System.Drawing.Point(199, 30);
            this.lblSubCategory.Name = "lblSubCategory";
            this.lblSubCategory.Size = new System.Drawing.Size(108, 21);
            this.lblSubCategory.TabIndex = 3;
            this.lblSubCategory.Text = "Subcategory:";
            // 
            // lblNewCategory
            // 
            this.lblNewCategory.AutoSize = true;
            this.lblNewCategory.Location = new System.Drawing.Point(427, 54);
            this.lblNewCategory.Name = "lblNewCategory";
            this.lblNewCategory.Size = new System.Drawing.Size(117, 21);
            this.lblNewCategory.TabIndex = 4;
            this.lblNewCategory.Text = "Add Category:";
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Location = new System.Drawing.Point(427, 78);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(293, 29);
            this.textBoxCategory.TabIndex = 0;
            // 
            // textBoxSubcategory
            // 
            this.textBoxSubcategory.Location = new System.Drawing.Point(427, 186);
            this.textBoxSubcategory.Name = "textBoxSubcategory";
            this.textBoxSubcategory.Size = new System.Drawing.Size(293, 29);
            this.textBoxSubcategory.TabIndex = 1;
            // 
            // lblAddSubcategory
            // 
            this.lblAddSubcategory.AutoSize = true;
            this.lblAddSubcategory.Location = new System.Drawing.Point(427, 162);
            this.lblAddSubcategory.Name = "lblAddSubcategory";
            this.lblAddSubcategory.Size = new System.Drawing.Size(301, 21);
            this.lblAddSubcategory.TabIndex = 6;
            this.lblAddSubcategory.Text = "Add Subcategory to selected Category:";
            // 
            // btnAddCat
            // 
            this.btnAddCat.Location = new System.Drawing.Point(427, 113);
            this.btnAddCat.Name = "btnAddCat";
            this.btnAddCat.Size = new System.Drawing.Size(164, 37);
            this.btnAddCat.TabIndex = 10;
            this.btnAddCat.Text = "Add Category";
            this.btnAddCat.UseVisualStyleBackColor = true;
            this.btnAddCat.Click += new System.EventHandler(this.btnAddCat_Click);
            // 
            // buttonAddSubCat
            // 
            this.buttonAddSubCat.Location = new System.Drawing.Point(427, 221);
            this.buttonAddSubCat.Name = "buttonAddSubCat";
            this.buttonAddSubCat.Size = new System.Drawing.Size(164, 37);
            this.buttonAddSubCat.TabIndex = 11;
            this.buttonAddSubCat.Text = "Add Subcategory";
            this.buttonAddSubCat.UseVisualStyleBackColor = true;
            this.buttonAddSubCat.Click += new System.EventHandler(this.buttonAddSubCat_Click);
            // 
            // btnDeleteCat
            // 
            this.btnDeleteCat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteCat.Location = new System.Drawing.Point(386, 287);
            this.btnDeleteCat.Name = "btnDeleteCat";
            this.btnDeleteCat.Size = new System.Drawing.Size(164, 44);
            this.btnDeleteCat.TabIndex = 12;
            this.btnDeleteCat.Text = "Delete Selected Category";
            this.btnDeleteCat.UseVisualStyleBackColor = true;
            this.btnDeleteCat.Click += new System.EventHandler(this.btnDeleteCat_Click);
            // 
            // btnDeleteSubCat
            // 
            this.btnDeleteSubCat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteSubCat.Location = new System.Drawing.Point(564, 287);
            this.btnDeleteSubCat.Name = "btnDeleteSubCat";
            this.btnDeleteSubCat.Size = new System.Drawing.Size(164, 44);
            this.btnDeleteSubCat.TabIndex = 13;
            this.btnDeleteSubCat.Text = "Delete Selected Subcategory";
            this.btnDeleteSubCat.UseVisualStyleBackColor = true;
            // 
            // frmEditCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(756, 350);
            this.Controls.Add(this.btnDeleteSubCat);
            this.Controls.Add(this.btnDeleteCat);
            this.Controls.Add(this.buttonAddSubCat);
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
        private System.Windows.Forms.Button buttonAddSubCat;
        private System.Windows.Forms.Button btnDeleteCat;
        private System.Windows.Forms.Button btnDeleteSubCat;
    }
}