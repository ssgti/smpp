
namespace NEA_project
{
    partial class PersonaliseMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonaliseMenu));
            this.selectBox = new System.Windows.Forms.GroupBox();
            this.predictLabel2 = new System.Windows.Forms.Label();
            this.selectionList = new System.Windows.Forms.ListBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.selectedList = new System.Windows.Forms.ListBox();
            this.predictLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.selectBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // selectBox
            // 
            this.selectBox.Controls.Add(this.predictLabel2);
            this.selectBox.Controls.Add(this.selectionList);
            this.selectBox.Controls.Add(this.resetBtn);
            this.selectBox.Controls.Add(this.removeBtn);
            this.selectBox.Controls.Add(this.addBtn);
            this.selectBox.Controls.Add(this.selectedList);
            this.selectBox.Controls.Add(this.predictLabel);
            this.selectBox.Location = new System.Drawing.Point(12, 51);
            this.selectBox.Name = "selectBox";
            this.selectBox.Size = new System.Drawing.Size(600, 298);
            this.selectBox.TabIndex = 4;
            this.selectBox.TabStop = false;
            this.selectBox.Text = "Select Your Predictions";
            // 
            // predictLabel2
            // 
            this.predictLabel2.AutoSize = true;
            this.predictLabel2.Location = new System.Drawing.Point(384, 11);
            this.predictLabel2.Name = "predictLabel2";
            this.predictLabel2.Size = new System.Drawing.Size(55, 15);
            this.predictLabel2.TabIndex = 8;
            this.predictLabel2.Text = "Your List:";
            // 
            // selectionList
            // 
            this.selectionList.FormattingEnabled = true;
            this.selectionList.ItemHeight = 15;
            this.selectionList.Location = new System.Drawing.Point(6, 59);
            this.selectionList.Name = "selectionList";
            this.selectionList.ScrollAlwaysVisible = true;
            this.selectionList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.selectionList.Size = new System.Drawing.Size(290, 229);
            this.selectionList.TabIndex = 7;
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(303, 269);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 6;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(302, 211);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(75, 23);
            this.removeBtn.TabIndex = 5;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(302, 153);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // selectedList
            // 
            this.selectedList.BackColor = System.Drawing.SystemColors.Menu;
            this.selectedList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.selectedList.FormattingEnabled = true;
            this.selectedList.ItemHeight = 15;
            this.selectedList.Location = new System.Drawing.Point(384, 29);
            this.selectedList.Name = "selectedList";
            this.selectedList.Size = new System.Drawing.Size(210, 255);
            this.selectedList.TabIndex = 3;
            // 
            // predictLabel
            // 
            this.predictLabel.AutoSize = true;
            this.predictLabel.Location = new System.Drawing.Point(6, 41);
            this.predictLabel.Name = "predictLabel";
            this.predictLabel.Size = new System.Drawing.Size(275, 15);
            this.predictLabel.TabIndex = 1;
            this.predictLabel.Text = "Select stocks and commodities from the list below.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 35);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(537, 12);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(456, 12);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // PersonaliseMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 361);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.selectBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PersonaliseMenu";
            this.Text = "Personalise";
            this.selectBox.ResumeLayout(false);
            this.selectBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox selectBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label predictLabel;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ListBox selectedList;
        private System.Windows.Forms.ListBox selectionList;
        private System.Windows.Forms.Label predictLabel2;
    }
}