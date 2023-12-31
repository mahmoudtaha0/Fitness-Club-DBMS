namespace WinFormsApp1
{
    partial class attendance
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
            this.attendance_dgv = new System.Windows.Forms.DataGridView();
            this.attendance_SSN_db = new System.Windows.Forms.TextBox();
            this.attendance_date_db = new System.Windows.Forms.DateTimePicker();
            this.attendance_SSN_lbl = new System.Windows.Forms.Label();
            this.attendance_date_lbl = new System.Windows.Forms.Label();
            this.attendance_view_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.attendance_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // attendance_dgv
            // 
            this.attendance_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attendance_dgv.Location = new System.Drawing.Point(49, 125);
            this.attendance_dgv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.attendance_dgv.Name = "attendance_dgv";
            this.attendance_dgv.RowHeadersWidth = 51;
            this.attendance_dgv.RowTemplate.Height = 25;
            this.attendance_dgv.Size = new System.Drawing.Size(821, 459);
            this.attendance_dgv.TabIndex = 0;
            // 
            // attendance_SSN_db
            // 
            this.attendance_SSN_db.Location = new System.Drawing.Point(211, 17);
            this.attendance_SSN_db.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.attendance_SSN_db.Name = "attendance_SSN_db";
            this.attendance_SSN_db.Size = new System.Drawing.Size(228, 27);
            this.attendance_SSN_db.TabIndex = 20;
            // 
            // attendance_date_db
            // 
            this.attendance_date_db.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.attendance_date_db.Location = new System.Drawing.Point(211, 69);
            this.attendance_date_db.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.attendance_date_db.Name = "attendance_date_db";
            this.attendance_date_db.Size = new System.Drawing.Size(228, 27);
            this.attendance_date_db.TabIndex = 21;
            this.attendance_date_db.Value = new System.DateTime(2022, 12, 9, 0, 0, 0, 0);
            // 
            // attendance_SSN_lbl
            // 
            this.attendance_SSN_lbl.AutoSize = true;
            this.attendance_SSN_lbl.Location = new System.Drawing.Point(49, 21);
            this.attendance_SSN_lbl.Name = "attendance_SSN_lbl";
            this.attendance_SSN_lbl.Size = new System.Drawing.Size(106, 20);
            this.attendance_SSN_lbl.TabIndex = 22;
            this.attendance_SSN_lbl.Text = "Employee SSN";
            // 
            // attendance_date_lbl
            // 
            this.attendance_date_lbl.AutoSize = true;
            this.attendance_date_lbl.Location = new System.Drawing.Point(49, 77);
            this.attendance_date_lbl.Name = "attendance_date_lbl";
            this.attendance_date_lbl.Size = new System.Drawing.Size(41, 20);
            this.attendance_date_lbl.TabIndex = 23;
            this.attendance_date_lbl.Text = "Date";
            // 
            // attendance_view_button
            // 
            this.attendance_view_button.Location = new System.Drawing.Point(735, 32);
            this.attendance_view_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.attendance_view_button.Name = "attendance_view_button";
            this.attendance_view_button.Size = new System.Drawing.Size(135, 52);
            this.attendance_view_button.TabIndex = 24;
            this.attendance_view_button.Text = "View";
            this.attendance_view_button.UseVisualStyleBackColor = true;
            this.attendance_view_button.Click += new System.EventHandler(this.attendance_view_button_Click);
            // 
            // attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.attendance_view_button);
            this.Controls.Add(this.attendance_SSN_db);
            this.Controls.Add(this.attendance_date_db);
            this.Controls.Add(this.attendance_SSN_lbl);
            this.Controls.Add(this.attendance_date_lbl);
            this.Controls.Add(this.attendance_dgv);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "attendance";
            this.Text = "Attendance";
            this.Load += new System.EventHandler(this.attendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.attendance_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView attendance_dgv;
        private TextBox attendance_SSN_db;
        private DateTimePicker attendance_date_db;
        private Label attendance_SSN_lbl;
        private Label attendance_date_lbl;
        private Button attendance_view_button;
    }
}