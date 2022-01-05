
namespace NEA_project
{
    partial class Register
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
            this.detailsGroup = new System.Windows.Forms.GroupBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.createAccount = new System.Windows.Forms.Button();
            this.rePassLabel = new System.Windows.Forms.Label();
            this.rePasswordBox = new System.Windows.Forms.TextBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.detailsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // detailsGroup
            // 
            this.detailsGroup.Controls.Add(this.cancelBtn);
            this.detailsGroup.Controls.Add(this.createAccount);
            this.detailsGroup.Controls.Add(this.rePassLabel);
            this.detailsGroup.Controls.Add(this.rePasswordBox);
            this.detailsGroup.Controls.Add(this.passLabel);
            this.detailsGroup.Controls.Add(this.userLabel);
            this.detailsGroup.Controls.Add(this.passwordBox);
            this.detailsGroup.Controls.Add(this.usernameBox);
            this.detailsGroup.Location = new System.Drawing.Point(13, 13);
            this.detailsGroup.Name = "detailsGroup";
            this.detailsGroup.Size = new System.Drawing.Size(259, 176);
            this.detailsGroup.TabIndex = 0;
            this.detailsGroup.TabStop = false;
            this.detailsGroup.Text = "User Details";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(97, 146);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 11;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // createAccount
            // 
            this.createAccount.Location = new System.Drawing.Point(178, 146);
            this.createAccount.Name = "createAccount";
            this.createAccount.Size = new System.Drawing.Size(75, 23);
            this.createAccount.TabIndex = 10;
            this.createAccount.Text = "Create";
            this.createAccount.UseVisualStyleBackColor = true;
            this.createAccount.Click += new System.EventHandler(this.createAccount_Click);
            // 
            // rePassLabel
            // 
            this.rePassLabel.AutoSize = true;
            this.rePassLabel.Location = new System.Drawing.Point(25, 89);
            this.rePassLabel.Name = "rePassLabel";
            this.rePassLabel.Size = new System.Drawing.Size(96, 15);
            this.rePassLabel.TabIndex = 9;
            this.rePassLabel.Text = "Retype Password";
            // 
            // rePasswordBox
            // 
            this.rePasswordBox.Location = new System.Drawing.Point(127, 86);
            this.rePasswordBox.Name = "rePasswordBox";
            this.rePasswordBox.PasswordChar = '●';
            this.rePasswordBox.Size = new System.Drawing.Size(100, 23);
            this.rePasswordBox.TabIndex = 8;
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(25, 60);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(57, 15);
            this.passLabel.TabIndex = 7;
            this.passLabel.Text = "Password";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(25, 31);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(60, 15);
            this.userLabel.TabIndex = 6;
            this.userLabel.Text = "Username";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(127, 57);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '●';
            this.passwordBox.Size = new System.Drawing.Size(100, 23);
            this.passwordBox.TabIndex = 5;
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(127, 28);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(100, 23);
            this.usernameBox.TabIndex = 4;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 201);
            this.Controls.Add(this.detailsGroup);
            this.Name = "Register";
            this.Text = "Create Account";
            this.detailsGroup.ResumeLayout(false);
            this.detailsGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox detailsGroup;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button createAccount;
        private System.Windows.Forms.Label rePassLabel;
        private System.Windows.Forms.TextBox rePasswordBox;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox usernameBox;
    }
}