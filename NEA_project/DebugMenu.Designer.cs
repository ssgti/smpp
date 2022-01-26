
namespace NEA_project
{
    partial class DebugMenu
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
            this.debugBox = new System.Windows.Forms.GroupBox();
            this.formsLabel = new System.Windows.Forms.Label();
            this.persBtn = new System.Windows.Forms.Button();
            this.mainBtn = new System.Windows.Forms.Button();
            this.regBtn = new System.Windows.Forms.Button();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.debugBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // debugBox
            // 
            this.debugBox.Controls.Add(this.formsLabel);
            this.debugBox.Controls.Add(this.persBtn);
            this.debugBox.Controls.Add(this.mainBtn);
            this.debugBox.Controls.Add(this.regBtn);
            this.debugBox.Controls.Add(this.aboutBtn);
            this.debugBox.Controls.Add(this.loginBtn);
            this.debugBox.Location = new System.Drawing.Point(13, 13);
            this.debugBox.Name = "debugBox";
            this.debugBox.Size = new System.Drawing.Size(169, 169);
            this.debugBox.TabIndex = 0;
            this.debugBox.TabStop = false;
            this.debugBox.Text = "super secret debug menu";
            // 
            // formsLabel
            // 
            this.formsLabel.AutoSize = true;
            this.formsLabel.Location = new System.Drawing.Point(20, 84);
            this.formsLabel.Name = "formsLabel";
            this.formsLabel.Size = new System.Drawing.Size(40, 15);
            this.formsLabel.TabIndex = 5;
            this.formsLabel.Text = "Forms";
            // 
            // persBtn
            // 
            this.persBtn.Location = new System.Drawing.Point(88, 109);
            this.persBtn.Name = "persBtn";
            this.persBtn.Size = new System.Drawing.Size(75, 23);
            this.persBtn.TabIndex = 4;
            this.persBtn.Text = "Personalise";
            this.persBtn.UseVisualStyleBackColor = true;
            this.persBtn.Click += new System.EventHandler(this.persBtn_Click);
            // 
            // mainBtn
            // 
            this.mainBtn.Location = new System.Drawing.Point(88, 80);
            this.mainBtn.Name = "mainBtn";
            this.mainBtn.Size = new System.Drawing.Size(75, 23);
            this.mainBtn.TabIndex = 3;
            this.mainBtn.Text = "Main";
            this.mainBtn.UseVisualStyleBackColor = true;
            this.mainBtn.Click += new System.EventHandler(this.mainBtn_Click);
            // 
            // regBtn
            // 
            this.regBtn.Location = new System.Drawing.Point(88, 51);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(75, 23);
            this.regBtn.TabIndex = 2;
            this.regBtn.Text = "Register";
            this.regBtn.UseVisualStyleBackColor = true;
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // aboutBtn
            // 
            this.aboutBtn.Location = new System.Drawing.Point(88, 138);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(75, 23);
            this.aboutBtn.TabIndex = 1;
            this.aboutBtn.Text = "About";
            this.aboutBtn.UseVisualStyleBackColor = true;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(88, 22);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // DebugMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 194);
            this.Controls.Add(this.debugBox);
            this.Name = "DebugMenu";
            this.Text = "Hi";
            this.debugBox.ResumeLayout(false);
            this.debugBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox debugBox;
        private System.Windows.Forms.Button persBtn;
        private System.Windows.Forms.Button mainBtn;
        private System.Windows.Forms.Button regBtn;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label formsLabel;
    }
}