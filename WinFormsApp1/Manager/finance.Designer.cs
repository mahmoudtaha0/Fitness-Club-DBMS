namespace WinFormsApp1
{
    partial class finance
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
            this.transaction_SSN_tb = new System.Windows.Forms.TextBox();
            this.transaction_amount_tb = new System.Windows.Forms.TextBox();
            this.transaction_description_tb = new System.Windows.Forms.TextBox();
            this.transaction_date_dp = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.transaction_type_combob = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.transaction_button = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // transaction_SSN_tb
            // 
            this.transaction_SSN_tb.Location = new System.Drawing.Point(380, 150);
            this.transaction_SSN_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.transaction_SSN_tb.Name = "transaction_SSN_tb";
            this.transaction_SSN_tb.Size = new System.Drawing.Size(228, 27);
            this.transaction_SSN_tb.TabIndex = 0;
            // 
            // transaction_amount_tb
            // 
            this.transaction_amount_tb.Location = new System.Drawing.Point(380, 245);
            this.transaction_amount_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.transaction_amount_tb.Name = "transaction_amount_tb";
            this.transaction_amount_tb.Size = new System.Drawing.Size(228, 27);
            this.transaction_amount_tb.TabIndex = 3;
            // 
            // transaction_description_tb
            // 
            this.transaction_description_tb.Location = new System.Drawing.Point(380, 297);
            this.transaction_description_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.transaction_description_tb.Name = "transaction_description_tb";
            this.transaction_description_tb.Size = new System.Drawing.Size(228, 27);
            this.transaction_description_tb.TabIndex = 4;
            // 
            // transaction_date_dp
            // 
            this.transaction_date_dp.CustomFormat = "yyyy-mm-dd";
            this.transaction_date_dp.Location = new System.Drawing.Point(380, 351);
            this.transaction_date_dp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.transaction_date_dp.Name = "transaction_date_dp";
            this.transaction_date_dp.Size = new System.Drawing.Size(228, 27);
            this.transaction_date_dp.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(225, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "SSN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(225, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(225, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(225, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(225, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Date";
            // 
            // transaction_type_combob
            // 
            this.transaction_type_combob.FormattingEnabled = true;
            this.transaction_type_combob.Items.AddRange(new object[] {
            "Withdraw",
            "Deposit"});
            this.transaction_type_combob.Location = new System.Drawing.Point(380, 195);
            this.transaction_type_combob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.transaction_type_combob.Name = "transaction_type_combob";
            this.transaction_type_combob.Size = new System.Drawing.Size(228, 28);
            this.transaction_type_combob.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(614, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "LE";
            // 
            // transaction_button
            // 
            this.transaction_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(106)))), ((int)(((byte)(135)))));
            this.transaction_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transaction_button.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.transaction_button.ForeColor = System.Drawing.Color.White;
            this.transaction_button.Location = new System.Drawing.Point(380, 466);
            this.transaction_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.transaction_button.Name = "transaction_button";
            this.transaction_button.Size = new System.Drawing.Size(160, 57);
            this.transaction_button.TabIndex = 14;
            this.transaction_button.Text = "Add Transaction";
            this.transaction_button.UseVisualStyleBackColor = false;
            this.transaction_button.Click += new System.EventHandler(this.transaction_button_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(106)))), ((int)(((byte)(135)))));
            this.label8.Location = new System.Drawing.Point(25, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(250, 41);
            this.label8.TabIndex = 6;
            this.label8.Text = "TRANSACTIONS";
            // 
            // finance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(178)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.transaction_button);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.transaction_type_combob);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.transaction_date_dp);
            this.Controls.Add(this.transaction_description_tb);
            this.Controls.Add(this.transaction_amount_tb);
            this.Controls.Add(this.transaction_SSN_tb);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "finance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "finance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox transaction_SSN_tb;
        private TextBox transaction_amount_tb;
        private TextBox transaction_description_tb;
        private DateTimePicker transaction_date_dp;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox transaction_type_combob;
        private Label label7;
        private Button transaction_button;
        private Label label8;
    }
}