
namespace Receptionist
{
    partial class ManageMemberships
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
            this.groupBox_AddorUpdateMembership = new System.Windows.Forms.GroupBox();
            this.label_id = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.label_duration = new System.Windows.Forms.Label();
            this.groupBox_CancelMembership = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.textBox_cancel = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_fees = new System.Windows.Forms.TextBox();
            this.textBox_duration = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.groupBox_AddorUpdateMembership.SuspendLayout();
            this.groupBox_CancelMembership.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_AddorUpdateMembership
            // 
            this.groupBox_AddorUpdateMembership.Controls.Add(this.update);
            this.groupBox_AddorUpdateMembership.Controls.Add(this.Add);
            this.groupBox_AddorUpdateMembership.Controls.Add(this.textBox_duration);
            this.groupBox_AddorUpdateMembership.Controls.Add(this.textBox_fees);
            this.groupBox_AddorUpdateMembership.Controls.Add(this.textBox_name);
            this.groupBox_AddorUpdateMembership.Controls.Add(this.textBox_id);
            this.groupBox_AddorUpdateMembership.Controls.Add(this.label_duration);
            this.groupBox_AddorUpdateMembership.Controls.Add(this.label_price);
            this.groupBox_AddorUpdateMembership.Controls.Add(this.label_name);
            this.groupBox_AddorUpdateMembership.Controls.Add(this.label_id);
            this.groupBox_AddorUpdateMembership.Location = new System.Drawing.Point(41, 27);
            this.groupBox_AddorUpdateMembership.Name = "groupBox_AddorUpdateMembership";
            this.groupBox_AddorUpdateMembership.Size = new System.Drawing.Size(683, 264);
            this.groupBox_AddorUpdateMembership.TabIndex = 0;
            this.groupBox_AddorUpdateMembership.TabStop = false;
            this.groupBox_AddorUpdateMembership.Text = "Add/Update Membership";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(14, 50);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(102, 17);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "Membership ID";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(14, 106);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(85, 17);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "Membership";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Location = new System.Drawing.Point(14, 157);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(39, 17);
            this.label_price.TabIndex = 2;
            this.label_price.Text = "Fees";
            // 
            // label_duration
            // 
            this.label_duration.AutoSize = true;
            this.label_duration.Location = new System.Drawing.Point(14, 216);
            this.label_duration.Name = "label_duration";
            this.label_duration.Size = new System.Drawing.Size(121, 17);
            this.label_duration.TabIndex = 3;
            this.label_duration.Text = "Duration (in days)";
            // 
            // groupBox_CancelMembership
            // 
            this.groupBox_CancelMembership.Controls.Add(this.textBox_cancel);
            this.groupBox_CancelMembership.Controls.Add(this.cancel);
            this.groupBox_CancelMembership.Controls.Add(this.label1);
            this.groupBox_CancelMembership.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox_CancelMembership.Location = new System.Drawing.Point(41, 338);
            this.groupBox_CancelMembership.Name = "groupBox_CancelMembership";
            this.groupBox_CancelMembership.Size = new System.Drawing.Size(683, 100);
            this.groupBox_CancelMembership.TabIndex = 1;
            this.groupBox_CancelMembership.TabStop = false;
            this.groupBox_CancelMembership.Text = "Cancel Membership";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Membership ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.SystemColors.Control;
            this.cancel.Location = new System.Drawing.Point(483, 49);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(91, 36);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // textBox_cancel
            // 
            this.textBox_cancel.Location = new System.Drawing.Point(195, 56);
            this.textBox_cancel.Name = "textBox_cancel";
            this.textBox_cancel.Size = new System.Drawing.Size(65, 22);
            this.textBox_cancel.TabIndex = 2;
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(307, 45);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(65, 22);
            this.textBox_id.TabIndex = 4;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(307, 101);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 22);
            this.textBox_name.TabIndex = 5;
            // 
            // textBox_fees
            // 
            this.textBox_fees.Location = new System.Drawing.Point(307, 154);
            this.textBox_fees.Name = "textBox_fees";
            this.textBox_fees.Size = new System.Drawing.Size(100, 22);
            this.textBox_fees.TabIndex = 6;
            // 
            // textBox_duration
            // 
            this.textBox_duration.Location = new System.Drawing.Point(307, 211);
            this.textBox_duration.Name = "textBox_duration";
            this.textBox_duration.Size = new System.Drawing.Size(65, 22);
            this.textBox_duration.TabIndex = 7;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(549, 157);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(91, 34);
            this.Add.TabIndex = 8;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(549, 216);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(91, 31);
            this.update.TabIndex = 9;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // ManageMemberships
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox_CancelMembership);
            this.Controls.Add(this.groupBox_AddorUpdateMembership);
            this.Name = "ManageMemberships";
            this.Text = "ManageMemberships";
            this.groupBox_AddorUpdateMembership.ResumeLayout(false);
            this.groupBox_AddorUpdateMembership.PerformLayout();
            this.groupBox_CancelMembership.ResumeLayout(false);
            this.groupBox_CancelMembership.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_AddorUpdateMembership;
        private System.Windows.Forms.Label label_duration;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.GroupBox groupBox_CancelMembership;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox textBox_duration;
        private System.Windows.Forms.TextBox textBox_fees;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_cancel;
        private System.Windows.Forms.Button cancel;
    }
}