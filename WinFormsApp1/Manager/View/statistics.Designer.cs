namespace WinFormsApp1
{
    partial class statistics
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
            this.statistics_view_button = new System.Windows.Forms.Button();
            this.statistics_dgv = new System.Windows.Forms.DataGridView();
            this.statistics_combob = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.statistics_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // statistics_view_button
            // 
            this.statistics_view_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(106)))), ((int)(((byte)(135)))));
            this.statistics_view_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statistics_view_button.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statistics_view_button.ForeColor = System.Drawing.Color.White;
            this.statistics_view_button.Location = new System.Drawing.Point(618, 36);
            this.statistics_view_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.statistics_view_button.Name = "statistics_view_button";
            this.statistics_view_button.Size = new System.Drawing.Size(250, 45);
            this.statistics_view_button.TabIndex = 30;
            this.statistics_view_button.Text = "View";
            this.statistics_view_button.UseVisualStyleBackColor = false;
            this.statistics_view_button.Click += new System.EventHandler(this.statistics_view_button_Click);
            // 
            // statistics_dgv
            // 
            this.statistics_dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(106)))), ((int)(((byte)(135)))));
            this.statistics_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statistics_dgv.Location = new System.Drawing.Point(47, 111);
            this.statistics_dgv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.statistics_dgv.Name = "statistics_dgv";
            this.statistics_dgv.RowHeadersWidth = 51;
            this.statistics_dgv.RowTemplate.Height = 25;
            this.statistics_dgv.Size = new System.Drawing.Size(821, 473);
            this.statistics_dgv.TabIndex = 25;
            // 
            // statistics_combob
            // 
            this.statistics_combob.FormattingEnabled = true;
            this.statistics_combob.Items.AddRange(new object[] {
            "number of customers assigned to every trainer",
            "number of customers using every device",
            "Show profit of each year"});
            this.statistics_combob.Location = new System.Drawing.Point(268, 46);
            this.statistics_combob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.statistics_combob.Name = "statistics_combob";
            this.statistics_combob.Size = new System.Drawing.Size(307, 28);
            this.statistics_combob.TabIndex = 31;
            // 
            // statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(178)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.statistics_combob);
            this.Controls.Add(this.statistics_view_button);
            this.Controls.Add(this.statistics_dgv);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "statistics";
            this.Text = "Statistics";
            ((System.ComponentModel.ISupportInitialize)(this.statistics_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button statistics_view_button;
        private DataGridView statistics_dgv;
        private ComboBox statistics_combob;
    }
}