
namespace Receptionist
{
    partial class Assign_Trainers
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
            this.label_Trainee_Name = new System.Windows.Forms.Label();
            this.grpbx_Trainee = new System.Windows.Forms.GroupBox();
            this.textBox_Name_Trainee = new System.Windows.Forms.TextBox();
            this.textBox_SSN_Trainee = new System.Windows.Forms.TextBox();
            this.textBox_Search_Trainee = new System.Windows.Forms.TextBox();
            this.label_Search = new System.Windows.Forms.Label();
            this.dataGridView_Trainee = new System.Windows.Forms.DataGridView();
            this.label_SSN = new System.Windows.Forms.Label();
            this.groupBox_Trainer = new System.Windows.Forms.GroupBox();
            this.textBoxName_Trainer = new System.Windows.Forms.TextBox();
            this.textBox_SSN_Trainer = new System.Windows.Forms.TextBox();
            this.textBox_Search_Trainer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTrainer = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Assign = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.grpbx_Trainee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Trainee)).BeginInit();
            this.groupBox_Trainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrainer)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Trainee_Name
            // 
            this.label_Trainee_Name.AutoSize = true;
            this.label_Trainee_Name.BackColor = System.Drawing.Color.Transparent;
            this.label_Trainee_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Trainee_Name.Location = new System.Drawing.Point(6, 154);
            this.label_Trainee_Name.Name = "label_Trainee_Name";
            this.label_Trainee_Name.Size = new System.Drawing.Size(64, 25);
            this.label_Trainee_Name.TabIndex = 0;
            this.label_Trainee_Name.Text = "Name";
            // 
            // grpbx_Trainee
            // 
            this.grpbx_Trainee.Controls.Add(this.textBox_Name_Trainee);
            this.grpbx_Trainee.Controls.Add(this.textBox_SSN_Trainee);
            this.grpbx_Trainee.Controls.Add(this.textBox_Search_Trainee);
            this.grpbx_Trainee.Controls.Add(this.label_Search);
            this.grpbx_Trainee.Controls.Add(this.dataGridView_Trainee);
            this.grpbx_Trainee.Controls.Add(this.label_SSN);
            this.grpbx_Trainee.Controls.Add(this.label_Trainee_Name);
            this.grpbx_Trainee.Location = new System.Drawing.Point(12, 61);
            this.grpbx_Trainee.Name = "grpbx_Trainee";
            this.grpbx_Trainee.Size = new System.Drawing.Size(905, 199);
            this.grpbx_Trainee.TabIndex = 1;
            this.grpbx_Trainee.TabStop = false;
            this.grpbx_Trainee.Text = "Trainee";
            // 
            // textBox_Name_Trainee
            // 
            this.textBox_Name_Trainee.Enabled = false;
            this.textBox_Name_Trainee.Location = new System.Drawing.Point(114, 154);
            this.textBox_Name_Trainee.Name = "textBox_Name_Trainee";
            this.textBox_Name_Trainee.Size = new System.Drawing.Size(219, 26);
            this.textBox_Name_Trainee.TabIndex = 3;
            // 
            // textBox_SSN_Trainee
            // 
            this.textBox_SSN_Trainee.Enabled = false;
            this.textBox_SSN_Trainee.Location = new System.Drawing.Point(114, 105);
            this.textBox_SSN_Trainee.Name = "textBox_SSN_Trainee";
            this.textBox_SSN_Trainee.Size = new System.Drawing.Size(219, 26);
            this.textBox_SSN_Trainee.TabIndex = 3;
            // 
            // textBox_Search_Trainee
            // 
            this.textBox_Search_Trainee.Location = new System.Drawing.Point(114, 52);
            this.textBox_Search_Trainee.Name = "textBox_Search_Trainee";
            this.textBox_Search_Trainee.Size = new System.Drawing.Size(219, 26);
            this.textBox_Search_Trainee.TabIndex = 3;
            this.textBox_Search_Trainee.TextChanged += new System.EventHandler(this.textBox_Search_TextChanged);
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
            // dataGridView_Trainee
            // 
            this.dataGridView_Trainee.AllowUserToAddRows = false;
            this.dataGridView_Trainee.AllowUserToResizeColumns = false;
            this.dataGridView_Trainee.AllowUserToResizeRows = false;
            this.dataGridView_Trainee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Trainee.Location = new System.Drawing.Point(383, 52);
            this.dataGridView_Trainee.MultiSelect = false;
            this.dataGridView_Trainee.Name = "dataGridView_Trainee";
            this.dataGridView_Trainee.ReadOnly = true;
            this.dataGridView_Trainee.RowHeadersWidth = 62;
            this.dataGridView_Trainee.RowTemplate.Height = 28;
            this.dataGridView_Trainee.Size = new System.Drawing.Size(506, 128);
            this.dataGridView_Trainee.TabIndex = 1;
            this.dataGridView_Trainee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Trainee_CellContentClick);
            this.dataGridView_Trainee.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_Trainee_RowHeaderMouseClick);
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
            // groupBox_Trainer
            // 
            this.groupBox_Trainer.Controls.Add(this.textBoxName_Trainer);
            this.groupBox_Trainer.Controls.Add(this.textBox_SSN_Trainer);
            this.groupBox_Trainer.Controls.Add(this.textBox_Search_Trainer);
            this.groupBox_Trainer.Controls.Add(this.label1);
            this.groupBox_Trainer.Controls.Add(this.dataGridViewTrainer);
            this.groupBox_Trainer.Controls.Add(this.label2);
            this.groupBox_Trainer.Controls.Add(this.label3);
            this.groupBox_Trainer.Location = new System.Drawing.Point(12, 266);
            this.groupBox_Trainer.Name = "groupBox_Trainer";
            this.groupBox_Trainer.Size = new System.Drawing.Size(905, 190);
            this.groupBox_Trainer.TabIndex = 1;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "SSN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name";
            // 
            // btn_Assign
            // 
            this.btn_Assign.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_Assign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Assign.ForeColor = System.Drawing.Color.White;
            this.btn_Assign.Location = new System.Drawing.Point(88, 462);
            this.btn_Assign.Name = "btn_Assign";
            this.btn_Assign.Size = new System.Drawing.Size(136, 47);
            this.btn_Assign.TabIndex = 2;
            this.btn_Assign.Text = "Assign";
            this.btn_Assign.UseVisualStyleBackColor = false;
            this.btn_Assign.Click += new System.EventHandler(this.btn_Assign_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.Location = new System.Drawing.Point(658, 462);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(136, 47);
            this.btn_Clear.TabIndex = 2;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // Assign_Trainers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 521);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Assign);
            this.Controls.Add(this.groupBox_Trainer);
            this.Controls.Add(this.grpbx_Trainee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Assign_Trainers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assign Trainers";
            this.Load += new System.EventHandler(this.Assign_Trainers_Load);
            this.grpbx_Trainee.ResumeLayout(false);
            this.grpbx_Trainee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Trainee)).EndInit();
            this.groupBox_Trainer.ResumeLayout(false);
            this.groupBox_Trainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrainer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Trainee_Name;
        private System.Windows.Forms.GroupBox grpbx_Trainee;
        private System.Windows.Forms.Label label_SSN;
        private System.Windows.Forms.Label label_Search;
        private System.Windows.Forms.DataGridView dataGridView_Trainee;
        private System.Windows.Forms.TextBox textBox_Search_Trainee;
        private System.Windows.Forms.TextBox textBox_Name_Trainee;
        private System.Windows.Forms.TextBox textBox_SSN_Trainee;
        private System.Windows.Forms.GroupBox groupBox_Trainer;
        private System.Windows.Forms.TextBox textBoxName_Trainer;
        private System.Windows.Forms.TextBox textBox_SSN_Trainer;
        private System.Windows.Forms.TextBox textBox_Search_Trainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewTrainer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Assign;
        private System.Windows.Forms.Button btn_Clear;
    }
}