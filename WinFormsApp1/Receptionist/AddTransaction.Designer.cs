
namespace Receptionist
{
    partial class AddTransaction
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
            this.label_date = new System.Windows.Forms.Label();
            this.label_type = new System.Windows.Forms.Label();
            this.label_description = new System.Windows.Forms.Label();
            this.label_amount = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.textBox_amount = new System.Windows.Forms.TextBox();
            this.comboBox_description = new System.Windows.Forms.ComboBox();
            this.add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_ssn
            // 
            this.label_ssn.AutoSize = true;
            this.label_ssn.Location = new System.Drawing.Point(59, 110);
            this.label_ssn.Name = "label_ssn";
            this.label_ssn.Size = new System.Drawing.Size(108, 20);
            this.label_ssn.TabIndex = 1;
            this.label_ssn.Text = "Transactor SSN";
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Location = new System.Drawing.Point(59, 181);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(41, 20);
            this.label_date.TabIndex = 2;
            this.label_date.Text = "Date";
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Location = new System.Drawing.Point(59, 258);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(40, 20);
            this.label_type.TabIndex = 3;
            this.label_type.Text = "Type";
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.Location = new System.Drawing.Point(59, 418);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(85, 20);
            this.label_description.TabIndex = 4;
            this.label_description.Text = "Description";
            this.label_description.Click += new System.EventHandler(this.label_trdate_Click);
            // 
            // label_amount
            // 
            this.label_amount.AutoSize = true;
            this.label_amount.Location = new System.Drawing.Point(59, 336);
            this.label_amount.Name = "label_amount";
            this.label_amount.Size = new System.Drawing.Size(62, 20);
            this.label_amount.TabIndex = 5;
            this.label_amount.Text = "Amount";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(269, 110);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(87, 27);
            this.textBox2.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(269, 181);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(115, 27);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // comboBox_type
            // 
            this.comboBox_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Items.AddRange(new object[] {
            "Deposit",
            "Withdraw"});
            this.comboBox_type.Location = new System.Drawing.Point(269, 254);
            this.comboBox_type.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(121, 28);
            this.comboBox_type.TabIndex = 9;
            // 
            // textBox_amount
            // 
            this.textBox_amount.Location = new System.Drawing.Point(269, 330);
            this.textBox_amount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_amount.Name = "textBox_amount";
            this.textBox_amount.Size = new System.Drawing.Size(115, 27);
            this.textBox_amount.TabIndex = 10;
            // 
            // comboBox_description
            // 
            this.comboBox_description.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_description.FormattingEnabled = true;
            this.comboBox_description.Items.AddRange(new object[] {
            "Locker",
            "Manager Withdrawal",
            "Salary",
            "Subscription"});
            this.comboBox_description.Location = new System.Drawing.Point(269, 409);
            this.comboBox_description.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_description.Name = "comboBox_description";
            this.comboBox_description.Size = new System.Drawing.Size(121, 28);
            this.comboBox_description.TabIndex = 11;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(517, 369);
            this.add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(196, 81);
            this.add.TabIndex = 12;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // AddTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.add);
            this.Controls.Add(this.comboBox_description);
            this.Controls.Add(this.textBox_amount);
            this.Controls.Add(this.comboBox_type);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label_amount);
            this.Controls.Add(this.label_description);
            this.Controls.Add(this.label_type);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.label_ssn);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddTransaction";
            this.Text = "AddTransaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_ssn;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.Label label_amount;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.TextBox textBox_amount;
        private System.Windows.Forms.ComboBox comboBox_description;
        private System.Windows.Forms.Button add;
    }
}