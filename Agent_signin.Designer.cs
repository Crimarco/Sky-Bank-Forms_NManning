namespace Sky_Bank_Forms
{
    partial class Agent_signin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agent_signin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_skibank = new System.Windows.Forms.Label();
            this.picBX_agskibank = new System.Windows.Forms.PictureBox();
            this.btn_agentback = new System.Windows.Forms.Button();
            this.lbl_agent = new System.Windows.Forms.Label();
            this.pnl_agentsignin = new System.Windows.Forms.Panel();
            this.lbl_agusername = new System.Windows.Forms.Label();
            this.lbl_agpassword = new System.Windows.Forms.Label();
            this.txtBx_agusername = new System.Windows.Forms.TextBox();
            this.txtBx_agpassword = new System.Windows.Forms.TextBox();
            this.btn_agsignin = new System.Windows.Forms.Button();
            this.btn_fagsignin = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBX_agskibank)).BeginInit();
            this.pnl_agentsignin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(97)))));
            this.panel1.Controls.Add(this.lbl_skibank);
            this.panel1.Controls.Add(this.picBX_agskibank);
            this.panel1.Controls.Add(this.btn_agentback);
            this.panel1.Controls.Add(this.lbl_agent);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 590);
            this.panel1.TabIndex = 0;
            // 
            // lbl_skibank
            // 
            this.lbl_skibank.AutoSize = true;
            this.lbl_skibank.Font = new System.Drawing.Font("Adobe Fangsong Std R", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_skibank.ForeColor = System.Drawing.Color.White;
            this.lbl_skibank.Location = new System.Drawing.Point(101, 282);
            this.lbl_skibank.Name = "lbl_skibank";
            this.lbl_skibank.Size = new System.Drawing.Size(104, 26);
            this.lbl_skibank.TabIndex = 3;
            this.lbl_skibank.Text = "SKI BANK";
            // 
            // picBX_agskibank
            // 
            this.picBX_agskibank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBX_agskibank.Image = ((System.Drawing.Image)(resources.GetObject("picBX_agskibank.Image")));
            this.picBX_agskibank.Location = new System.Drawing.Point(39, 101);
            this.picBX_agskibank.Margin = new System.Windows.Forms.Padding(0);
            this.picBX_agskibank.Name = "picBX_agskibank";
            this.picBX_agskibank.Size = new System.Drawing.Size(237, 192);
            this.picBX_agskibank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBX_agskibank.TabIndex = 4;
            this.picBX_agskibank.TabStop = false;
            // 
            // btn_agentback
            // 
            this.btn_agentback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(97)))));
            this.btn_agentback.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(97)))));
            this.btn_agentback.FlatAppearance.BorderSize = 0;
            this.btn_agentback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agentback.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agentback.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_agentback.Location = new System.Drawing.Point(29, 518);
            this.btn_agentback.Name = "btn_agentback";
            this.btn_agentback.Size = new System.Drawing.Size(104, 42);
            this.btn_agentback.TabIndex = 5;
            this.btn_agentback.Text = "Back";
            this.btn_agentback.UseVisualStyleBackColor = false;
            this.btn_agentback.Click += new System.EventHandler(this.btn_agentback_Click);
            // 
            // lbl_agent
            // 
            this.lbl_agent.AutoSize = true;
            this.lbl_agent.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_agent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_agent.Location = new System.Drawing.Point(35, 30);
            this.lbl_agent.Name = "lbl_agent";
            this.lbl_agent.Size = new System.Drawing.Size(55, 20);
            this.lbl_agent.TabIndex = 6;
            this.lbl_agent.Text = "Agent";
            // 
            // pnl_agentsignin
            // 
            this.pnl_agentsignin.Controls.Add(this.pictureBox2);
            this.pnl_agentsignin.Controls.Add(this.btn_fagsignin);
            this.pnl_agentsignin.Controls.Add(this.btn_agsignin);
            this.pnl_agentsignin.Controls.Add(this.txtBx_agpassword);
            this.pnl_agentsignin.Controls.Add(this.txtBx_agusername);
            this.pnl_agentsignin.Controls.Add(this.lbl_agpassword);
            this.pnl_agentsignin.Controls.Add(this.lbl_agusername);
            this.pnl_agentsignin.Location = new System.Drawing.Point(305, 0);
            this.pnl_agentsignin.Name = "pnl_agentsignin";
            this.pnl_agentsignin.Size = new System.Drawing.Size(396, 590);
            this.pnl_agentsignin.TabIndex = 1;
            // 
            // lbl_agusername
            // 
            this.lbl_agusername.AutoSize = true;
            this.lbl_agusername.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_agusername.Location = new System.Drawing.Point(42, 240);
            this.lbl_agusername.Name = "lbl_agusername";
            this.lbl_agusername.Size = new System.Drawing.Size(93, 20);
            this.lbl_agusername.TabIndex = 9;
            this.lbl_agusername.Text = "User Name";
            // 
            // lbl_agpassword
            // 
            this.lbl_agpassword.AutoSize = true;
            this.lbl_agpassword.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_agpassword.Location = new System.Drawing.Point(42, 297);
            this.lbl_agpassword.Name = "lbl_agpassword";
            this.lbl_agpassword.Size = new System.Drawing.Size(80, 20);
            this.lbl_agpassword.TabIndex = 8;
            this.lbl_agpassword.Text = "Password";
            // 
            // txtBx_agusername
            // 
            this.txtBx_agusername.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtBx_agusername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBx_agusername.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtBx_agusername.Location = new System.Drawing.Point(157, 240);
            this.txtBx_agusername.Name = "txtBx_agusername";
            this.txtBx_agusername.Size = new System.Drawing.Size(175, 20);
            this.txtBx_agusername.TabIndex = 11;
            this.txtBx_agusername.TextChanged += new System.EventHandler(this.txtBx_agusername_TextChanged);
            // 
            // txtBx_agpassword
            // 
            this.txtBx_agpassword.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtBx_agpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBx_agpassword.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtBx_agpassword.Location = new System.Drawing.Point(157, 300);
            this.txtBx_agpassword.Name = "txtBx_agpassword";
            this.txtBx_agpassword.Size = new System.Drawing.Size(175, 20);
            this.txtBx_agpassword.TabIndex = 10;
            this.txtBx_agpassword.TextChanged += new System.EventHandler(this.txtBx_agpassword_TextChanged);
            // 
            // btn_agsignin
            // 
            this.btn_agsignin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_agsignin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_agsignin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(173)))), ((int)(((byte)(14)))));
            this.btn_agsignin.FlatAppearance.BorderSize = 0;
            this.btn_agsignin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agsignin.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agsignin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_agsignin.Location = new System.Drawing.Point(18, 18);
            this.btn_agsignin.Name = "btn_agsignin";
            this.btn_agsignin.Size = new System.Drawing.Size(104, 42);
            this.btn_agsignin.TabIndex = 7;
            this.btn_agsignin.Text = "Sign In";
            this.btn_agsignin.UseVisualStyleBackColor = false;
            this.btn_agsignin.Click += new System.EventHandler(this.btn_agsignin_Click);
            // 
            // btn_fagsignin
            // 
            this.btn_fagsignin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(97)))));
            this.btn_fagsignin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(97)))));
            this.btn_fagsignin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fagsignin.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fagsignin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(173)))), ((int)(((byte)(14)))));
            this.btn_fagsignin.Location = new System.Drawing.Point(135, 386);
            this.btn_fagsignin.Name = "btn_fagsignin";
            this.btn_fagsignin.Size = new System.Drawing.Size(143, 42);
            this.btn_fagsignin.TabIndex = 6;
            this.btn_fagsignin.Text = "Sign In";
            this.btn_fagsignin.UseVisualStyleBackColor = false;
            this.btn_fagsignin.Click += new System.EventHandler(this.btn_fagsignin_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(131, 142);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(158, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // Agent_signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 590);
            this.Controls.Add(this.pnl_agentsignin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Agent_signin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agent_signin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBX_agskibank)).EndInit();
            this.pnl_agentsignin.ResumeLayout(false);
            this.pnl_agentsignin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_skibank;
        private System.Windows.Forms.PictureBox picBX_agskibank;
        private System.Windows.Forms.Button btn_agentback;
        private System.Windows.Forms.Label lbl_agent;
        private System.Windows.Forms.Panel pnl_agentsignin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_fagsignin;
        private System.Windows.Forms.Button btn_agsignin;
        private System.Windows.Forms.TextBox txtBx_agpassword;
        private System.Windows.Forms.TextBox txtBx_agusername;
        private System.Windows.Forms.Label lbl_agpassword;
        private System.Windows.Forms.Label lbl_agusername;
    }
}