namespace MouseCat
{
    partial class Cat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cat));
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.MousePb = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MousePb)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.MousePb);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(58)))), ((int)(((byte)(180)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(58)))), ((int)(((byte)(180)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(69)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(-2, -4);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1935, 1080);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // MousePb
            // 
            this.MousePb.BackColor = System.Drawing.Color.Transparent;
            this.MousePb.BorderRadius = 35;
            this.MousePb.Image = global::MouseCat.Properties.Resources.mouse;
            this.MousePb.Location = new System.Drawing.Point(435, 294);
            this.MousePb.Name = "MousePb";
            this.MousePb.ShadowDecoration.Parent = this.MousePb;
            this.MousePb.Size = new System.Drawing.Size(145, 133);
            this.MousePb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MousePb.TabIndex = 0;
            this.MousePb.TabStop = false;
            this.MousePb.UseTransparentBackground = true;
            this.MousePb.MouseHover += new System.EventHandler(this.MousePb_MouseHover);
            // 
            // Cat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cat";
            this.Text = "Cat & Mouse";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MousePb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2PictureBox MousePb;
    }
}

