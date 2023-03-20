namespace Sky_Bank_Forms
{
    partial class Agent_Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agent_Profile));
            this.lbl_agentprofile = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_agentlogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_agentprofile
            // 
            this.lbl_agentprofile.AutoSize = true;
            this.lbl_agentprofile.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_agentprofile.ForeColor = System.Drawing.Color.White;
            this.lbl_agentprofile.Location = new System.Drawing.Point(23, 230);
            this.lbl_agentprofile.Name = "lbl_agentprofile";
            this.lbl_agentprofile.Size = new System.Drawing.Size(127, 24);
            this.lbl_agentprofile.TabIndex = 7;
            this.lbl_agentprofile.Text = "Agent Profile";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btn_agentlogout
            // 
            this.btn_agentlogout.FlatAppearance.BorderSize = 0;
            this.btn_agentlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agentlogout.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agentlogout.ForeColor = System.Drawing.Color.White;
            this.btn_agentlogout.Location = new System.Drawing.Point(12, 472);
            this.btn_agentlogout.Name = "btn_agentlogout";
            this.btn_agentlogout.Size = new System.Drawing.Size(123, 37);
            this.btn_agentlogout.TabIndex = 5;
            this.btn_agentlogout.Text = "LOG OUT";
            this.btn_agentlogout.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(167, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 497);
            this.panel1.TabIndex = 4;
            // 
            // Agent_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(892, 521);
            this.Controls.Add(this.lbl_agentprofile);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_agentlogout);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Agent_Profile";
            this.Text = "Agent Profile";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_agentprofile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_agentlogout;
        private System.Windows.Forms.Panel panel1;
    }
}