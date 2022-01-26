
namespace NEA_project
{
    partial class AboutMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutMenu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.aboutBox = new System.Windows.Forms.GroupBox();
            this.repoLabel = new System.Windows.Forms.LinkLabel();
            this.verLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.idiotLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.aboutBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 33);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // aboutBox
            // 
            this.aboutBox.Controls.Add(this.idiotLabel);
            this.aboutBox.Controls.Add(this.repoLabel);
            this.aboutBox.Controls.Add(this.verLabel);
            this.aboutBox.Controls.Add(this.nameLabel);
            this.aboutBox.Location = new System.Drawing.Point(12, 51);
            this.aboutBox.Name = "aboutBox";
            this.aboutBox.Size = new System.Drawing.Size(210, 98);
            this.aboutBox.TabIndex = 1;
            this.aboutBox.TabStop = false;
            this.aboutBox.Text = "About SMPP";
            // 
            // repoLabel
            // 
            this.repoLabel.AutoSize = true;
            this.repoLabel.Location = new System.Drawing.Point(7, 72);
            this.repoLabel.Name = "repoLabel";
            this.repoLabel.Size = new System.Drawing.Size(101, 15);
            this.repoLabel.TabIndex = 2;
            this.repoLabel.TabStop = true;
            this.repoLabel.Text = "GitHub repository";
            this.repoLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.repoLabel_LinkClicked);
            // 
            // verLabel
            // 
            this.verLabel.AutoSize = true;
            this.verLabel.Location = new System.Drawing.Point(7, 38);
            this.verLabel.Name = "verLabel";
            this.verLabel.Size = new System.Drawing.Size(122, 15);
            this.verLabel.TabIndex = 1;
            this.verLabel.Text = "dev build v0.whatever";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(7, 23);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(173, 15);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Stock Market Prediction Project";
            // 
            // idiotLabel
            // 
            this.idiotLabel.AutoSize = true;
            this.idiotLabel.Location = new System.Drawing.Point(7, 53);
            this.idiotLabel.Name = "idiotLabel";
            this.idiotLabel.Size = new System.Drawing.Size(104, 15);
            this.idiotLabel.TabIndex = 3;
            this.idiotLabel.Text = "by William George";
            // 
            // AboutMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 161);
            this.Controls.Add(this.aboutBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AboutMenu";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.aboutBox.ResumeLayout(false);
            this.aboutBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox aboutBox;
        private System.Windows.Forms.LinkLabel repoLabel;
        private System.Windows.Forms.Label verLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label idiotLabel;
    }
}