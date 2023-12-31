namespace WinFormsApp1
{
    partial class Manage_Salaries
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
            this.managing_salaries_combob = new System.Windows.Forms.ComboBox();
            this.choose_button = new System.Windows.Forms.Button();
            this.salary_SSN_db = new System.Windows.Forms.TextBox();
            this.salary_date_db = new System.Windows.Forms.DateTimePicker();
            this.salary_SSN_lbl = new System.Windows.Forms.Label();
            this.salary_date_lbl = new System.Windows.Forms.Label();
            this.search_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.add_update_salary_panel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.salary_gross_lbl = new System.Windows.Forms.Label();
            this.salary_gross_db = new System.Windows.Forms.TextBox();
            this.salary_taxes_lbl = new System.Windows.Forms.Label();
            this.salary_taxes_db = new System.Windows.Forms.TextBox();
            this.salary_penalty_db = new System.Windows.Forms.TextBox();
            this.salary_bonus_lbl = new System.Windows.Forms.Label();
            this.salary_penalty_lbl = new System.Windows.Forms.Label();
            this.salary_bonus_db = new System.Windows.Forms.TextBox();
            this.all_salaries_dgv = new System.Windows.Forms.DataGridView();
            this.panel_date = new System.Windows.Forms.Panel();
            this.panel_ssn = new System.Windows.Forms.Panel();
            this.add_update_salary_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.all_salaries_dgv)).BeginInit();
            this.panel_date.SuspendLayout();
            this.panel_ssn.SuspendLayout();
            this.SuspendLayout();
            // 
            // managing_salaries_combob
            // 
            this.managing_salaries_combob.FormattingEnabled = true;
            this.managing_salaries_combob.Items.AddRange(new object[] {
            "Add Salary",
            "Update Salary",
            "Search for an Employee Salary In Certain Month",
            "Search for All Employees Salaries In Certain Month",
            "Search for an Employee All Salaries"});
            this.managing_salaries_combob.Location = new System.Drawing.Point(154, 24);
            this.managing_salaries_combob.Name = "managing_salaries_combob";
            this.managing_salaries_combob.Size = new System.Drawing.Size(359, 23);
            this.managing_salaries_combob.TabIndex = 52;
            this.managing_salaries_combob.Text = "Choose Functionality";
            // 
            // choose_button
            // 
            this.choose_button.Location = new System.Drawing.Point(531, 23);
            this.choose_button.Name = "choose_button";
            this.choose_button.Size = new System.Drawing.Size(75, 23);
            this.choose_button.TabIndex = 53;
            this.choose_button.Text = "Choose";
            this.choose_button.UseVisualStyleBackColor = true;
            this.choose_button.Click += new System.EventHandler(this.choose_button_Click);
            // 
            // salary_SSN_db
            // 
            this.salary_SSN_db.Location = new System.Drawing.Point(166, 0);
            this.salary_SSN_db.Name = "salary_SSN_db";
            this.salary_SSN_db.Size = new System.Drawing.Size(200, 23);
            this.salary_SSN_db.TabIndex = 12;
            // 
            // salary_date_db
            // 
            this.salary_date_db.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.salary_date_db.Location = new System.Drawing.Point(165, 1);
            this.salary_date_db.Name = "salary_date_db";
            this.salary_date_db.Size = new System.Drawing.Size(200, 23);
            this.salary_date_db.TabIndex = 14;
            this.salary_date_db.Value = new System.DateTime(2022, 12, 9, 0, 0, 0, 0);
            // 
            // salary_SSN_lbl
            // 
            this.salary_SSN_lbl.AutoSize = true;
            this.salary_SSN_lbl.Location = new System.Drawing.Point(24, 3);
            this.salary_SSN_lbl.Name = "salary_SSN_lbl";
            this.salary_SSN_lbl.Size = new System.Drawing.Size(83, 15);
            this.salary_SSN_lbl.TabIndex = 15;
            this.salary_SSN_lbl.Text = "Employee SSN";
            // 
            // salary_date_lbl
            // 
            this.salary_date_lbl.AutoSize = true;
            this.salary_date_lbl.Location = new System.Drawing.Point(23, 7);
            this.salary_date_lbl.Name = "salary_date_lbl";
            this.salary_date_lbl.Size = new System.Drawing.Size(31, 15);
            this.salary_date_lbl.TabIndex = 19;
            this.salary_date_lbl.Text = "Date";
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(472, 363);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(164, 47);
            this.search_button.TabIndex = 57;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click_1);
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(121, 363);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(164, 47);
            this.update_button.TabIndex = 56;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click_1);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(302, 363);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(164, 47);
            this.add_button.TabIndex = 55;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // add_update_salary_panel
            // 
            this.add_update_salary_panel.Controls.Add(this.label4);
            this.add_update_salary_panel.Controls.Add(this.label3);
            this.add_update_salary_panel.Controls.Add(this.label2);
            this.add_update_salary_panel.Controls.Add(this.label1);
            this.add_update_salary_panel.Controls.Add(this.salary_gross_lbl);
            this.add_update_salary_panel.Controls.Add(this.salary_gross_db);
            this.add_update_salary_panel.Controls.Add(this.salary_taxes_lbl);
            this.add_update_salary_panel.Controls.Add(this.salary_taxes_db);
            this.add_update_salary_panel.Controls.Add(this.salary_penalty_db);
            this.add_update_salary_panel.Controls.Add(this.salary_bonus_lbl);
            this.add_update_salary_panel.Controls.Add(this.salary_penalty_lbl);
            this.add_update_salary_panel.Controls.Add(this.salary_bonus_db);
            this.add_update_salary_panel.Location = new System.Drawing.Point(189, 150);
            this.add_update_salary_panel.Name = "add_update_salary_panel";
            this.add_update_salary_panel.Size = new System.Drawing.Size(365, 126);
            this.add_update_salary_panel.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 15);
            this.label4.TabIndex = 45;
            this.label4.Text = "LE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 15);
            this.label3.TabIndex = 44;
            this.label3.Text = "LE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 43;
            this.label1.Text = "LE";
            // 
            // salary_gross_lbl
            // 
            this.salary_gross_lbl.AutoSize = true;
            this.salary_gross_lbl.Location = new System.Drawing.Point(12, 7);
            this.salary_gross_lbl.Name = "salary_gross_lbl";
            this.salary_gross_lbl.Size = new System.Drawing.Size(70, 15);
            this.salary_gross_lbl.TabIndex = 41;
            this.salary_gross_lbl.Text = "Gross Salary";
            // 
            // salary_gross_db
            // 
            this.salary_gross_db.Location = new System.Drawing.Point(154, 4);
            this.salary_gross_db.Name = "salary_gross_db";
            this.salary_gross_db.Size = new System.Drawing.Size(170, 23);
            this.salary_gross_db.TabIndex = 42;
            // 
            // salary_taxes_lbl
            // 
            this.salary_taxes_lbl.AutoSize = true;
            this.salary_taxes_lbl.Location = new System.Drawing.Point(12, 36);
            this.salary_taxes_lbl.Name = "salary_taxes_lbl";
            this.salary_taxes_lbl.Size = new System.Drawing.Size(97, 15);
            this.salary_taxes_lbl.TabIndex = 39;
            this.salary_taxes_lbl.Text = "Taxes Percentage";
            // 
            // salary_taxes_db
            // 
            this.salary_taxes_db.Location = new System.Drawing.Point(154, 33);
            this.salary_taxes_db.Name = "salary_taxes_db";
            this.salary_taxes_db.Size = new System.Drawing.Size(170, 23);
            this.salary_taxes_db.TabIndex = 40;
            // 
            // salary_penalty_db
            // 
            this.salary_penalty_db.Location = new System.Drawing.Point(154, 91);
            this.salary_penalty_db.Name = "salary_penalty_db";
            this.salary_penalty_db.Size = new System.Drawing.Size(170, 23);
            this.salary_penalty_db.TabIndex = 20;
            // 
            // salary_bonus_lbl
            // 
            this.salary_bonus_lbl.AutoSize = true;
            this.salary_bonus_lbl.Location = new System.Drawing.Point(12, 65);
            this.salary_bonus_lbl.Name = "salary_bonus_lbl";
            this.salary_bonus_lbl.Size = new System.Drawing.Size(40, 15);
            this.salary_bonus_lbl.TabIndex = 17;
            this.salary_bonus_lbl.Text = "Bonus";
            // 
            // salary_penalty_lbl
            // 
            this.salary_penalty_lbl.AutoSize = true;
            this.salary_penalty_lbl.Location = new System.Drawing.Point(12, 94);
            this.salary_penalty_lbl.Name = "salary_penalty_lbl";
            this.salary_penalty_lbl.Size = new System.Drawing.Size(46, 15);
            this.salary_penalty_lbl.TabIndex = 21;
            this.salary_penalty_lbl.Text = "Penalty";
            // 
            // salary_bonus_db
            // 
            this.salary_bonus_db.Location = new System.Drawing.Point(154, 62);
            this.salary_bonus_db.Name = "salary_bonus_db";
            this.salary_bonus_db.Size = new System.Drawing.Size(170, 23);
            this.salary_bonus_db.TabIndex = 22;
            // 
            // all_salaries_dgv
            // 
            this.all_salaries_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.all_salaries_dgv.Location = new System.Drawing.Point(4, 150);
            this.all_salaries_dgv.Name = "all_salaries_dgv";
            this.all_salaries_dgv.RowHeadersWidth = 51;
            this.all_salaries_dgv.RowTemplate.Height = 25;
            this.all_salaries_dgv.Size = new System.Drawing.Size(784, 191);
            this.all_salaries_dgv.TabIndex = 58;
            // 
            // panel_date
            // 
            this.panel_date.Controls.Add(this.salary_date_db);
            this.panel_date.Controls.Add(this.salary_date_lbl);
            this.panel_date.Location = new System.Drawing.Point(178, 123);
            this.panel_date.Name = "panel_date";
            this.panel_date.Size = new System.Drawing.Size(395, 25);
            this.panel_date.TabIndex = 21;
            // 
            // panel_ssn
            // 
            this.panel_ssn.Controls.Add(this.salary_SSN_db);
            this.panel_ssn.Controls.Add(this.salary_SSN_lbl);
            this.panel_ssn.Location = new System.Drawing.Point(178, 95);
            this.panel_ssn.Name = "panel_ssn";
            this.panel_ssn.Size = new System.Drawing.Size(395, 26);
            this.panel_ssn.TabIndex = 20;
            // 
            // Manage_Salaries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(178)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_date);
            this.Controls.Add(this.panel_ssn);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.add_update_salary_panel);
            this.Controls.Add(this.all_salaries_dgv);
            this.Controls.Add(this.choose_button);
            this.Controls.Add(this.managing_salaries_combob);
            this.Name = "Manage_Salaries";
            this.Text = "Manage_Salaries";
            this.Load += new System.EventHandler(this.Manage_Salaries_Load);
            this.add_update_salary_panel.ResumeLayout(false);
            this.add_update_salary_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.all_salaries_dgv)).EndInit();
            this.panel_date.ResumeLayout(false);
            this.panel_date.PerformLayout();
            this.panel_ssn.ResumeLayout(false);
            this.panel_ssn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ComboBox managing_salaries_combob;
        private Button choose_button;
        private TextBox salary_SSN_db;
        private DateTimePicker salary_date_db;
        private Label salary_SSN_lbl;
        private Label salary_date_lbl;
        private Button search_button;
        private Button update_button;
        private Button add_button;
        private Panel add_update_salary_panel;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label salary_gross_lbl;
        private TextBox salary_gross_db;
        private Label salary_taxes_lbl;
        private TextBox salary_taxes_db;
        private TextBox salary_penalty_db;
        private Label salary_bonus_lbl;
        private Label salary_penalty_lbl;
        private TextBox salary_bonus_db;
        private DataGridView all_salaries_dgv;
        private Panel panel_date;
        private Panel panel_ssn;
    }
}