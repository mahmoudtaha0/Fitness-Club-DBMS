
namespace Receptionist
{
    partial class Login_Trainers
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
            this.groupBox_Trainer = new System.Windows.Forms.GroupBox();
            this.textBoxName_Trainer = new System.Windows.Forms.TextBox();
            this.textBox_SSN_Trainer = new System.Windows.Forms.TextBox();
            this.textBox_Search_Trainer = new System.Windows.Forms.TextBox();
            this.label_Search = new System.Windows.Forms.Label();
            this.dataGridViewTrainer = new System.Windows.Forms.DataGridView();
            this.label_SSN = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.groupBox_Attendance = new System.Windows.Forms.GroupBox();
            this.button_Submit = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.comboBox_Type = new System.Windows.Forms.ComboBox();
            this.label_Type = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox_Trainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrainer)).BeginInit();
            this.groupBox_Attendance.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Trainer
            // 
            this.groupBox_Trainer.Controls.Add(this.textBoxName_Trainer);
            this.groupBox_Trainer.Controls.Add(this.textBox_SSN_Trainer);
            this.groupBox_Trainer.Controls.Add(this.textBox_Search_Trainer);
            this.groupBox_Trainer.Controls.Add(this.label_Search);
            this.groupBox_Trainer.Controls.Add(this.dataGridViewTrainer);
            this.groupBox_Trainer.Controls.Add(this.label_SSN);
            this.groupBox_Trainer.Controls.Add(this.label_Name);
            this.groupBox_Trainer.Location = new System.Drawing.Point(12, 72);
            this.groupBox_Trainer.Name = "groupBox_Trainer";
            this.groupBox_Trainer.Size = new System.Drawing.Size(905, 190);
            this.groupBox_Trainer.TabIndex = 2;
            this.groupBox_Trainer.TabStop = false;
            this.groupBox_Trainer.Text = "Trainer";
            // 
            // textBoxName_Trainer
            // 
            this.textBoxName_Trainer.Enabled = false;
            this.textBoxName_Trainer.Location = new System.Drawing.Point(114, 154);
            this.textBoxName_Trainer.Name = "textBoxName_Trainer";
            this.textBoxName_Trainer.Size = new System.Drawing.Size(219, 26);
            this.textBoxName_Trainer.TabIndex = 3;
            // 
            // textBox_SSN_Trainer
            // 
            this.textBox_SSN_Trainer.Enabled = false;
            this.textBox_SSN_Trainer.Location = new System.Drawing.Point(114, 105);
            this.textBox_SSN_Trainer.Name = "textBox_SSN_Trainer";
            this.textBox_SSN_Trainer.Size = new System.Drawing.Size(219, 26);
            this.textBox_SSN_Trainer.TabIndex = 3;
            // 
            // textBox_Search_Trainer
            // 
            this.textBox_Search_Trainer.Location = new System.Drawing.Point(114, 52);
            this.textBox_Search_Trainer.Name = "textBox_Search_Trainer";
            this.textBox_Search_Trainer.Size = new System.Drawing.Size(219, 26);
            this.textBox_Search_Trainer.TabIndex = 3;
            this.textBox_Search_Trainer.TextChanged += new System.EventHandler(this.textBox_Search_Trainer_TextChanged);
            // 
            // label_Search
            // 
            this.label_Search.AutoSize = true;
            this.label_Search.BackColor = System.Drawing.Color.Transparent;
            this.label_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Search.Location = new System.Drawing.Point(6, 53);
            this.label_Search.Name = "label_Search";
            this.label_Search.Size = new System.Drawing.Size(75, 25);
            this.label_Search.TabIndex = 2;
            this.label_Search.Text = "Search";
            // 
            // dataGridViewTrainer
            // 
            this.dataGridViewTrainer.AllowUserToAddRows = false;
            this.dataGridViewTrainer.AllowUserToDeleteRows = false;
            this.dataGridViewTrainer.AllowUserToResizeColumns = false;
            this.dataGridViewTrainer.AllowUserToResizeRows = false;
            this.dataGridViewTrainer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrainer.Location = new System.Drawing.Point(383, 52);
            this.dataGridViewTrainer.MultiSelect = false;
            this.dataGridViewTrainer.Name = "dataGridViewTrainer";
            this.dataGridViewTrainer.ReadOnly = true;
            this.dataGridViewTrainer.RowHeadersWidth = 62;
            this.dataGridViewTrainer.RowTemplate.Height = 28;
            this.dataGridViewTrainer.Size = new System.Drawing.Size(506, 128);
            this.dataGridViewTrainer.TabIndex = 1;
            this.dataGridViewTrainer.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewTrainer_RowHeaderMouseClick);
            // 
            // label_SSN
            // 
            this.label_SSN.AutoSize = true;
            this.label_SSN.BackColor = System.Drawing.Color.Transparent;
            this.label_SSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SSN.Location = new System.Drawing.Point(6, 106);
            this.label_SSN.Name = "label_SSN";
            this.label_SSN.Size = new System.Drawing.Size(54, 25);
            this.label_SSN.TabIndex = 0;
            this.label_SSN.Text = "SSN";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.BackColor = System.Drawing.Color.Transparent;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(6, 154);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(64, 25);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Name";
            // 
            // groupBox_Attendance
            // 
            this.groupBox_Attendance.Controls.Add(this.button_Submit);
            this.groupBox_Attendance.Controls.Add(this.button_Clear);
            this.groupBox_Attendance.Controls.Add(this.comboBox_Type);
            this.groupBox_Attendance.Controls.Add(this.label_Type);
            this.groupBox_Attendance.Controls.Add(this.label_Date);
            this.groupBox_Attendance.Controls.Add(this.dateTimePicker2);
            this.groupBox_Attendance.Location = new System.Drawing.Point(12, 280);
            this.groupBox_Attendance.Name = "groupBox_Attendance";
            this.groupBox_Attendance.Size = new System.Drawing.Size(899, 209);
            this.groupBox_Attendance.TabIndex = 3;
            this.groupBox_Attendance.TabStop = false;
            this.groupBox_Attendance.Text = "Attendance";
            // 
            // button_Submit
            // 
            this.button_Submit.BackColor = System.Drawing.Color.RosyBrown;
            this.button_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Submit.ForeColor = System.Drawing.Color.White;
            this.button_Submit.Location = new System.Drawing.Point(383, 101);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(115, 47);
            this.button_Submit.TabIndex = 12;
            this.button_Submit.Text = "Submit";
            this.button_Submit.UseVisualStyleBackColor = false;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.BackColor = System.Drawing.Color.RosyBrown;
            this.button_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clear.ForeColor = System.Drawing.Color.White;
            this.button_Clear.Location = new System.Drawing.Point(383, 41);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(115, 47);
            this.button_Clear.TabIndex = 11;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // comboBox_Type
            // 
            this.comboBox_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Type.FormattingEnabled = true;
            this.comboBox_Type.Items.AddRange(new object[] {
            "Early",
            "On time",
            "Late",
            "Absent"});
            this.comboBox_Type.Location = new System.Drawing.Point(114, 114);
            this.comboBox_Type.Name = "comboBox_Type";
            this.comboBox_Type.Size = new System.Drawing.Size(219, 28);
            this.comboBox_Type.TabIndex = 10;
            // 
            // label_Type
            // 
            this.label_Type.AutoSize = true;
            this.label_Type.BackColor = System.Drawing.Color.Transparent;
            this.label_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Type.Location = new System.Drawing.Point(6, 117);
            this.label_Type.Name = "label_Type";
            this.label_Type.Size = new System.Drawing.Size(57, 25);
            this.label_Type.TabIndex = 9;
            this.label_Type.Text = "Type";
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.BackColor = System.Drawing.Color.Transparent;
            this.label_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Date.Location = new System.Drawing.Point(6, 52);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(53, 25);
            this.label_Date.TabIndex = 8;
            this.label_Date.Text = "Date";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(114, 52);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(219, 26);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // Login_Trainers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 521);
            this.Controls.Add(this.groupBox_Attendance);
            this.Controls.Add(this.groupBox_Trainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_Trainers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_Trainers";
            //this.Load += new System.EventHandler(this.Login_Trainers_Load);
            this.groupBox_Trainer.ResumeLayout(false);
            this.groupBox_Trainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrainer)).EndInit();
            this.groupBox_Attendance.ResumeLayout(false);
            this.groupBox_Attendance.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Trainer;
        private System.Windows.Forms.TextBox textBoxName_Trainer;
        private System.Windows.Forms.TextBox textBox_SSN_Trainer;
        private System.Windows.Forms.TextBox textBox_Search_Trainer;
        private System.Windows.Forms.Label label_Search;
        private System.Windows.Forms.DataGridView dataGridViewTrainer;
        private System.Windows.Forms.Label label_SSN;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.GroupBox groupBox_Attendance;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox_Type;
        private System.Windows.Forms.Label label_Type;
        private System.Windows.Forms.Button button_Submit;
        private System.Windows.Forms.Button button_Clear;
    }
}