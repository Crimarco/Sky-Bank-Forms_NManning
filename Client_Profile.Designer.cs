﻿namespace Sky_Bank_Forms
{
    partial class Client_Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client_Profile));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnNewLoan = new System.Windows.Forms.Button();
            this.btn_clientlogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_clientprofile = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnNewLoan);
            this.panel1.Location = new System.Drawing.Point(167, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 497);
            this.panel1.TabIndex = 0;
            // 
            // BtnNewLoan
            // 
            this.BtnNewLoan.Location = new System.Drawing.Point(512, 425);
            this.BtnNewLoan.Name = "BtnNewLoan";
            this.BtnNewLoan.Size = new System.Drawing.Size(184, 58);
            this.BtnNewLoan.TabIndex = 0;
            this.BtnNewLoan.Text = "Request A New Loan";
            this.BtnNewLoan.UseVisualStyleBackColor = true;
            this.BtnNewLoan.Click += new System.EventHandler(this.BtnNewLoan_Click);
            // 
            // btn_clientlogout
            // 
            this.btn_clientlogout.FlatAppearance.BorderSize = 0;
            this.btn_clientlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clientlogout.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clientlogout.ForeColor = System.Drawing.Color.White;
            this.btn_clientlogout.Location = new System.Drawing.Point(12, 472);
            this.btn_clientlogout.Name = "btn_clientlogout";
            this.btn_clientlogout.Size = new System.Drawing.Size(123, 37);
            this.btn_clientlogout.TabIndex = 1;
            this.btn_clientlogout.Text = "LOG OUT";
            this.btn_clientlogout.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_clientprofile
            // 
            this.lbl_clientprofile.AutoSize = true;
            this.lbl_clientprofile.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clientprofile.ForeColor = System.Drawing.Color.White;
            this.lbl_clientprofile.Location = new System.Drawing.Point(23, 122);
            this.lbl_clientprofile.Name = "lbl_clientprofile";
            this.lbl_clientprofile.Size = new System.Drawing.Size(125, 24);
            this.lbl_clientprofile.TabIndex = 3;
            this.lbl_clientprofile.Text = "Client Profile";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Account Summary";
            // 
            // Client_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(173)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(892, 521);
            this.Controls.Add(this.lbl_clientprofile);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_clientlogout);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Client_Profile";
            this.Text = "Client Profile";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_clientlogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_clientprofile;
        private System.Windows.Forms.Button BtnNewLoan;
        private System.Windows.Forms.Label label1;
    }
}