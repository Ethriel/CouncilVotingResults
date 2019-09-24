namespace CouncilVouingResults
{
    partial class BulkRenameForm
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
            this.folderSelectFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.labFileExt = new System.Windows.Forms.Label();
            this.labReaplaceWord = new System.Windows.Forms.Label();
            this.textFileExt = new System.Windows.Forms.TextBox();
            this.textReplaceWord = new System.Windows.Forms.TextBox();
            this.butSelectFolder = new System.Windows.Forms.Button();
            this.butRename = new System.Windows.Forms.Button();
            this.butSetParams = new System.Windows.Forms.Button();
            this.butShowResults = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labFileExt
            // 
            this.labFileExt.AutoSize = true;
            this.labFileExt.Location = new System.Drawing.Point(12, 9);
            this.labFileExt.Name = "labFileExt";
            this.labFileExt.Size = new System.Drawing.Size(76, 13);
            this.labFileExt.TabIndex = 0;
            this.labFileExt.Text = "Files extension";
            // 
            // labReaplaceWord
            // 
            this.labReaplaceWord.AutoSize = true;
            this.labReaplaceWord.Location = new System.Drawing.Point(12, 39);
            this.labReaplaceWord.Name = "labReaplaceWord";
            this.labReaplaceWord.Size = new System.Drawing.Size(73, 13);
            this.labReaplaceWord.TabIndex = 1;
            this.labReaplaceWord.Text = "Replace word";
            // 
            // textFileExt
            // 
            this.textFileExt.Location = new System.Drawing.Point(106, 9);
            this.textFileExt.Name = "textFileExt";
            this.textFileExt.Size = new System.Drawing.Size(100, 20);
            this.textFileExt.TabIndex = 3;
            // 
            // textReplaceWord
            // 
            this.textReplaceWord.Location = new System.Drawing.Point(106, 36);
            this.textReplaceWord.Name = "textReplaceWord";
            this.textReplaceWord.Size = new System.Drawing.Size(100, 20);
            this.textReplaceWord.TabIndex = 4;
            // 
            // butSelectFolder
            // 
            this.butSelectFolder.Location = new System.Drawing.Point(13, 66);
            this.butSelectFolder.Name = "butSelectFolder";
            this.butSelectFolder.Size = new System.Drawing.Size(75, 23);
            this.butSelectFolder.TabIndex = 5;
            this.butSelectFolder.Text = "Select folder";
            this.butSelectFolder.UseVisualStyleBackColor = true;
            this.butSelectFolder.Click += new System.EventHandler(this.butSelectFolder_Click);
            // 
            // butRename
            // 
            this.butRename.Location = new System.Drawing.Point(106, 66);
            this.butRename.Name = "butRename";
            this.butRename.Size = new System.Drawing.Size(75, 23);
            this.butRename.TabIndex = 6;
            this.butRename.Text = "Rename";
            this.butRename.UseVisualStyleBackColor = true;
            this.butRename.Visible = false;
            this.butRename.Click += new System.EventHandler(this.butRename_Click);
            // 
            // butSetParams
            // 
            this.butSetParams.Location = new System.Drawing.Point(212, 29);
            this.butSetParams.Name = "butSetParams";
            this.butSetParams.Size = new System.Drawing.Size(75, 23);
            this.butSetParams.TabIndex = 7;
            this.butSetParams.Text = "Set params";
            this.butSetParams.UseVisualStyleBackColor = true;
            this.butSetParams.Click += new System.EventHandler(this.butSetParams_Click);
            // 
            // butShowResults
            // 
            this.butShowResults.Location = new System.Drawing.Point(212, 66);
            this.butShowResults.Name = "butShowResults";
            this.butShowResults.Size = new System.Drawing.Size(75, 23);
            this.butShowResults.TabIndex = 8;
            this.butShowResults.Text = "Show results";
            this.butShowResults.UseVisualStyleBackColor = true;
            this.butShowResults.Visible = false;
            this.butShowResults.Click += new System.EventHandler(this.butShowResults_Click);
            // 
            // BulkRenameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 121);
            this.Controls.Add(this.butShowResults);
            this.Controls.Add(this.butSetParams);
            this.Controls.Add(this.butRename);
            this.Controls.Add(this.butSelectFolder);
            this.Controls.Add(this.textReplaceWord);
            this.Controls.Add(this.textFileExt);
            this.Controls.Add(this.labReaplaceWord);
            this.Controls.Add(this.labFileExt);
            this.Name = "BulkRenameForm";
            this.Text = "Bulk Rename Files";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BulkRenameForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderSelectFolder;
        private System.Windows.Forms.Label labFileExt;
        private System.Windows.Forms.Label labReaplaceWord;
        private System.Windows.Forms.TextBox textFileExt;
        private System.Windows.Forms.TextBox textReplaceWord;
        private System.Windows.Forms.Button butSelectFolder;
        private System.Windows.Forms.Button butRename;
        private System.Windows.Forms.Button butSetParams;
        private System.Windows.Forms.Button butShowResults;
    }
}