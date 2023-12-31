
namespace Receptionist
{
    partial class RequestHoliday
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
            this.label_ssn = new System.Windows.Forms.Label();
            this.label_sdate = new System.Windows.Forms.Label();
            this.label_edate = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.request = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_ssn
            // 
            this.label_ssn.AutoSize = true;
            this.label_ssn.Location = new System.Drawing.Point(80, 50);
            this.label_ssn.Name = "label_ssn";
            this.label_ssn.Size = new System.Drawing.Size(36, 17);
            this.label_ssn.TabIndex = 0;
            this.label_ssn.Text = "SSN";
            // 
            // label_sdate
            // 
            this.label_sdate.AutoSize = true;
            this.label_sdate.Location = new System.Drawing.Point(80, 130);
            this.label_sdate.Name = "label_sdate";
            this.label_sdate.Size = new System.Drawing.Size(72, 17);
            this.label_sdate.TabIndex = 1;
            this.label_sdate.Text = "Start Date";
            // 
            // label_edate
            // 
            this.label_edate.AutoSize = true;
            this.label_edate.Location = new System.Drawing.Point(80, 217);
            this.label_edate.Name = "label_edate";
            this.label_edate.Size = new System.Drawing.Size(67, 17);
            this.label_edate.TabIndex = 2;
            this.label_edate.Text = "End Date";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(586, 384);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(60, 17);
            this.label_status.TabIndex = 3;
            this.label_status.Text = "Pending";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(256, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 22);
            this.textBox1.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(256, 125);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(118, 22);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(256, 212);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(118, 22);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // request
            // 
            this.request.Location = new System.Drawing.Point(524, 282);
            this.request.Name = "request";
            this.request.Size = new System.Drawing.Size(188, 71);
            this.request.TabIndex = 7;
            this.request.Text = "REQUEST";
            this.request.UseVisualStyleBackColor = true;
            this.request.Click += new System.EventHandler(this.request_Click);
            // 
            // RequestHoliday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.request);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.label_edate);
            this.Controls.Add(this.label_sdate);
            this.Controls.Add(this.label_ssn);
            this.Name = "RequestHoliday";
            this.Text = "RequestHoliday";
            this.Load += new System.EventHandler(this.RequestHoliday_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ssn;
        private System.Windows.Forms.Label label_sdate;
        private System.Windows.Forms.Label label_edate;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button request;
    }
}