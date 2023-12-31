namespace WinFormsApp1
{
    partial class managing_managers
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
            this.manager_password_tb = new System.Windows.Forms.TextBox();
            this.employee_SSN_tb = new System.Windows.Forms.TextBox();
            this.employee_gender_combob = new System.Windows.Forms.ComboBox();
            this.manager_email_tb = new System.Windows.Forms.TextBox();
            this.receptionist_email_lbl = new System.Windows.Forms.Label();
            this.employee_birth_date_db = new System.Windows.Forms.DateTimePicker();
            this.employee_SSN_lbl = new System.Windows.Forms.Label();
            this.receptionist_password_lbl = new System.Windows.Forms.Label();
            this.employee_address_lbl = new System.Windows.Forms.Label();
            this.employee_address_tb = new System.Windows.Forms.TextBox();
            this.employee_gender_lbl = new System.Windows.Forms.Label();
            this.employee_phone_nmber_lbl = new System.Windows.Forms.Label();
            this.device_birth_date_lbl = new System.Windows.Forms.Label();
            this.employee_phone_number_tb = new System.Windows.Forms.TextBox();
            this.employee_name_tb = new System.Windows.Forms.TextBox();
            this.employee_name_lbl = new System.Windows.Forms.Label();
            this.choose_button = new System.Windows.Forms.Button();
            this.name_combob = new System.Windows.Forms.ComboBox();
            this.resultsDataGrid = new System.Windows.Forms.DataGridView();
            this.add_button = new System.Windows.Forms.Button();
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
            this.managing_employee_functionality_combob.Location = new System.Drawing.Point(137, 31);
            this.managing_employee_functionality_combob.Name = "managing_employee_functionality_combob";
            this.managing_employee_functionality_combob.Size = new System.Drawing.Size(383, 23);
            this.managing_employee_functionality_combob.TabIndex = 48;
            this.managing_employee_functionality_combob.Text = "Choose Functionality";
            // 
            // remove_button
            // 
            this.remove_button.Location = new System.Drawing.Point(316, 380);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(139, 47);
            this.remove_button.TabIndex = 46;
            this.remove_button.Text = "Remove";
            this.remove_button.UseVisualStyleBackColor = true;
            this.remove_button.Click += new System.EventHandler(this.remove_button_Click_1);
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(316, 380);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(139, 47);
            this.search_button.TabIndex = 45;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(316, 380);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(139, 47);
            this.update_button.TabIndex = 44;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click_1);
            // 
            // add_update_panel
            // 
            this.add_update_panel.Controls.Add(this.manager_password_tb);
            this.add_update_panel.Controls.Add(this.employee_SSN_tb);
            this.add_update_panel.Controls.Add(this.employee_gender_combob);
            this.add_update_panel.Controls.Add(this.manager_email_tb);
            this.add_update_panel.Controls.Add(this.receptionist_email_lbl);
            this.add_update_panel.Controls.Add(this.employee_birth_date_db);
            this.add_update_panel.Controls.Add(this.employee_SSN_lbl);
            this.add_update_panel.Controls.Add(this.receptionist_password_lbl);
            this.add_update_panel.Controls.Add(this.employee_address_lbl);
            this.add_update_panel.Controls.Add(this.employee_address_tb);
            this.add_update_panel.Controls.Add(this.employee_gender_lbl);
            this.add_update_panel.Controls.Add(this.employee_phone_nmber_lbl);
            this.add_update_panel.Controls.Add(this.device_birth_date_lbl);
            this.add_update_panel.Controls.Add(this.employee_phone_number_tb);
            this.add_update_panel.Location = new System.Drawing.Point(186, 129);
            this.add_update_panel.Name = "add_update_panel";
            this.add_update_panel.Size = new System.Drawing.Size(382, 218);
            this.add_update_panel.TabIndex = 47;
            // 
            // manager_password_tb
            // 
            this.manager_password_tb.Location = new System.Drawing.Point(163, 61);
            this.manager_password_tb.Name = "manager_password_tb";
            this.manager_password_tb.Size = new System.Drawing.Size(200, 23);
            this.manager_password_tb.TabIndex = 26;
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
            this.employee_gender_combob.Location = new System.Drawing.Point(163, 119);
            this.employee_gender_combob.Name = "employee_gender_combob";
            this.employee_gender_combob.Size = new System.Drawing.Size(200, 23);
            this.employee_gender_combob.TabIndex = 11;
            // 
            // manager_email_tb
            // 
            this.manager_email_tb.Location = new System.Drawing.Point(163, 32);
            this.manager_email_tb.Name = "manager_email_tb";
            this.manager_email_tb.Size = new System.Drawing.Size(200, 23);
            this.manager_email_tb.TabIndex = 25;
            // 
            // receptionist_email_lbl
            // 
            this.receptionist_email_lbl.AutoSize = true;
            this.receptionist_email_lbl.Location = new System.Drawing.Point(21, 35);
            this.receptionist_email_lbl.Name = "receptionist_email_lbl";
            this.receptionist_email_lbl.Size = new System.Drawing.Size(36, 15);
            this.receptionist_email_lbl.TabIndex = 27;
            this.receptionist_email_lbl.Text = "Email";
            // 
            // employee_birth_date_db
            // 
            this.employee_birth_date_db.Location = new System.Drawing.Point(163, 177);
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
            // receptionist_password_lbl
            // 
            this.receptionist_password_lbl.AutoSize = true;
            this.receptionist_password_lbl.Location = new System.Drawing.Point(21, 64);
            this.receptionist_password_lbl.Name = "receptionist_password_lbl";
            this.receptionist_password_lbl.Size = new System.Drawing.Size(57, 15);
            this.receptionist_password_lbl.TabIndex = 28;
            this.receptionist_password_lbl.Text = "Password";
            // 
            // employee_address_lbl
            // 
            this.employee_address_lbl.AutoSize = true;
            this.employee_address_lbl.Location = new System.Drawing.Point(21, 93);
            this.employee_address_lbl.Name = "employee_address_lbl";
            this.employee_address_lbl.Size = new System.Drawing.Size(49, 15);
            this.employee_address_lbl.TabIndex = 17;
            this.employee_address_lbl.Text = "Address";
            // 
            // employee_address_tb
            // 
            this.employee_address_tb.Location = new System.Drawing.Point(163, 90);
            this.employee_address_tb.Name = "employee_address_tb";
            this.employee_address_tb.Size = new System.Drawing.Size(200, 23);
            this.employee_address_tb.TabIndex = 22;
            // 
            // employee_gender_lbl
            // 
            this.employee_gender_lbl.AutoSize = true;
            this.employee_gender_lbl.Location = new System.Drawing.Point(21, 122);
            this.employee_gender_lbl.Name = "employee_gender_lbl";
            this.employee_gender_lbl.Size = new System.Drawing.Size(45, 15);
            this.employee_gender_lbl.TabIndex = 18;
            this.employee_gender_lbl.Text = "Gender";
            // 
            // employee_phone_nmber_lbl
            // 
            this.employee_phone_nmber_lbl.AutoSize = true;
            this.employee_phone_nmber_lbl.Location = new System.Drawing.Point(21, 151);
            this.employee_phone_nmber_lbl.Name = "employee_phone_nmber_lbl";
            this.employee_phone_nmber_lbl.Size = new System.Drawing.Size(88, 15);
            this.employee_phone_nmber_lbl.TabIndex = 21;
            this.employee_phone_nmber_lbl.Text = "Phone Number";
            // 
            // device_birth_date_lbl
            // 
            this.device_birth_date_lbl.AutoSize = true;
            this.device_birth_date_lbl.Location = new System.Drawing.Point(21, 183);
            this.device_birth_date_lbl.Name = "device_birth_date_lbl";
            this.device_birth_date_lbl.Size = new System.Drawing.Size(59, 15);
            this.device_birth_date_lbl.TabIndex = 19;
            this.device_birth_date_lbl.Text = "Birht Date";
            // 
            // employee_phone_number_tb
            // 
            this.employee_phone_number_tb.Location = new System.Drawing.Point(163, 148);
            this.employee_phone_number_tb.Name = "employee_phone_number_tb";
            this.employee_phone_number_tb.Size = new System.Drawing.Size(200, 23);
            this.employee_phone_number_tb.TabIndex = 20;
            // 
            // employee_name_tb
            // 
            this.employee_name_tb.Location = new System.Drawing.Point(349, 100);
            this.employee_name_tb.Name = "employee_name_tb";
            this.employee_name_tb.Size = new System.Drawing.Size(200, 23);
            this.employee_name_tb.TabIndex = 39;
            // 
            // employee_name_lbl
            // 
            this.employee_name_lbl.AutoSize = true;
            this.employee_name_lbl.Location = new System.Drawing.Point(207, 103);
            this.employee_name_lbl.Name = "employee_name_lbl";
            this.employee_name_lbl.Size = new System.Drawing.Size(39, 15);
            this.employee_name_lbl.TabIndex = 40;
            this.employee_name_lbl.Text = "Name";
            // 
            // choose_button
            // 
            this.choose_button.Location = new System.Drawing.Point(545, 30);
            this.choose_button.Name = "choose_button";
            this.choose_button.Size = new System.Drawing.Size(75, 23);
            this.choose_button.TabIndex = 49;
            this.choose_button.Text = "Choose";
            this.choose_button.UseVisualStyleBackColor = true;
            this.choose_button.Click += new System.EventHandler(this.choose_button_Click);
            // 
            // name_combob
            // 
            this.name_combob.FormattingEnabled = true;
            this.name_combob.Location = new System.Drawing.Point(330, 100);
            this.name_combob.Name = "name_combob";
            this.name_combob.Size = new System.Drawing.Size(219, 23);
            this.name_combob.TabIndex = 61;
            this.name_combob.Text = "choose the manager";
            // 
            // resultsDataGrid
            // 
            this.resultsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsDataGrid.Enabled = false;
            this.resultsDataGrid.Location = new System.Drawing.Point(25, 129);
            this.resultsDataGrid.Name = "resultsDataGrid";
            this.resultsDataGrid.RowHeadersWidth = 51;
            this.resultsDataGrid.RowTemplate.Height = 25;
            this.resultsDataGrid.Size = new System.Drawing.Size(751, 232);
            this.resultsDataGrid.TabIndex = 63;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(316, 380);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(139, 47);
            this.add_button.TabIndex = 64;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // managing_managers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(178)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.choose_button);
            this.Controls.Add(this.managing_employee_functionality_combob);
            this.Controls.Add(this.remove_button);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.add_update_panel);
            this.Controls.Add(this.employee_name_tb);
            this.Controls.Add(this.employee_name_lbl);
            this.Controls.Add(this.name_combob);
            this.Controls.Add(this.resultsDataGrid);
            this.Name = "managing_managers";
            this.Text = "managing_managers";
            this.Load += new System.EventHandler(this.managing_managers_Load);
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
        private TextBox manager_password_tb;
        private TextBox manager_email_tb;
        private Label receptionist_email_lbl;
        private Label receptionist_password_lbl;
        private TextBox employee_name_tb;
        private Label employee_name_lbl;
        private Button choose_button;
        private ComboBox name_combob;
        private DataGridView resultsDataGrid;
        private Button add_button;
    }
}