namespace WinFormsApp1.Manager
{
    partial class settings
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
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.currentPasswordTb = new System.Windows.Forms.TextBox();
            this.newPasswordTb = new System.Windows.Forms.TextBox();
            this.repNewPasswordTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(106)))), ((int)(((byte)(135)))));
            this.label8.Location = new System.Drawing.Point(25, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 41);
            this.label8.TabIndex = 7;
            this.label8.Text = "SETTINGS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Change Password";
            // 
            // currentPasswordTb
            // 
            this.currentPasswordTb.Location = new System.Drawing.Point(328, 180);
            this.currentPasswordTb.Name = "currentPasswordTb";
            this.currentPasswordTb.Size = new System.Drawing.Size(283, 27);
            this.currentPasswordTb.TabIndex = 8;
            // 
            // newPasswordTb
            // 
            this.newPasswordTb.Location = new System.Drawing.Point(328, 229);
            this.newPasswordTb.Name = "newPasswordTb";
            this.newPasswordTb.Size = new System.Drawing.Size(283, 27);
            this.newPasswordTb.TabIndex = 8;
            // 
            // repNewPasswordTb
            // 
            this.repNewPasswordTb.Location = new System.Drawing.Point(328, 278);
            this.repNewPasswordTb.Name = "repNewPasswordTb";
            this.repNewPasswordTb.Size = new System.Drawing.Size(283, 27);
            this.repNewPasswordTb.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(121, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Current Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(121, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "New Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(121, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Repeat Password";
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(106)))), ((int)(((byte)(135)))));
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Location = new System.Drawing.Point(342, 508);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(250, 45);
            this.logoutButton.TabIndex = 9;
            this.logoutButton.Text = "Log out";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(106)))), ((int)(((byte)(135)))));
            this.changePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePasswordButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.changePasswordButton.ForeColor = System.Drawing.Color.White;
            this.changePasswordButton.Location = new System.Drawing.Point(342, 345);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(250, 45);
            this.changePasswordButton.TabIndex = 9;
            this.changePasswordButton.Text = "Change";
            this.changePasswordButton.UseVisualStyleBackColor = false;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(178)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.changePasswordButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.repNewPasswordTb);
            this.Controls.Add(this.newPasswordTb);
            this.Controls.Add(this.currentPasswordTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Name = "settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label8;
        private Label label1;
        private TextBox currentPasswordTb;
        private TextBox newPasswordTb;
        private TextBox repNewPasswordTb;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button logoutButton;
        private Button changePasswordButton;
    }
}