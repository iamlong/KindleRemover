namespace KindleRemover
{
    partial class KindleClean
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
            this.label1 = new System.Windows.Forms.Label();
            this.folderPath = new System.Windows.Forms.TextBox();
            this.folderSelectBtn = new System.Windows.Forms.Button();
            this.scanBtn = new System.Windows.Forms.Button();
            this.cleanBtn = new System.Windows.Forms.Button();
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.messageList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kindle Documents Folder";
            // 
            // folderPath
            // 
            this.folderPath.Location = new System.Drawing.Point(186, 23);
            this.folderPath.Name = "folderPath";
            this.folderPath.Size = new System.Drawing.Size(146, 22);
            this.folderPath.TabIndex = 1;
            // 
            // folderSelectBtn
            // 
            this.folderSelectBtn.Location = new System.Drawing.Point(329, 22);
            this.folderSelectBtn.Name = "folderSelectBtn";
            this.folderSelectBtn.Size = new System.Drawing.Size(27, 23);
            this.folderSelectBtn.TabIndex = 2;
            this.folderSelectBtn.Text = "...";
            this.folderSelectBtn.UseVisualStyleBackColor = true;
            this.folderSelectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // scanBtn
            // 
            this.scanBtn.Location = new System.Drawing.Point(362, 23);
            this.scanBtn.Name = "scanBtn";
            this.scanBtn.Size = new System.Drawing.Size(75, 23);
            this.scanBtn.TabIndex = 4;
            this.scanBtn.Text = "Scan";
            this.scanBtn.UseVisualStyleBackColor = true;
            this.scanBtn.Click += new System.EventHandler(this.scanBtn_Click);
            // 
            // cleanBtn
            // 
            this.cleanBtn.Location = new System.Drawing.Point(443, 23);
            this.cleanBtn.Name = "cleanBtn";
            this.cleanBtn.Size = new System.Drawing.Size(75, 23);
            this.cleanBtn.TabIndex = 5;
            this.cleanBtn.Text = "Clean";
            this.cleanBtn.UseVisualStyleBackColor = true;
            this.cleanBtn.Click += new System.EventHandler(this.cleanBtn_Click);
            // 
            // messageList
            // 
            this.messageList.FormattingEnabled = true;
            this.messageList.ItemHeight = 16;
            this.messageList.Location = new System.Drawing.Point(17, 46);
            this.messageList.Name = "messageList";
            this.messageList.Size = new System.Drawing.Size(501, 228);
            this.messageList.TabIndex = 6;
            // 
            // KindleClean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 276);
            this.Controls.Add(this.messageList);
            this.Controls.Add(this.cleanBtn);
            this.Controls.Add(this.scanBtn);
            this.Controls.Add(this.folderSelectBtn);
            this.Controls.Add(this.folderPath);
            this.Controls.Add(this.label1);
            this.Name = "KindleClean";
            this.Text = "Kindle Clean Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox folderPath;
        private System.Windows.Forms.Button folderSelectBtn;
        private System.Windows.Forms.Button scanBtn;
        private System.Windows.Forms.Button cleanBtn;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
        private System.Windows.Forms.ListBox messageList;
    }
}

