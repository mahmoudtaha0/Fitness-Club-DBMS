
namespace Receptionist
{
    partial class RegisterInvitation
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
            this.textBox_guestname = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_mobile = new System.Windows.Forms.Label();
            this.textBox_mobile = new System.Windows.Forms.TextBox();
            this.label_host = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label_date = new System.Windows.Forms.Label();
            this.register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_guestname
            // 
            this.textBox_guestname.Location = new System.Drawing.Point(354, 63);
            this.textBox_guestname.Name = "textBox_guestname";
            this.textBox_guestname.Size = new System.Drawing.Size(169, 22);
            this.textBox_guestname.TabIndex = 0;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(180, 68);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(87, 17);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "Guest Name";
            // 
            // label_mobile
            // 
            this.label_mobile.AutoSize = true;
            this.label_mobile.Location = new System.Drawing.Point(180, 140);
            this.label_mobile.Name = "label_mobile";
            this.label_mobile.Size = new System.Drawing.Size(103, 17);
            this.label_mobile.TabIndex = 2;
            this.label_mobile.Text = "Mobile Number";
            // 
            // textBox_mobile
            // 
            this.textBox_mobile.Location = new System.Drawing.Point(354, 140);
            this.textBox_mobile.Name = "textBox_mobile";
            this.textBox_mobile.Size = new System.Drawing.Size(169, 22);
            this.textBox_mobile.TabIndex = 4;
            // 
            // label_host
            // 
            this.label_host.AutoSize = true;
            this.label_host.Location = new System.Drawing.Point(180, 216);
            this.label_host.Name = "label_host";
            this.label_host.Size = new System.Drawing.Size(90, 17);
            this.label_host.TabIndex = 5;
            this.label_host.Text = "Host Trainee";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(354, 216);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(83, 22);
            this.textBox2.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(354, 287);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(111, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Location = new System.Drawing.Point(180, 292);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(38, 17);
            this.label_date.TabIndex = 8;
            this.label_date.Text = "Date";
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(499, 353);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(200, 62);
            this.register.TabIndex = 9;
            this.register.Text = "REGISTER";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // RegisterInvitation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.register);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label_host);
            this.Controls.Add(this.textBox_mobile);
            this.Controls.Add(this.label_mobile);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.textBox_guestname);
            this.Name = "RegisterInvitation";
            this.Text = "RegisterInvitation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_guestname;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_mobile;
        private System.Windows.Forms.TextBox textBox_mobile;
        private System.Windows.Forms.Label label_host;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Button register;
    }
}