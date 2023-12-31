
namespace Receptionist
{
    partial class Update_Program
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
            this.label_Program_Name = new System.Windows.Forms.Label();
            this.groupBox_Program = new System.Windows.Forms.GroupBox();
            this.buttonView = new System.Windows.Forms.Button();
            this.dataGridView_Prog = new System.Windows.Forms.DataGridView();
            this.comboBox_ProgName = new System.Windows.Forms.ComboBox();
            this.btn_Assign = new System.Windows.Forms.Button();
            this.groupBox_Trainee = new System.Windows.Forms.GroupBox();
            this.textBoxName_Trainee = new System.Windows.Forms.TextBox();
            this.textBox_SSN_Trainee = new System.Windows.Forms.TextBox();
            this.textBox_Search_Trainee = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTrainee = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Clear = new System.Windows.Forms.Button();
            this.groupBox_Program.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Prog)).BeginInit();
            this.groupBox_Trainee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrainee)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Program_Name
            // 
            this.label_Program_Name.AutoSize = true;
            this.label_Program_Name.BackColor = System.Drawing.Color.Transparent;
            this.label_Program_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Program_Name.Location = new System.Drawing.Point(6, 42);
            this.label_Program_Name.Name = "label_Program_Name";
            this.label_Program_Name.Size = new System.Drawing.Size(64, 25);
            this.label_Program_Name.TabIndex = 3;
            this.label_Program_Name.Text = "Name";
            // 
            // groupBox_Program
            // 
            this.groupBox_Program.Controls.Add(this.buttonView);
            this.groupBox_Program.Controls.Add(this.dataGridView_Prog);
            this.groupBox_Program.Controls.Add(this.comboBox_ProgName);
            this.groupBox_Program.Controls.Add(this.label_Program_Name);
            this.groupBox_Program.Location = new System.Drawing.Point(12, 78);
            this.groupBox_Program.Name = "groupBox_Program";
            this.groupBox_Program.Size = new System.Drawing.Size(889, 173);
            this.groupBox_Program.TabIndex = 4;
            this.groupBox_Program.TabStop = false;
            this.groupBox_Program.Text = "Program";
            // 
            // buttonView
            // 
            this.buttonView.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonView.ForeColor = System.Drawing.Color.White;
            this.buttonView.Location = new System.Drawing.Point(112, 89);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(115, 47);
            this.buttonView.TabIndex = 8;
            this.buttonView.Text = "View";
            this.buttonView.UseVisualStyleBackColor = false;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // dataGridView_Prog
            // 
            this.dataGridView_Prog.AllowUserToAddRows = false;
            this.dataGridView_Prog.AllowUserToDeleteRows = false;
            this.dataGridView_Prog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Prog.Location = new System.Drawing.Point(383, 25);
            this.dataGridView_Prog.Name = "dataGridView_Prog";
            this.dataGridView_Prog.ReadOnly = true;
            this.dataGridView_Prog.RowHeadersWidth = 62;
            this.dataGridView_Prog.RowTemplate.Height = 28;
            this.dataGridView_Prog.Size = new System.Drawing.Size(500, 111);
            this.dataGridView_Prog.TabIndex = 7;
            // 
            // comboBox_ProgName
            // 
            this.comboBox_ProgName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ProgName.FormattingEnabled = true;
            this.comboBox_ProgName.Location = new System.Drawing.Point(112, 43);
            this.comboBox_ProgName.Name = "comboBox_ProgName";
            this.comboBox_ProgName.Size = new System.Drawing.Size(183, 28);
            this.comboBox_ProgName.TabIndex = 4;
            this.comboBox_ProgName.SelectedIndexChanged += new System.EventHandler(this.comboBox_ProgName_SelectedIndexChanged);
            // 
            // btn_Assign
            // 
            this.btn_Assign.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_Assign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Assign.ForeColor = System.Drawing.Color.White;
            this.btn_Assign.Location = new System.Drawing.Point(124, 470);
            this.btn_Assign.Name = "btn_Assign";
            this.btn_Assign.Size = new System.Drawing.Size(115, 47);
            this.btn_Assign.TabIndex = 6;
            this.btn_Assign.Text = "Assign";
            this.btn_Assign.UseVisualStyleBackColor = false;
            this.btn_Assign.Click += new System.EventHandler(this.btn_Assign_Click);
            // 
            // groupBox_Trainee
            // 
            this.groupBox_Trainee.Controls.Add(this.textBoxName_Trainee);
            this.groupBox_Trainee.Controls.Add(this.textBox_SSN_Trainee);
            this.groupBox_Trainee.Controls.Add(this.textBox_Search_Trainee);
            this.groupBox_Trainee.Controls.Add(this.label1);
            this.groupBox_Trainee.Controls.Add(this.dataGridViewTrainee);
            this.groupBox_Trainee.Controls.Add(this.label2);
            this.groupBox_Trainee.Controls.Add(this.label3);
            this.groupBox_Trainee.Location = new System.Drawing.Point(12, 257);
            this.groupBox_Trainee.Name = "groupBox_Trainee";
            this.groupBox_Trainee.Size = new System.Drawing.Size(897, 190);
            this.groupBox_Trainee.TabIndex = 5;
            this.groupBox_Trainee.TabStop = false;
            this.groupBox_Trainee.Text = "Trainee";
            // 
            // textBoxName_Trainee
            // 
            this.textBoxName_Trainee.Enabled = false;
            this.textBoxName_Trainee.Location = new System.Drawing.Point(114, 154);
            this.textBoxName_Trainee.Name = "textBoxName_Trainee";
            this.textBoxName_Trainee.Size = new System.Drawing.Size(219, 26);
            this.textBoxName_Trainee.TabIndex = 3;
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
            this.textBox_Search_Trainee.TextChanged += new System.EventHandler(this.textBox_Search_Trainee_TextChanged);
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
            // dataGridViewTrainee
            // 
            this.dataGridViewTrainee.AllowUserToAddRows = false;
            this.dataGridViewTrainee.AllowUserToDeleteRows = false;
            this.dataGridViewTrainee.AllowUserToResizeColumns = false;
            this.dataGridViewTrainee.AllowUserToResizeRows = false;
            this.dataGridViewTrainee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrainee.Location = new System.Drawing.Point(383, 52);
            this.dataGridViewTrainee.MultiSelect = false;
            this.dataGridViewTrainee.Name = "dataGridViewTrainee";
            this.dataGridViewTrainee.ReadOnly = true;
            this.dataGridViewTrainee.RowHeadersWidth = 62;
            this.dataGridViewTrainee.RowTemplate.Height = 28;
            this.dataGridViewTrainee.Size = new System.Drawing.Size(506, 128);
            this.dataGridViewTrainee.TabIndex = 1;
            this.dataGridViewTrainee.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewTrainee_RowHeaderMouseClick);
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
            // button_Clear
            // 
            this.button_Clear.BackColor = System.Drawing.Color.RosyBrown;
            this.button_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clear.ForeColor = System.Drawing.Color.White;
            this.button_Clear.Location = new System.Drawing.Point(593, 470);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(115, 47);
            this.button_Clear.TabIndex = 6;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // Update_Program
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 521);
            this.Controls.Add(this.groupBox_Trainee);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.btn_Assign);
            this.Controls.Add(this.groupBox_Program);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Update_Program";
            this.Text = "Update_Program";
            this.groupBox_Program.ResumeLayout(false);
            this.groupBox_Program.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Prog)).EndInit();
            this.groupBox_Trainee.ResumeLayout(false);
            this.groupBox_Trainee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrainee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Program_Name;
        private System.Windows.Forms.GroupBox groupBox_Program;
        private System.Windows.Forms.ComboBox comboBox_ProgName;
        private System.Windows.Forms.Button btn_Assign;
        private System.Windows.Forms.DataGridView dataGridView_Prog;
        private System.Windows.Forms.GroupBox groupBox_Trainee;
        private System.Windows.Forms.TextBox textBoxName_Trainee;
        private System.Windows.Forms.TextBox textBox_SSN_Trainee;
        private System.Windows.Forms.TextBox textBox_Search_Trainee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewTrainee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Button button_Clear;
    }
}