﻿
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
            this.aboutBox = new System.Windows.Forms.GroupBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.idiotLabel = new System.Windows.Forms.Label();
            this.repoLabel = new System.Windows.Forms.LinkLabel();
            this.verLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.logoLabel = new System.Windows.Forms.Label();
            this.aboutBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // aboutBox
            // 
            this.aboutBox.Controls.Add(this.deleteBtn);
            this.aboutBox.Controls.Add(this.idiotLabel);
            this.aboutBox.Controls.Add(this.repoLabel);
            this.aboutBox.Controls.Add(this.verLabel);
            this.aboutBox.Controls.Add(this.nameLabel);
            this.aboutBox.Location = new System.Drawing.Point(12, 51);
            this.aboutBox.Name = "aboutBox";
            this.aboutBox.Size = new System.Drawing.Size(210, 128);
            this.aboutBox.TabIndex = 1;
            this.aboutBox.TabStop = false;
            this.aboutBox.Text = "About SMPP";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(104, 99);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(100, 23);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "Delete Account";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // idiotLabel
            // 
            this.idiotLabel.AutoSize = true;
            this.idiotLabel.Location = new System.Drawing.Point(7, 53);
            this.idiotLabel.Name = "idiotLabel";
            this.idiotLabel.Size = new System.Drawing.Size(43, 15);
            this.idiotLabel.TabIndex = 3;
            this.idiotLabel.Text = "by Will";
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
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logoLabel.Location = new System.Drawing.Point(12, 13);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(71, 30);
            this.logoLabel.TabIndex = 2;
            this.logoLabel.Text = "SMPP";
            // 
            // AboutMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 191);
            this.Controls.Add(this.logoLabel);
            this.Controls.Add(this.aboutBox);
            this.Name = "AboutMenu";
            this.Text = "Settings";
            this.aboutBox.ResumeLayout(false);
            this.aboutBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox aboutBox;
        private System.Windows.Forms.LinkLabel repoLabel;
        private System.Windows.Forms.Label verLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label idiotLabel;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label logoLabel;
    }
}