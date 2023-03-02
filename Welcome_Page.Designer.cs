namespace Sky_Bank_Forms
{
    partial class Welcome_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome_Page));
            this.picBx_logo = new System.Windows.Forms.PictureBox();
            this.pnl_right = new System.Windows.Forms.Panel();
            this.btn_clientchoice = new System.Windows.Forms.Button();
            this.pnl_left = new System.Windows.Forms.Panel();
            this.btn_agentchoice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBx_logo)).BeginInit();
            this.pnl_right.SuspendLayout();
            this.pnl_left.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBx_logo
            // 
            this.picBx_logo.BackColor = System.Drawing.SystemColors.Control;
            this.picBx_logo.Image = ((System.Drawing.Image)(resources.GetObject("picBx_logo.Image")));
            this.picBx_logo.Location = new System.Drawing.Point(162, 39);
            this.picBx_logo.Name = "picBx_logo";
            this.picBx_logo.Size = new System.Drawing.Size(338, 213);
            this.picBx_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBx_logo.TabIndex = 0;
            this.picBx_logo.TabStop = false;
            this.picBx_logo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pnl_right
            // 
            this.pnl_right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(173)))), ((int)(((byte)(14)))));
            this.pnl_right.Controls.Add(this.btn_clientchoice);
            this.pnl_right.Location = new System.Drawing.Point(345, 11);
            this.pnl_right.Name = "pnl_right";
            this.pnl_right.Size = new System.Drawing.Size(344, 566);
            this.pnl_right.TabIndex = 1;
            // 
            // btn_clientchoice
            // 
            this.btn_clientchoice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(97)))));
            this.btn_clientchoice.FlatAppearance.BorderSize = 2;
            this.btn_clientchoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clientchoice.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clientchoice.Location = new System.Drawing.Point(167, 423);
            this.btn_clientchoice.Name = "btn_clientchoice";
            this.btn_clientchoice.Size = new System.Drawing.Size(142, 76);
            this.btn_clientchoice.TabIndex = 0;
            this.btn_clientchoice.Text = "I am a CLIENT";
            this.btn_clientchoice.UseVisualStyleBackColor = true;
            this.btn_clientchoice.Click += new System.EventHandler(this.btn_clientchoice_Click);
            // 
            // pnl_left
            // 
            this.pnl_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(97)))));
            this.pnl_left.Controls.Add(this.btn_agentchoice);
            this.pnl_left.Location = new System.Drawing.Point(12, 12);
            this.pnl_left.Name = "pnl_left";
            this.pnl_left.Size = new System.Drawing.Size(327, 565);
            this.pnl_left.TabIndex = 2;
            // 
            // btn_agentchoice
            // 
            this.btn_agentchoice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(173)))), ((int)(((byte)(14)))));
            this.btn_agentchoice.FlatAppearance.BorderSize = 2;
            this.btn_agentchoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agentchoice.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agentchoice.Location = new System.Drawing.Point(27, 422);
            this.btn_agentchoice.Name = "btn_agentchoice";
            this.btn_agentchoice.Size = new System.Drawing.Size(142, 76);
            this.btn_agentchoice.TabIndex = 0;
            this.btn_agentchoice.Text = "I am an AGENT";
            this.btn_agentchoice.UseVisualStyleBackColor = true;
            this.btn_agentchoice.Click += new System.EventHandler(this.btn_agentchoice_Click);
            // 
            // Welcome_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(700, 590);
            this.Controls.Add(this.picBx_logo);
            this.Controls.Add(this.pnl_right);
            this.Controls.Add(this.pnl_left);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Welcome_Page";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBx_logo)).EndInit();
            this.pnl_right.ResumeLayout(false);
            this.pnl_left.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBx_logo;
        private System.Windows.Forms.Panel pnl_right;
        private System.Windows.Forms.Panel pnl_left;
        private System.Windows.Forms.Button btn_clientchoice;
        private System.Windows.Forms.Button btn_agentchoice;
    }
}