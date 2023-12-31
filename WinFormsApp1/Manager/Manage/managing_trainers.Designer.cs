namespace WinFormsApp1
{
    partial class managing_trainers
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
            this.managing_employee_functionality_combob = new System.Windows.Forms.ComboBox();
            this.remove_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.add_update_panel = new System.Windows.Forms.Panel();
            this.managerSSN_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.employee_SSN_tb = new System.Windows.Forms.TextBox();
            this.employee_gender_combob = new System.Windows.Forms.ComboBox();
            this.trainer_certificates_tb = new System.Windows.Forms.TextBox();
            this.trainer_certificates_lbl = new System.Windows.Forms.Label();
            this.employee_birth_date_db = new System.Windows.Forms.DateTimePicker();
            this.employee_SSN_lbl = new System.Windows.Forms.Label();
            this.employee_address_lbl = new System.Windows.Forms.Label();
            this.employee_address_tb = new System.Windows.Forms.TextBox();
            this.employee_gender_lbl = new System.Windows.Forms.Label();
            this.employee_phone_nmber_lbl = new System.Windows.Forms.Label();
            this.device_birth_date_lbl = new System.Windows.Forms.Label();
            this.employee_phone_number_tb = new System.Windows.Forms.TextBox();
            this.add_button = new System.Windows.Forms.Button();
            this.employee_name_tb = new System.Windows.Forms.TextBox();
            this.employee_name_lbl = new System.Windows.Forms.Label();
            this.choose_button = new System.Windows.Forms.Button();
            this.name_combob = new System.Windows.Forms.ComboBox();
            this.resultsDataGrid = new System.Windows.Forms.DataGridView();
            this.add_update_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // managing_employee_functionality_combob
            // 
            this.managing_employee_functionality_combob.FormattingEnabled = true;
            this.managing_employee_functionality_combob.Items.AddRange(new object[] {
            "Add",
            "Update",
            "Remove",
            "Search"});
            this.managing_employee_functionality_combob.Location = new System.Drawing.Point(141, 22);
            this.managing_employee_functionality_combob.Name = "managing_employee_functionality_combob";
            this.managing_employee_functionality_combob.Size = new System.Drawing.Size(382, 23);
            this.managing_employee_functionality_combob.TabIndex = 57;
            this.managing_employee_functionality_combob.Text = "Choose Functionality";
            // 
            // remove_button
            // 
            this.remove_button.Location = new System.Drawing.Point(322, 389);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(139, 47);
            this.remove_button.TabIndex = 55;
            this.remove_button.Text = "Remove";
            this.remove_button.UseVisualStyleBackColor = true;
            this.remove_button.Click += new System.EventHandler(this.remove_button_Click);
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(322, 389);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(139, 47);
            this.search_button.TabIndex = 54;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(322, 389);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(139, 47);
            this.update_button.TabIndex = 53;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // add_update_panel
            // 
            this.add_update_panel.Controls.Add(this.managerSSN_tb);
            this.add_update_panel.Controls.Add(this.label1);
            this.add_update_panel.Controls.Add(this.employee_SSN_tb);
            this.add_update_panel.Controls.Add(this.employee_gender_combob);
            this.add_update_panel.Controls.Add(this.trainer_certificates_tb);
            this.add_update_panel.Controls.Add(this.trainer_certificates_lbl);
            this.add_update_panel.Controls.Add(this.employee_birth_date_db);
            this.add_update_panel.Controls.Add(this.employee_SSN_lbl);
            this.add_update_panel.Controls.Add(this.employee_address_lbl);
            this.add_update_panel.Controls.Add(this.employee_address_tb);
            this.add_update_panel.Controls.Add(this.employee_gender_lbl);
            this.add_update_panel.Controls.Add(this.employee_phone_nmber_lbl);
            this.add_update_panel.Controls.Add(this.device_birth_date_lbl);
            this.add_update_panel.Controls.Add(this.employee_phone_number_tb);
            this.add_update_panel.Location = new System.Drawing.Point(191, 97);
            this.add_update_panel.Name = "add_update_panel";
            this.add_update_panel.Size = new System.Drawing.Size(382, 286);
            this.add_update_panel.TabIndex = 56;
            // 
            // managerSSN_tb
            // 
            this.managerSSN_tb.Location = new System.Drawing.Point(163, 32);
            this.managerSSN_tb.Name = "managerSSN_tb";
            this.managerSSN_tb.Size = new System.Drawing.Size(200, 23);
            this.managerSSN_tb.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 34;
            this.label1.Text = "Manager SSN";
            // 
            // employee_SSN_tb
            // 
            this.employee_SSN_tb.Location = new System.Drawing.Point(163, 3);
            this.employee_SSN_tb.Name = "employee_SSN_tb";
            this.employee_SSN_tb.Size = new System.Drawing.Size(200, 23);
            this.employee_SSN_tb.TabIndex = 12;
            // 
            // employee_gender_combob
            // 
            this.employee_gender_combob.FormattingEnabled = true;
            this.employee_gender_combob.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.employee_gender_combob.Location = new System.Drawing.Point(163, 90);
            this.employee_gender_combob.Name = "employee_gender_combob";
            this.employee_gender_combob.Size = new System.Drawing.Size(200, 23);
            this.employee_gender_combob.TabIndex = 11;
            // 
            // trainer_certificates_tb
            // 
            this.trainer_certificates_tb.Location = new System.Drawing.Point(163, 177);
            this.trainer_certificates_tb.Multiline = true;
            this.trainer_certificates_tb.Name = "trainer_certificates_tb";
            this.trainer_certificates_tb.Size = new System.Drawing.Size(200, 47);
            this.trainer_certificates_tb.TabIndex = 23;
            // 
            // trainer_certificates_lbl
            // 
            this.trainer_certificates_lbl.AutoSize = true;
            this.trainer_certificates_lbl.Location = new System.Drawing.Point(21, 192);
            this.trainer_certificates_lbl.Name = "trainer_certificates_lbl";
            this.trainer_certificates_lbl.Size = new System.Drawing.Size(66, 15);
            this.trainer_certificates_lbl.TabIndex = 24;
            this.trainer_certificates_lbl.Text = "Certificates";
            // 
            // employee_birth_date_db
            // 
            this.employee_birth_date_db.Location = new System.Drawing.Point(163, 148);
            this.employee_birth_date_db.Name = "employee_birth_date_db";
            this.employee_birth_date_db.Size = new System.Drawing.Size(200, 23);
            this.employee_birth_date_db.TabIndex = 14;
            this.employee_birth_date_db.Value = new System.DateTime(2022, 12, 9, 0, 0, 0, 0);
            // 
            // employee_SSN_lbl
            // 
            this.employee_SSN_lbl.AutoSize = true;
            this.employee_SSN_lbl.Location = new System.Drawing.Point(21, 6);
            this.employee_SSN_lbl.Name = "employee_SSN_lbl";
            this.employee_SSN_lbl.Size = new System.Drawing.Size(28, 15);
            this.employee_SSN_lbl.TabIndex = 15;
            this.employee_SSN_lbl.Text = "SSN";
            // 
            // employee_address_lbl
            // 
            this.employee_address_lbl.AutoSize = true;
            this.employee_address_lbl.Location = new System.Drawing.Point(21, 64);
            this.employee_address_lbl.Name = "employee_address_lbl";
            this.employee_address_lbl.Size = new System.Drawing.Size(49, 15);
            this.employee_address_lbl.TabIndex = 17;
            this.employee_address_lbl.Text = "Address";
            // 
            // employee_address_tb
            // 
            this.employee_address_tb.Location = new System.Drawing.Point(163, 61);
            this.employee_address_tb.Name = "employee_address_tb";
            this.employee_address_tb.Size = new System.Drawing.Size(200, 23);
            this.employee_address_tb.TabIndex = 22;
            // 
            // employee_gender_lbl
            // 
            this.employee_gender_lbl.AutoSize = true;
            this.employee_gender_lbl.Location = new System.Drawing.Point(21, 93);
            this.employee_gender_lbl.Name = "employee_gender_lbl";
            this.employee_gender_lbl.Size = new System.Drawing.Size(45, 15);
            this.employee_gender_lbl.TabIndex = 18;
            this.employee_gender_lbl.Text = "Gender";
            // 
            // employee_phone_nmber_lbl
            // 
            this.employee_phone_nmber_lbl.AutoSize = true;
            this.employee_phone_nmber_lbl.Location = new System.Drawing.Point(21, 122);
            this.employee_phone_nmber_lbl.Name = "employee_phone_nmber_lbl";
            this.employee_phone_nmber_lbl.Size = new System.Drawing.Size(88, 15);
            this.employee_phone_nmber_lbl.TabIndex = 21;
            this.employee_phone_nmber_lbl.Text = "Phone Number";
            // 
            // device_birth_date_lbl
            // 
            this.device_birth_date_lbl.AutoSize = true;
            this.device_birth_date_lbl.Location = new System.Drawing.Point(21, 154);
            this.device_birth_date_lbl.Name = "device_birth_date_lbl";
            this.device_birth_date_lbl.Size = new System.Drawing.Size(59, 15);
            this.device_birth_date_lbl.TabIndex = 19;
            this.device_birth_date_lbl.Text = "Birht Date";
            // 
            // employee_phone_number_tb
            // 
            this.employee_phone_number_tb.Location = new System.Drawing.Point(163, 119);
            this.employee_phone_number_tb.Name = "employee_phone_number_tb";
            this.employee_phone_number_tb.Size = new System.Drawing.Size(200, 23);
            this.employee_phone_number_tb.TabIndex = 20;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(322, 389);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(139, 47);
            this.add_button.TabIndex = 52;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // employee_name_tb
            // 
            this.employee_name_tb.Location = new System.Drawing.Point(354, 68);
            this.employee_name_tb.Name = "employee_name_tb";
            this.employee_name_tb.Size = new System.Drawing.Size(200, 23);
            this.employee_name_tb.TabIndex = 49;
            // 
            // employee_name_lbl
            // 
            this.employee_name_lbl.AutoSize = true;
            this.employee_name_lbl.Location = new System.Drawing.Point(212, 71);
            this.employee_name_lbl.Name = "employee_name_lbl";
            this.employee_name_lbl.Size = new System.Drawing.Size(39, 15);
            this.employee_name_lbl.TabIndex = 50;
            this.employee_name_lbl.Text = "Name";
            // 
            // choose_button
            // 
            this.choose_button.Location = new System.Drawing.Point(543, 21);
            this.choose_button.Name = "choose_button";
            this.choose_button.Size = new System.Drawing.Size(75, 23);
            this.choose_button.TabIndex = 58;
            this.choose_button.Text = "Choose";
            this.choose_button.UseVisualStyleBackColor = true;
            this.choose_button.Click += new System.EventHandler(this.choose_button_Click);
            // 
            // name_combob
            // 
            this.name_combob.FormattingEnabled = true;
            this.name_combob.Location = new System.Drawing.Point(335, 68);
            this.name_combob.Name = "name_combob";
            this.name_combob.Size = new System.Drawing.Size(219, 23);
            this.name_combob.TabIndex = 61;
            this.name_combob.Text = "choose the trainer";
            // 
            // resultsDataGrid
            // 
            this.resultsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsDataGrid.Enabled = false;
            this.resultsDataGrid.Location = new System.Drawing.Point(26, 97);
            this.resultsDataGrid.Name = "resultsDataGrid";
            this.resultsDataGrid.RowHeadersWidth = 51;
            this.resultsDataGrid.RowTemplate.Height = 25;
            this.resultsDataGrid.Size = new System.Drawing.Size(751, 286);
            this.resultsDataGrid.TabIndex = 62;
            // 
            // managing_trainers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(178)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.choose_button);
            this.Controls.Add(this.managing_employee_functionality_combob);
            this.Controls.Add(this.remove_button);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.add_update_panel);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.employee_name_tb);
            this.Controls.Add(this.employee_name_lbl);
            this.Controls.Add(this.name_combob);
            this.Controls.Add(this.resultsDataGrid);
            this.Name = "managing_trainers";
            this.Text = "managing_traniers";
            this.Load += new System.EventHandler(this.managing_traniers_Load);
            this.add_update_panel.ResumeLayout(false);
            this.add_update_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox managing_employee_functionality_combob;
        private Button remove_button;
        private Button search_button;
        private Button update_button;
        private Panel add_update_panel;
        private TextBox employee_SSN_tb;
        private ComboBox employee_gender_combob;
        private DateTimePicker employee_birth_date_db;
        private Label employee_SSN_lbl;
        private Label employee_address_lbl;
        private TextBox employee_address_tb;
        private Label employee_gender_lbl;
        private Label employee_phone_nmber_lbl;
        private Label device_birth_date_lbl;
        private TextBox employee_phone_number_tb;
        private Button add_button;
        private TextBox employee_name_tb;
        private Label employee_name_lbl;
        private TextBox trainer_certificates_tb;
        private Label trainer_certificates_lbl;
        private Button choose_button;
        private ComboBox name_combob;
        private DataGridView resultsDataGrid;
        private TextBox managerSSN_tb;
        private Label label1;
    }
}