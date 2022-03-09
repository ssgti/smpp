
namespace NEA_project
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.persBtn = new System.Windows.Forms.Button();
            this.predictGroupBox = new System.Windows.Forms.GroupBox();
            this.predictBox = new System.Windows.Forms.ListBox();
            this.newsGroupBox = new System.Windows.Forms.GroupBox();
            this.articleBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.predictGroupBox.SuspendLayout();
            this.newsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoBox
            // 
            this.logoBox.Image = ((System.Drawing.Image)(resources.GetObject("logoBox.Image")));
            this.logoBox.Location = new System.Drawing.Point(13, 13);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(211, 31);
            this.logoBox.TabIndex = 0;
            this.logoBox.TabStop = false;
            // 
            // aboutBtn
            // 
            this.aboutBtn.Location = new System.Drawing.Point(697, 12);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(75, 23);
            this.aboutBtn.TabIndex = 1;
            this.aboutBtn.Text = "About";
            this.aboutBtn.UseVisualStyleBackColor = true;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // persBtn
            // 
            this.persBtn.Location = new System.Drawing.Point(616, 12);
            this.persBtn.Name = "persBtn";
            this.persBtn.Size = new System.Drawing.Size(75, 23);
            this.persBtn.TabIndex = 2;
            this.persBtn.Text = "Personalise";
            this.persBtn.UseVisualStyleBackColor = true;
            this.persBtn.Click += new System.EventHandler(this.persBtn_Click);
            // 
            // predictGroupBox
            // 
            this.predictGroupBox.Controls.Add(this.predictBox);
            this.predictGroupBox.Location = new System.Drawing.Point(13, 50);
            this.predictGroupBox.Name = "predictGroupBox";
            this.predictGroupBox.Size = new System.Drawing.Size(598, 387);
            this.predictGroupBox.TabIndex = 3;
            this.predictGroupBox.TabStop = false;
            this.predictGroupBox.Text = "Your Predictions";
            // 
            // predictBox
            // 
            this.predictBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.predictBox.FormattingEnabled = true;
            this.predictBox.ItemHeight = 21;
            this.predictBox.Location = new System.Drawing.Point(7, 23);
            this.predictBox.Name = "predictBox";
            this.predictBox.ScrollAlwaysVisible = true;
            this.predictBox.Size = new System.Drawing.Size(585, 340);
            this.predictBox.TabIndex = 0;
            // 
            // newsGroupBox
            // 
            this.newsGroupBox.Controls.Add(this.articleBox);
            this.newsGroupBox.Location = new System.Drawing.Point(617, 50);
            this.newsGroupBox.Name = "newsGroupBox";
            this.newsGroupBox.Size = new System.Drawing.Size(155, 387);
            this.newsGroupBox.TabIndex = 4;
            this.newsGroupBox.TabStop = false;
            this.newsGroupBox.Text = "News Feed";
            // 
            // articleBox
            // 
            this.articleBox.BackColor = System.Drawing.SystemColors.Menu;
            this.articleBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.articleBox.Location = new System.Drawing.Point(6, 23);
            this.articleBox.Name = "articleBox";
            this.articleBox.Size = new System.Drawing.Size(143, 356);
            this.articleBox.TabIndex = 1;
            this.articleBox.Text = "";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.newsGroupBox);
            this.Controls.Add(this.predictGroupBox);
            this.Controls.Add(this.persBtn);
            this.Controls.Add(this.aboutBtn);
            this.Controls.Add(this.logoBox);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.predictGroupBox.ResumeLayout(false);
            this.newsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.Button persBtn;
        private System.Windows.Forms.GroupBox predictGroupBox;
        private System.Windows.Forms.ListBox predictBox;
        private System.Windows.Forms.GroupBox newsGroupBox;
        private System.Windows.Forms.RichTextBox articleBox;
    }
}

