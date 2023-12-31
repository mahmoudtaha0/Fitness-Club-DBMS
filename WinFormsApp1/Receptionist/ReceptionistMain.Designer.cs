using System.Windows.Forms;
namespace Receptionist
{
    partial class ReceptionistMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceptionistMain));
            this.trainees_button = new System.Windows.Forms.Button();
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.financeButton = new System.Windows.Forms.Button();
            this.trainersPanel = new System.Windows.Forms.Panel();
            this.assignTrainersButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.trainersButton = new System.Windows.Forms.Button();
            this.respondPanel = new System.Windows.Forms.Panel();
            this.requestButton = new System.Windows.Forms.Button();
            this.traineesPanel = new System.Windows.Forms.Panel();
            this.lockersButton = new System.Windows.Forms.Button();
            this.programsButton = new System.Windows.Forms.Button();
            this.invitationsButton = new System.Windows.Forms.Button();
            this.membershipsButton = new System.Windows.Forms.Button();
            this.userInfoPanel = new System.Windows.Forms.Panel();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.formName = new System.Windows.Forms.Label();
            this.managePanelAniamtion = new System.Windows.Forms.Timer(this.components);
            this.viewPanelAniamtion = new System.Windows.Forms.Timer(this.components);
            this.loadedFormPanel = new System.Windows.Forms.Panel();
            this.settingsButton = new System.Windows.Forms.Button();
            this.navigationPanel.SuspendLayout();
            this.trainersPanel.SuspendLayout();
            this.respondPanel.SuspendLayout();
            this.traineesPanel.SuspendLayout();
            this.userInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // trainees_button
            // 
            this.trainees_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(81)))), ((int)(((byte)(49)))));
            this.trainees_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.trainees_button.FlatAppearance.BorderSize = 0;
            this.trainees_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trainees_button.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.trainees_button.ForeColor = System.Drawing.Color.White;
            this.trainees_button.Image = ((System.Drawing.Image)(resources.GetObject("trainees_button.Image")));
            this.trainees_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.trainees_button.Location = new System.Drawing.Point(0, 0);
            this.trainees_button.Margin = new System.Windows.Forms.Padding(0);
            this.trainees_button.MinimumSize = new System.Drawing.Size(250, 45);
            this.trainees_button.Name = "trainees_button";
            this.trainees_button.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.trainees_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trainees_button.Size = new System.Drawing.Size(250, 45);
            this.trainees_button.TabIndex = 1;
            this.trainees_button.Text = "Trainees";
            this.trainees_button.UseVisualStyleBackColor = false;
            this.trainees_button.Click += new System.EventHandler(this.trainees_button_Click);
            // 
            // navigationPanel
            // 
            this.navigationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(81)))), ((int)(((byte)(49)))));
            this.navigationPanel.Controls.Add(this.settingsButton);
            this.navigationPanel.Controls.Add(this.financeButton);
            this.navigationPanel.Controls.Add(this.trainersPanel);
            this.navigationPanel.Controls.Add(this.respondPanel);
            this.navigationPanel.Controls.Add(this.traineesPanel);
            this.navigationPanel.Controls.Add(this.userInfoPanel);
            this.navigationPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPanel.Location = new System.Drawing.Point(0, 0);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(250, 703);
            this.navigationPanel.TabIndex = 6;
            // 
            // financeButton
            // 
            this.financeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(81)))), ((int)(((byte)(49)))));
            this.financeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.financeButton.FlatAppearance.BorderSize = 0;
            this.financeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.financeButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.financeButton.ForeColor = System.Drawing.Color.White;
            this.financeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.financeButton.Location = new System.Drawing.Point(0, 525);
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
            // trainersPanel
            // 
            this.trainersPanel.Controls.Add(this.assignTrainersButton);
            this.trainersPanel.Controls.Add(this.loginButton);
            this.trainersPanel.Controls.Add(this.trainersButton);
            this.trainersPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.trainersPanel.Location = new System.Drawing.Point(0, 400);
            this.trainersPanel.MaximumSize = new System.Drawing.Size(250, 125);
            this.trainersPanel.MinimumSize = new System.Drawing.Size(250, 45);
            this.trainersPanel.Name = "trainersPanel";
            this.trainersPanel.Size = new System.Drawing.Size(250, 125);
            this.trainersPanel.TabIndex = 4;
            // 
            // assignTrainersButton
            // 
            this.assignTrainersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(108)))), ((int)(((byte)(54)))));
            this.assignTrainersButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.assignTrainersButton.FlatAppearance.BorderSize = 0;
            this.assignTrainersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assignTrainersButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.assignTrainersButton.ForeColor = System.Drawing.Color.White;
            this.assignTrainersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.assignTrainersButton.Location = new System.Drawing.Point(0, 85);
            this.assignTrainersButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.assignTrainersButton.Name = "assignTrainersButton";
            this.assignTrainersButton.Padding = new System.Windows.Forms.Padding(100, 0, 10, 0);
            this.assignTrainersButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.assignTrainersButton.Size = new System.Drawing.Size(250, 40);
            this.assignTrainersButton.TabIndex = 3;
            this.assignTrainersButton.Text = "Assign Trainers";
            this.assignTrainersButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.assignTrainersButton.UseVisualStyleBackColor = false;
            this.assignTrainersButton.Click += new System.EventHandler(this.assignTrainersButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(108)))), ((int)(((byte)(54)))));
            this.loginButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginButton.Location = new System.Drawing.Point(0, 45);
            this.loginButton.Margin = new System.Windows.Forms.Padding(0);
            this.loginButton.Name = "loginButton";
            this.loginButton.Padding = new System.Windows.Forms.Padding(100, 0, 10, 0);
            this.loginButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.loginButton.Size = new System.Drawing.Size(250, 40);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "Login";
            this.loginButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // trainersButton
            // 
            this.trainersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(81)))), ((int)(((byte)(49)))));
            this.trainersButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.trainersButton.FlatAppearance.BorderSize = 0;
            this.trainersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trainersButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.trainersButton.ForeColor = System.Drawing.Color.White;
            this.trainersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.trainersButton.Location = new System.Drawing.Point(0, 0);
            this.trainersButton.Margin = new System.Windows.Forms.Padding(0);
            this.trainersButton.MinimumSize = new System.Drawing.Size(250, 45);
            this.trainersButton.Name = "trainersButton";
            this.trainersButton.Padding = new System.Windows.Forms.Padding(10, 2, 10, 0);
            this.trainersButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trainersButton.Size = new System.Drawing.Size(250, 45);
            this.trainersButton.TabIndex = 0;
            this.trainersButton.Text = "Trainers";
            this.trainersButton.UseVisualStyleBackColor = false;
            this.trainersButton.Click += new System.EventHandler(this.trainers_button_Click);
            // 
            // respondPanel
            // 
            this.respondPanel.Controls.Add(this.requestButton);
            this.respondPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.respondPanel.Location = new System.Drawing.Point(0, 355);
            this.respondPanel.MaximumSize = new System.Drawing.Size(250, 45);
            this.respondPanel.MinimumSize = new System.Drawing.Size(250, 45);
            this.respondPanel.Name = "respondPanel";
            this.respondPanel.Size = new System.Drawing.Size(250, 45);
            this.respondPanel.TabIndex = 3;
            // 
            // requestButton
            // 
            this.requestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(81)))), ((int)(((byte)(49)))));
            this.requestButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.requestButton.FlatAppearance.BorderSize = 0;
            this.requestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.requestButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.requestButton.ForeColor = System.Drawing.Color.White;
            this.requestButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.requestButton.Location = new System.Drawing.Point(0, 0);
            this.requestButton.Margin = new System.Windows.Forms.Padding(0);
            this.requestButton.MinimumSize = new System.Drawing.Size(250, 45);
            this.requestButton.Name = "requestButton";
            this.requestButton.Padding = new System.Windows.Forms.Padding(10, 2, 10, 0);
            this.requestButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.requestButton.Size = new System.Drawing.Size(250, 45);
            this.requestButton.TabIndex = 0;
            this.requestButton.Text = "Request";
            this.requestButton.UseVisualStyleBackColor = false;
            this.requestButton.Click += new System.EventHandler(this.request_button_Click);
            // 
            // traineesPanel
            // 
            this.traineesPanel.Controls.Add(this.lockersButton);
            this.traineesPanel.Controls.Add(this.programsButton);
            this.traineesPanel.Controls.Add(this.invitationsButton);
            this.traineesPanel.Controls.Add(this.membershipsButton);
            this.traineesPanel.Controls.Add(this.trainees_button);
            this.traineesPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.traineesPanel.Location = new System.Drawing.Point(0, 150);
            this.traineesPanel.MaximumSize = new System.Drawing.Size(250, 205);
            this.traineesPanel.MinimumSize = new System.Drawing.Size(250, 45);
            this.traineesPanel.Name = "traineesPanel";
            this.traineesPanel.Size = new System.Drawing.Size(250, 205);
            this.traineesPanel.TabIndex = 2;
            // 
            // lockersButton
            // 
            this.lockersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(108)))), ((int)(((byte)(54)))));
            this.lockersButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.lockersButton.FlatAppearance.BorderSize = 0;
            this.lockersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lockersButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lockersButton.ForeColor = System.Drawing.Color.White;
            this.lockersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lockersButton.Location = new System.Drawing.Point(0, 165);
            this.lockersButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lockersButton.Name = "lockersButton";
            this.lockersButton.Padding = new System.Windows.Forms.Padding(40, 0, 10, 0);
            this.lockersButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lockersButton.Size = new System.Drawing.Size(250, 40);
            this.lockersButton.TabIndex = 5;
            this.lockersButton.Text = "          Lockers";
            this.lockersButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lockersButton.UseVisualStyleBackColor = false;
            this.lockersButton.Click += new System.EventHandler(this.lockersButton_Click);
            // 
            // programsButton
            // 
            this.programsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(108)))), ((int)(((byte)(54)))));
            this.programsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.programsButton.FlatAppearance.BorderSize = 0;
            this.programsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.programsButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.programsButton.ForeColor = System.Drawing.Color.White;
            this.programsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.programsButton.Location = new System.Drawing.Point(0, 125);
            this.programsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.programsButton.Name = "programsButton";
            this.programsButton.Padding = new System.Windows.Forms.Padding(40, 0, 10, 0);
            this.programsButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.programsButton.Size = new System.Drawing.Size(250, 40);
            this.programsButton.TabIndex = 4;
            this.programsButton.Text = "          Programs";
            this.programsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.programsButton.UseVisualStyleBackColor = false;
            this.programsButton.Click += new System.EventHandler(this.programsButton_Click);
            // 
            // invitationsButton
            // 
            this.invitationsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(108)))), ((int)(((byte)(54)))));
            this.invitationsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.invitationsButton.FlatAppearance.BorderSize = 0;
            this.invitationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.invitationsButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.invitationsButton.ForeColor = System.Drawing.Color.White;
            this.invitationsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.invitationsButton.Location = new System.Drawing.Point(0, 85);
            this.invitationsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.invitationsButton.Name = "invitationsButton";
            this.invitationsButton.Padding = new System.Windows.Forms.Padding(40, 0, 10, 0);
            this.invitationsButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.invitationsButton.Size = new System.Drawing.Size(250, 40);
            this.invitationsButton.TabIndex = 3;
            this.invitationsButton.Text = "          Invitations";
            this.invitationsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.invitationsButton.UseVisualStyleBackColor = false;
            this.invitationsButton.Click += new System.EventHandler(this.invitationsButton_Click);
            // 
            // membershipsButton
            // 
            this.membershipsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(108)))), ((int)(((byte)(54)))));
            this.membershipsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.membershipsButton.FlatAppearance.BorderSize = 0;
            this.membershipsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.membershipsButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.membershipsButton.ForeColor = System.Drawing.Color.White;
            this.membershipsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.membershipsButton.Location = new System.Drawing.Point(0, 45);
            this.membershipsButton.Margin = new System.Windows.Forms.Padding(0);
            this.membershipsButton.Name = "membershipsButton";
            this.membershipsButton.Padding = new System.Windows.Forms.Padding(40, 0, 10, 0);
            this.membershipsButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.membershipsButton.Size = new System.Drawing.Size(250, 40);
            this.membershipsButton.TabIndex = 2;
            this.membershipsButton.Text = "          Memberships";
            this.membershipsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.membershipsButton.UseVisualStyleBackColor = false;
            this.membershipsButton.Click += new System.EventHandler(this.membershipsButton_Click);
            // 
            // userInfoPanel
            // 
            this.userInfoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(81)))), ((int)(((byte)(49)))));
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
            this.formName.Size = new System.Drawing.Size(178, 54);
            this.formName.TabIndex = 0;
            this.formName.Text = "Trainees";
            // 
            // managePanelAniamtion
            // 
            this.managePanelAniamtion.Interval = 10;
            this.managePanelAniamtion.Tick += new System.EventHandler(this.traineesPanelAniamtion_Tick);
            // 
            // viewPanelAniamtion
            // 
            this.viewPanelAniamtion.Interval = 10;
            this.viewPanelAniamtion.Tick += new System.EventHandler(this.trainersPanelAniamtion_Tick);
            // 
            // loadedFormPanel
            // 
            this.loadedFormPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loadedFormPanel.Location = new System.Drawing.Point(250, 94);
            this.loadedFormPanel.Name = "loadedFormPanel";
            this.loadedFormPanel.Size = new System.Drawing.Size(914, 609);
            this.loadedFormPanel.TabIndex = 7;
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(81)))), ((int)(((byte)(49)))));
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
            this.settingsButton.TabIndex = 8;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // ReceptionistMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1164, 703);
            this.Controls.Add(this.loadedFormPanel);
            this.Controls.Add(this.formName);
            this.Controls.Add(this.navigationPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ReceptionistMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReceptionistMain_FormClosed);
            this.navigationPanel.ResumeLayout(false);
            this.trainersPanel.ResumeLayout(false);
            this.respondPanel.ResumeLayout(false);
            this.traineesPanel.ResumeLayout(false);
            this.userInfoPanel.ResumeLayout(false);
            this.userInfoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button trainees_button;
        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.Panel traineesPanel;
        private System.Windows.Forms.Button membershipsButton;
        private System.Windows.Forms.Button lockersButton;
        private System.Windows.Forms.Button programsButton;
        private System.Windows.Forms.Button invitationsButton;
        private System.Windows.Forms.Panel respondPanel;
        private System.Windows.Forms.Button requestButton;
        private System.Windows.Forms.Panel userInfoPanel;
        private System.Windows.Forms.Label formName;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Panel trainersPanel;
        private System.Windows.Forms.Button assignTrainersButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button trainersButton;
        private System.Windows.Forms.Timer managePanelAniamtion;
        private System.Windows.Forms.Timer viewPanelAniamtion;
        private System.Windows.Forms.Button financeButton;
        private System.Windows.Forms.Panel loadedFormPanel;
        private Button settingsButton;
    }
}