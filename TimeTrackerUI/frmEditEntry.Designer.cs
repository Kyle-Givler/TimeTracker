
namespace TimeTrackerUI
{
    partial class frmEditEntry
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
            this.groupBoxEntry = new System.Windows.Forms.GroupBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblHoursSpent = new System.Windows.Forms.Label();
            this.textBoxHoursSpent = new System.Windows.Forms.TextBox();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.lblNotes = new System.Windows.Forms.Label();
            this.btnUpdateEntry = new System.Windows.Forms.Button();
            this.groupBoxEntry.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxEntry
            // 
            this.groupBoxEntry.Controls.Add(this.lblDate);
            this.groupBoxEntry.Controls.Add(this.lblHoursSpent);
            this.groupBoxEntry.Controls.Add(this.textBoxHoursSpent);
            this.groupBoxEntry.Controls.Add(this.textBoxNotes);
            this.groupBoxEntry.Controls.Add(this.dateTimePickerDate);
            this.groupBoxEntry.Controls.Add(this.lblNotes);
            this.groupBoxEntry.Controls.Add(this.btnUpdateEntry);
            this.groupBoxEntry.Location = new System.Drawing.Point(14, 12);
            this.groupBoxEntry.Name = "groupBoxEntry";
            this.groupBoxEntry.Size = new System.Drawing.Size(339, 482);
            this.groupBoxEntry.TabIndex = 33;
            this.groupBoxEntry.TabStop = false;
            this.groupBoxEntry.Text = "Edit Entry";
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
            // lblHoursSpent
            // 
            this.lblHoursSpent.AutoSize = true;
            this.lblHoursSpent.Location = new System.Drawing.Point(23, 91);
            this.lblHoursSpent.Name = "lblHoursSpent";
            this.lblHoursSpent.Size = new System.Drawing.Size(105, 21);
            this.lblHoursSpent.TabIndex = 50;
            this.lblHoursSpent.Text = "Hours Spent:";
            // 
            // textBoxHoursSpent
            // 
            this.textBoxHoursSpent.Location = new System.Drawing.Point(23, 115);
            this.textBoxHoursSpent.Name = "textBoxHoursSpent";
            this.textBoxHoursSpent.Size = new System.Drawing.Size(105, 29);
            this.textBoxHoursSpent.TabIndex = 49;
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(23, 191);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(269, 206);
            this.textBoxNotes.TabIndex = 39;
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
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(23, 167);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(58, 21);
            this.lblNotes.TabIndex = 38;
            this.lblNotes.Text = "Notes:";
            // 
            // btnUpdateEntry
            // 
            this.btnUpdateEntry.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateEntry.Location = new System.Drawing.Point(72, 403);
            this.btnUpdateEntry.Name = "btnUpdateEntry";
            this.btnUpdateEntry.Size = new System.Drawing.Size(164, 37);
            this.btnUpdateEntry.TabIndex = 37;
            this.btnUpdateEntry.Text = "Update Entry";
            this.btnUpdateEntry.UseVisualStyleBackColor = true;
            this.btnUpdateEntry.Click += new System.EventHandler(this.btnUpdateEntry_Click);
            // 
            // frmEditEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(366, 506);
            this.Controls.Add(this.groupBoxEntry);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Name = "frmEditEntry";
            this.Text = "Edit Entry";
            this.groupBoxEntry.ResumeLayout(false);
            this.groupBoxEntry.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEntry;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Button btnUpdateEntry;
        private System.Windows.Forms.Label lblHoursSpent;
        private System.Windows.Forms.TextBox textBoxHoursSpent;
    }
}