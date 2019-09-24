namespace CouncilVouingResults
{
    partial class Renamer
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
            this.labOpenAfterRename = new System.Windows.Forms.Label();
            this.butOpenFolderAfterRename = new System.Windows.Forms.Button();
            this.butWorkRen = new System.Windows.Forms.Button();
            this.textFileExtRen = new System.Windows.Forms.TextBox();
            this.labFileExctRen = new System.Windows.Forms.Label();
            this.textCriteriaRen = new System.Windows.Forms.TextBox();
            this.labCriteriaRen = new System.Windows.Forms.Label();
            this.labPathRen = new System.Windows.Forms.Label();
            this.butSelectPathRen = new System.Windows.Forms.Button();
            this.labLocPathRen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.labTimePassed = new System.Windows.Forms.Label();
            this.butSetTextParams = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labOpenAfterRename
            // 
            this.labOpenAfterRename.AutoSize = true;
            this.labOpenAfterRename.Location = new System.Drawing.Point(150, 112);
            this.labOpenAfterRename.Name = "labOpenAfterRename";
            this.labOpenAfterRename.Size = new System.Drawing.Size(59, 13);
            this.labOpenAfterRename.TabIndex = 47;
            this.labOpenAfterRename.Text = "See results";
            this.labOpenAfterRename.Visible = false;
            // 
            // butOpenFolderAfterRename
            // 
            this.butOpenFolderAfterRename.Location = new System.Drawing.Point(234, 107);
            this.butOpenFolderAfterRename.Name = "butOpenFolderAfterRename";
            this.butOpenFolderAfterRename.Size = new System.Drawing.Size(75, 23);
            this.butOpenFolderAfterRename.TabIndex = 46;
            this.butOpenFolderAfterRename.Text = "Open folder";
            this.butOpenFolderAfterRename.UseVisualStyleBackColor = true;
            this.butOpenFolderAfterRename.Visible = false;
            this.butOpenFolderAfterRename.Click += new System.EventHandler(this.butOpenFolderAfterRename_Click_1);
            // 
            // butWorkRen
            // 
            this.butWorkRen.Location = new System.Drawing.Point(19, 107);
            this.butWorkRen.Name = "butWorkRen";
            this.butWorkRen.Size = new System.Drawing.Size(93, 23);
            this.butWorkRen.TabIndex = 45;
            this.butWorkRen.Text = "Rename Files";
            this.butWorkRen.UseVisualStyleBackColor = true;
            this.butWorkRen.Visible = false;
            this.butWorkRen.Click += new System.EventHandler(this.butWorkRen_Click_1);
            // 
            // textFileExtRen
            // 
            this.textFileExtRen.Location = new System.Drawing.Point(92, 42);
            this.textFileExtRen.Name = "textFileExtRen";
            this.textFileExtRen.Size = new System.Drawing.Size(127, 20);
            this.textFileExtRen.TabIndex = 42;
            this.textFileExtRen.Visible = false;
            // 
            // labFileExctRen
            // 
            this.labFileExctRen.AutoSize = true;
            this.labFileExctRen.Location = new System.Drawing.Point(16, 45);
            this.labFileExctRen.Name = "labFileExctRen";
            this.labFileExctRen.Size = new System.Drawing.Size(71, 13);
            this.labFileExctRen.TabIndex = 41;
            this.labFileExctRen.Text = "File extension";
            this.labFileExctRen.Visible = false;
            // 
            // textCriteriaRen
            // 
            this.textCriteriaRen.Location = new System.Drawing.Point(92, 12);
            this.textCriteriaRen.Name = "textCriteriaRen";
            this.textCriteriaRen.Size = new System.Drawing.Size(127, 20);
            this.textCriteriaRen.TabIndex = 40;
            this.textCriteriaRen.Visible = false;
            // 
            // labCriteriaRen
            // 
            this.labCriteriaRen.AutoSize = true;
            this.labCriteriaRen.Location = new System.Drawing.Point(16, 15);
            this.labCriteriaRen.Name = "labCriteriaRen";
            this.labCriteriaRen.Size = new System.Drawing.Size(39, 13);
            this.labCriteriaRen.TabIndex = 39;
            this.labCriteriaRen.Text = "Criteria";
            this.labCriteriaRen.Visible = false;
            // 
            // labPathRen
            // 
            this.labPathRen.AutoSize = true;
            this.labPathRen.Location = new System.Drawing.Point(221, 77);
            this.labPathRen.Name = "labPathRen";
            this.labPathRen.Size = new System.Drawing.Size(88, 13);
            this.labPathRen.TabIndex = 38;
            this.labPathRen.Text = "No path selected";
            this.labPathRen.Visible = false;
            // 
            // butSelectPathRen
            // 
            this.butSelectPathRen.Location = new System.Drawing.Point(92, 72);
            this.butSelectPathRen.Name = "butSelectPathRen";
            this.butSelectPathRen.Size = new System.Drawing.Size(75, 23);
            this.butSelectPathRen.TabIndex = 37;
            this.butSelectPathRen.Text = "Select folder";
            this.butSelectPathRen.UseVisualStyleBackColor = true;
            this.butSelectPathRen.Visible = false;
            this.butSelectPathRen.Click += new System.EventHandler(this.butSelectPathRen_Click_1);
            // 
            // labLocPathRen
            // 
            this.labLocPathRen.AutoSize = true;
            this.labLocPathRen.Location = new System.Drawing.Point(16, 72);
            this.labLocPathRen.Name = "labLocPathRen";
            this.labLocPathRen.Size = new System.Drawing.Size(58, 13);
            this.labLocPathRen.TabIndex = 36;
            this.labLocPathRen.Text = "Local Path";
            this.labLocPathRen.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 35;
            // 
            // labTimePassed
            // 
            this.labTimePassed.AutoSize = true;
            this.labTimePassed.Location = new System.Drawing.Point(19, 143);
            this.labTimePassed.Name = "labTimePassed";
            this.labTimePassed.Size = new System.Drawing.Size(0, 13);
            this.labTimePassed.TabIndex = 48;
            this.labTimePassed.Visible = false;
            // 
            // butSetTextParams
            // 
            this.butSetTextParams.Location = new System.Drawing.Point(234, 25);
            this.butSetTextParams.Name = "butSetTextParams";
            this.butSetTextParams.Size = new System.Drawing.Size(75, 23);
            this.butSetTextParams.TabIndex = 49;
            this.butSetTextParams.Text = "Set params";
            this.butSetTextParams.UseVisualStyleBackColor = true;
            this.butSetTextParams.Click += new System.EventHandler(this.butSetTextParams_Click);
            // 
            // Renamer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 140);
            this.Controls.Add(this.butSetTextParams);
            this.Controls.Add(this.labTimePassed);
            this.Controls.Add(this.labOpenAfterRename);
            this.Controls.Add(this.butOpenFolderAfterRename);
            this.Controls.Add(this.butWorkRen);
            this.Controls.Add(this.textFileExtRen);
            this.Controls.Add(this.labFileExctRen);
            this.Controls.Add(this.textCriteriaRen);
            this.Controls.Add(this.labCriteriaRen);
            this.Controls.Add(this.labPathRen);
            this.Controls.Add(this.butSelectPathRen);
            this.Controls.Add(this.labLocPathRen);
            this.Controls.Add(this.label1);
            this.Name = "Renamer";
            this.Text = "Renamer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Renamer_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labOpenAfterRename;
        private System.Windows.Forms.Button butOpenFolderAfterRename;
        private System.Windows.Forms.Button butWorkRen;
        private System.Windows.Forms.TextBox textFileExtRen;
        private System.Windows.Forms.Label labFileExctRen;
        private System.Windows.Forms.TextBox textCriteriaRen;
        private System.Windows.Forms.Label labCriteriaRen;
        private System.Windows.Forms.Label labPathRen;
        private System.Windows.Forms.Button butSelectPathRen;
        private System.Windows.Forms.Label labLocPathRen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label labTimePassed;
        private System.Windows.Forms.Button butSetTextParams;
    }
}