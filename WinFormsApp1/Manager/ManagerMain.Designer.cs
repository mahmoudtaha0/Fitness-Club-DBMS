namespace WinFormsApp1
{
    partial class ManagerMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerMain));
            this.manage_button = new System.Windows.Forms.Button();
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.settingsButton = new System.Windows.Forms.Button();
            this.financeButton = new System.Windows.Forms.Button();
            this.viewPanel = new System.Windows.Forms.Panel();
            this.statisticsButton = new System.Windows.Forms.Button();
            this.attendanceButton = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            this.respondPanel = new System.Windows.Forms.Panel();
            this.respondButton = new System.Windows.Forms.Button();
            this.managePanel = new System.Windows.Forms.Panel();
            this.salariesButton = new System.Windows.Forms.Button();
            this.devicesButton = new System.Windows.Forms.Button();
            this.managersButton = new System.Windows.Forms.Button();
            this.trainersButton = new System.Windows.Forms.Button();
            this.receptionistButton = new System.Windows.Forms.Button();
            this.userInfoPanel = new System.Windows.Forms.Panel();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.formName = new System.Windows.Forms.Label();
            this.managePanelAniamtion = new System.Windows.Forms.Timer(this.components);
            this.viewPanelAniamtion = new System.Windows.Forms.Timer(this.components);
            this.loadedFormPanel = new System.Windows.Forms.Panel();
            this.navigationPanel.SuspendLayout();
            this.viewPanel.SuspendLayout();
            this.respondPanel.SuspendLayout();
            this.managePanel.SuspendLayout();
            this.userInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // manage_button
            // 
            this.manage_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(106)))), ((int)(((byte)(135)))));
            this.manage_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.manage_button.FlatAppearance.BorderSize = 0;
            this.manage_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manage_button.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.manage_button.ForeColor = System.Drawing.Color.White;
            this.manage_button.Image = ((System.Drawing.Image)(resources.GetObject("manage_button.Image")));
            this.manage_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manage_button.Location = new System.Drawing.Point(0, 0);
            this.manage_button.Margin = new System.Windows.Forms.Padding(0);
            this.manage_button.MinimumSize = new System.Drawing.Size(250, 45);
            this.manage_button.Name = "manage_button";
            this.manage_button.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.manage_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.manage_button.Size = new System.Drawing.Size(250, 45);
            this.manage_button.TabIndex = 1;
            this.manage_button.Text = "Manage";
            this.manage_button.UseVisualStyleBackColor = false;
            this.manage_button.Click += new System.EventHandler(this.manage_button_Click);
            // 
            // navigationPanel
            // 
            this.navigationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(106)))), ((int)(((byte)(135)))));
            this.navigationPanel.Controls.Add(this.settingsButton);
            this.navigationPanel.Controls.Add(this.financeButton);
            this.navigationPanel.Controls.Add(this.viewPanel);
            this.navigationPanel.Controls.Add(this.respondPanel);
            this.navigationPanel.Controls.Add(this.managePanel);
            this.navigationPanel.Controls.Add(this.userInfoPanel);
            this.navigationPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPanel.Location = new System.Drawing.Point(0, 0);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(250, 703);
            this.navigationPanel.TabIndex = 6;
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(106)))), ((int)(((byte)(135)))));
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.settingsButton.ForeColor = System.Drawing.Color.White;
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.Location = new System.Drawing.Point(0, 658);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(0);
            this.settingsButton.MinimumSize = new System.Drawing.Size(250, 45);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Padding = new System.Windows.Forms.Padding(10, 2, 10, 0);
            this.settingsButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.settingsButton.Size = new System.Drawing.Size(250, 45);
            this.settingsButton.TabIndex = 1;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // financeButton
            // 
            this.financeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(106)))), ((int)(((byte)(135)))));
            this.financeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.financeButton.FlatAppearance.BorderSize = 0;
            this.financeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.financeButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.financeButton.ForeColor = System.Drawing.Color.White;
            this.financeButton.Image = ((System.Drawing.Image)(resources.GetObject("financeButton.Image")));
            this.financeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.financeButton.Location = new System.Drawing.Point(0, 285);
            this.financeButton.Margin = new System.Windows.Forms.Padding(0);
            this.financeButton.MinimumSize = new System.Drawing.Size(250, 45);
            this.financeButton.Name = "financeButton";
            this.financeButton.Padding = new System.Windows.Forms.Padding(10, 2, 10, 0);
            this.financeButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.financeButton.Size = new System.Drawing.Size(250, 45);
            this.financeButton.TabIndex = 7;
            this.financeButton.Text = "Finance";
            this.financeButton.UseVisualStyleBackColor = false;
            this.financeButton.Click += new System.EventHandler(this.financeButton_Click);
            // 
            // viewPanel
            // 
            this.viewPanel.Controls.Add(this.statisticsButton);
            this.viewPanel.Controls.Add(this.attendanceButton);
            this.viewPanel.Controls.Add(this.viewButton);
            this.viewPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewPanel.Location = new System.Drawing.Point(0, 240);
            this.viewPanel.MaximumSize = new System.Drawing.Size(250, 125);
            this.viewPanel.MinimumSize = new System.Drawing.Size(250, 45);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.Size = new System.Drawing.Size(250, 45);
            this.viewPanel.TabIndex = 4;
            // 
            // statisticsButton
            // 
            this.statisticsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(140)))));
            this.statisticsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.statisticsButton.FlatAppearance.BorderSize = 0;
            this.statisticsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statisticsButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statisticsButton.ForeColor = System.Drawing.Color.White;
            this.statisticsButton.Image = ((System.Drawing.Image)(resources.GetObject("statisticsButton.Image")));
            this.statisticsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statisticsButton.Location = new System.Drawing.Point(0, 85);
            this.statisticsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.statisticsButton.Name = "statisticsButton";
            this.statisticsButton.Padding = new System.Windows.Forms.Padding(40, 0, 10, 0);
            this.statisticsButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statisticsButton.Size = new System.Drawing.Size(250, 40);
            this.statisticsButton.TabIndex = 3;
            this.statisticsButton.Text = "          Statistics";
            this.statisticsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statisticsButton.UseVisualStyleBackColor = false;
            this.statisticsButton.Click += new System.EventHandler(this.statisticsButton_Click);
            // 
            // attendanceButton
            // 
            this.attendanceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(140)))));
            this.attendanceButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.attendanceButton.FlatAppearance.BorderSize = 0;
            this.attendanceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attendanceButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.attendanceButton.ForeColor = System.Drawing.Color.White;
            this.attendanceButton.Image = ((System.Drawing.Image)(resources.GetObject("attendanceButton.Image")));
            this.attendanceButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.attendanceButton.Location = new System.Drawing.Point(0, 45);
            this.attendanceButton.Margin = new System.Windows.Forms.Padding(0);
            this.attendanceButton.Name = "attendanceButton";
            this.attendanceButton.Padding = new System.Windows.Forms.Padding(40, 0, 10, 0);
            this.attendanceButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.attendanceButton.Size = new System.Drawing.Size(250, 40);
            this.attendanceButton.TabIndex = 1;
            this.attendanceButton.Text = "          Attendance";
            this.attendanceButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.attendanceButton.UseVisualStyleBackColor = false;
            this.attendanceButton.Click += new System.EventHandler(this.attendanceButton_Click);
            // 
            // viewButton
            // 
            this.viewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(106)))), ((int)(((byte)(135)))));
            this.viewButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewButton.FlatAppearance.BorderSize = 0;
            this.viewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.viewButton.ForeColor = System.Drawing.Color.White;
            this.viewButton.Image = ((System.Drawing.Image)(resources.GetObject("viewButton.Image")));
            this.viewButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewButton.Location = new System.Drawing.Point(0, 0);
            this.viewButton.Margin = new System.Windows.Forms.Padding(0);
            this.viewButton.MinimumSize = new System.Drawing.Size(250, 45);
            this.viewButton.Name = "viewButton";
            this.viewButton.Padding = new System.Windows.Forms.Padding(10, 2, 10, 0);
            this.viewButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.viewButton.Size = new System.Drawing.Size(250, 45);
            this.viewButton.TabIndex = 0;
            this.viewButton.Text = "View";
            this.viewButton.UseVisualStyleBackColor = false;
            this.viewButton.Click += new System.EventHandler(this.view_button_Click);
            // 
            // respondPanel
            // 
            this.respondPanel.Controls.Add(this.respondButton);
            this.respondPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.respondPanel.Location = new System.Drawing.Point(0, 195);
            this.respondPanel.MaximumSize = new System.Drawing.Size(250, 45);
            this.respondPanel.MinimumSize = new System.Drawing.Size(250, 45);
            this.respondPanel.Name = "respondPanel";
            this.respondPanel.Size = new System.Drawing.Size(250, 45);
            this.respondPanel.TabIndex = 3;
            // 
            // respondButton
            // 
            this.respondButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(106)))), ((int)(((byte)(135)))));
            this.respondButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.respondButton.FlatAppearance.BorderSize = 0;
            this.respondButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.respondButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.respondButton.ForeColor = System.Drawing.Color.White;
            this.respondButton.Image = ((System.Drawing.Image)(resources.GetObject("respondButton.Image")));
            this.respondButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.respondButton.Location = new System.Drawing.Point(0, 0);
            this.respondButton.Margin = new System.Windows.Forms.Padding(0);
            this.respondButton.MinimumSize = new System.Drawing.Size(250, 45);
            this.respondButton.Name = "respondButton";
            this.respondButton.Padding = new System.Windows.Forms.Padding(10, 2, 10, 0);
            this.respondButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.respondButton.Size = new System.Drawing.Size(250, 45);
            this.respondButton.TabIndex = 0;
            this.respondButton.Text = "Respond";
            this.respondButton.UseVisualStyleBackColor = false;
            this.respondButton.Click += new System.EventHandler(this.respond_button_Click);
            // 
            // managePanel
            // 
            this.managePanel.Controls.Add(this.salariesButton);
            this.managePanel.Controls.Add(this.devicesButton);
            this.managePanel.Controls.Add(this.managersButton);
            this.managePanel.Controls.Add(this.trainersButton);
            this.managePanel.Controls.Add(this.receptionistButton);
            this.managePanel.Controls.Add(this.manage_button);
            this.managePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.managePanel.Location = new System.Drawing.Point(0, 150);
            this.managePanel.MaximumSize = new System.Drawing.Size(250, 245);
            this.managePanel.MinimumSize = new System.Drawing.Size(250, 45);
            this.managePanel.Name = "managePanel";
            this.managePanel.Size = new System.Drawing.Size(250, 45);
            this.managePanel.TabIndex = 2;
            // 
            // salariesButton
            // 
            this.salariesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(140)))));
            this.salariesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.salariesButton.FlatAppearance.BorderSize = 0;
            this.salariesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salariesButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.salariesButton.ForeColor = System.Drawing.Color.White;
            this.salariesButton.Image = ((System.Drawing.Image)(resources.GetObject("salariesButton.Image")));
            this.salariesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salariesButton.Location = new System.Drawing.Point(0, 205);
            this.salariesButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.salariesButton.Name = "salariesButton";
            this.salariesButton.Padding = new System.Windows.Forms.Padding(40, 0, 10, 0);
            this.salariesButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.salariesButton.Size = new System.Drawing.Size(250, 40);
            this.salariesButton.TabIndex = 6;
            this.salariesButton.Text = "          Salaries";
            this.salariesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salariesButton.UseVisualStyleBackColor = false;
            this.salariesButton.Click += new System.EventHandler(this.salariesButton_Click);
            // 
            // devicesButton
            // 
            this.devicesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(140)))));
            this.devicesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.devicesButton.FlatAppearance.BorderSize = 0;
            this.devicesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.devicesButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.devicesButton.ForeColor = System.Drawing.Color.White;
            this.devicesButton.Image = ((System.Drawing.Image)(resources.GetObject("devicesButton.Image")));
            this.devicesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.devicesButton.Location = new System.Drawing.Point(0, 165);
            this.devicesButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.devicesButton.Name = "devicesButton";
            this.devicesButton.Padding = new System.Windows.Forms.Padding(40, 0, 10, 0);
            this.devicesButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.devicesButton.Size = new System.Drawing.Size(250, 40);
            this.devicesButton.TabIndex = 5;
            this.devicesButton.Text = "          Devices";
            this.devicesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.devicesButton.UseVisualStyleBackColor = false;
            this.devicesButton.Click += new System.EventHandler(this.devicesButton_Click);
            // 
            // managersButton
            // 
            this.managersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(140)))));
            this.managersButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.managersButton.FlatAppearance.BorderSize = 0;
            this.managersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.managersButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.managersButton.ForeColor = System.Drawing.Color.White;
            this.managersButton.Image = ((System.Drawing.Image)(resources.GetObject("managersButton.Image")));
            this.managersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.managersButton.Location = new System.Drawing.Point(0, 125);
            this.managersButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.managersButton.Name = "managersButton";
            this.managersButton.Padding = new System.Windows.Forms.Padding(40, 0, 10, 0);
            this.managersButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.managersButton.Size = new System.Drawing.Size(250, 40);
            this.managersButton.TabIndex = 4;
            this.managersButton.Text = "          Managers";
            this.managersButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.managersButton.UseVisualStyleBackColor = false;
            this.managersButton.Click += new System.EventHandler(this.managersButton_Click);
            // 
            // trainersButton
            // 
            this.trainersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(140)))));
            this.trainersButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.trainersButton.FlatAppearance.BorderSize = 0;
            this.trainersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trainersButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.trainersButton.ForeColor = System.Drawing.Color.White;
            this.trainersButton.Image = ((System.Drawing.Image)(resources.GetObject("trainersButton.Image")));
            this.trainersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.trainersButton.Location = new System.Drawing.Point(0, 85);
            this.trainersButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trainersButton.Name = "trainersButton";
            this.trainersButton.Padding = new System.Windows.Forms.Padding(40, 0, 10, 0);
            this.trainersButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trainersButton.Size = new System.Drawing.Size(250, 40);
            this.trainersButton.TabIndex = 3;
            this.trainersButton.Text = "          Trainers";
            this.trainersButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.trainersButton.UseVisualStyleBackColor = false;
            this.trainersButton.Click += new System.EventHandler(this.trainersButton_Click);
            // 
            // receptionistButton
            // 
            this.receptionistButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(140)))));
            this.receptionistButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.receptionistButton.FlatAppearance.BorderSize = 0;
            this.receptionistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receptionistButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.receptionistButton.ForeColor = System.Drawing.Color.White;
            this.receptionistButton.Image = ((System.Drawing.Image)(resources.GetObject("receptionistButton.Image")));
            this.receptionistButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.receptionistButton.Location = new System.Drawing.Point(0, 45);
            this.receptionistButton.Margin = new System.Windows.Forms.Padding(0);
            this.receptionistButton.Name = "receptionistButton";
            this.receptionistButton.Padding = new System.Windows.Forms.Padding(40, 0, 10, 0);
            this.receptionistButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.receptionistButton.Size = new System.Drawing.Size(250, 40);
            this.receptionistButton.TabIndex = 2;
            this.receptionistButton.Text = "          Receptionisit";
            this.receptionistButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.receptionistButton.UseVisualStyleBackColor = false;
            this.receptionistButton.Click += new System.EventHandler(this.receptionistButton_Click);
            // 
            // userInfoPanel
            // 
            this.userInfoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(106)))), ((int)(((byte)(135)))));
            this.userInfoPanel.Controls.Add(this.welcomeLabel);
            this.userInfoPanel.Controls.Add(this.usernameLabel);
            this.userInfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userInfoPanel.Location = new System.Drawing.Point(0, 0);
            this.userInfoPanel.Name = "userInfoPanel";
            this.userInfoPanel.Size = new System.Drawing.Size(250, 150);
            this.userInfoPanel.TabIndex = 0;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.welcomeLabel.ForeColor = System.Drawing.Color.White;
            this.welcomeLabel.Location = new System.Drawing.Point(12, 74);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(84, 23);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usernameLabel.ForeColor = System.Drawing.Color.White;
            this.usernameLabel.Location = new System.Drawing.Point(12, 97);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(158, 41);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username";
            // 
            // formName
            // 
            this.formName.AutoSize = true;
            this.formName.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.formName.Location = new System.Drawing.Point(270, 19);
            this.formName.Name = "formName";
            this.formName.Size = new System.Drawing.Size(176, 54);
            this.formName.TabIndex = 0;
            this.formName.Text = "Manage";
            // 
            // managePanelAniamtion
            // 
            this.managePanelAniamtion.Interval = 10;
            this.managePanelAniamtion.Tick += new System.EventHandler(this.managePanelAniamtion_Tick);
            // 
            // viewPanelAniamtion
            // 
            this.viewPanelAniamtion.Interval = 10;
            this.viewPanelAniamtion.Tick += new System.EventHandler(this.viewPanelAniamtion_Tick);
            // 
            // loadedFormPanel
            // 
            this.loadedFormPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loadedFormPanel.Location = new System.Drawing.Point(250, 94);
            this.loadedFormPanel.Name = "loadedFormPanel";
            this.loadedFormPanel.Size = new System.Drawing.Size(914, 609);
            this.loadedFormPanel.TabIndex = 7;
            // 
            // ManagerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1164, 703);
            this.Controls.Add(this.loadedFormPanel);
            this.Controls.Add(this.formName);
            this.Controls.Add(this.navigationPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ManagerMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManagerMain_FormClosed);
            this.navigationPanel.ResumeLayout(false);
            this.viewPanel.ResumeLayout(false);
            this.respondPanel.ResumeLayout(false);
            this.managePanel.ResumeLayout(false);
            this.userInfoPanel.ResumeLayout(false);
            this.userInfoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button manage_button;
        private Panel navigationPanel;
        private Panel managePanel;
        private Button receptionistButton;
        private Button devicesButton;
        private Button managersButton;
        private Button trainersButton;
        private Panel respondPanel;
        private Button respondButton;
        private Panel userInfoPanel;
        private Label formName;
        private Label usernameLabel;
        private Label welcomeLabel;
        private Button salariesButton;
        private Panel viewPanel;
        private Button statisticsButton;
        private Button attendanceButton;
        private Button viewButton;
        private System.Windows.Forms.Timer managePanelAniamtion;
        private System.Windows.Forms.Timer viewPanelAniamtion;
        private Button financeButton;
        private Panel loadedFormPanel;
        private Button settingsButton;
    }
}