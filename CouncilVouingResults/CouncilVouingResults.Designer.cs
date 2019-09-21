namespace CouncilVouingResults
{
    partial class CouncilVouingResults
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
            this.butSetParamsVote = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labLocPathVote = new System.Windows.Forms.Label();
            this.vabCriteriaVote = new System.Windows.Forms.Label();
            this.textCriteriaVote = new System.Windows.Forms.TextBox();
            this.butSetCritVote = new System.Windows.Forms.Button();
            this.butWorkVote = new System.Windows.Forms.Button();
            this.labTableTitleVote = new System.Windows.Forms.Label();
            this.textTableTitleVote = new System.Windows.Forms.TextBox();
            this.setTableTitleVote = new System.Windows.Forms.Button();
            this.butSelectFolderVote = new System.Windows.Forms.Button();
            this.selectFolderDiagVote = new System.Windows.Forms.FolderBrowserDialog();
            this.labPathVote = new System.Windows.Forms.Label();
            this.labSessionNameVote = new System.Windows.Forms.Label();
            this.textSessionNameVote = new System.Windows.Forms.TextBox();
            this.butSetSessionNameVote = new System.Windows.Forms.Button();
            this.butRename = new System.Windows.Forms.Button();
            this.labLocPathRen = new System.Windows.Forms.Label();
            this.butSelectPathRen = new System.Windows.Forms.Button();
            this.labPathRen = new System.Windows.Forms.Label();
            this.labCriteriaRen = new System.Windows.Forms.Label();
            this.textCriteriaRen = new System.Windows.Forms.TextBox();
            this.labFileExctRen = new System.Windows.Forms.Label();
            this.textFileExtRen = new System.Windows.Forms.TextBox();
            this.butSetCritRen = new System.Windows.Forms.Button();
            this.butSetFileExt = new System.Windows.Forms.Button();
            this.folderBrowserDialogRen = new System.Windows.Forms.FolderBrowserDialog();
            this.butWorkRen = new System.Windows.Forms.Button();
            this.butBack = new System.Windows.Forms.Button();
            this.labPathToXLSX = new System.Windows.Forms.Label();
            this.butSlectPathXLSX = new System.Windows.Forms.Button();
            this.folderBrowserDialogXLSX = new System.Windows.Forms.FolderBrowserDialog();
            this.labSelectedPathXLSX = new System.Windows.Forms.Label();
            this.butOpenFolderAfterRename = new System.Windows.Forms.Button();
            this.labOpenAfterRename = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butSetParamsVote
            // 
            this.butSetParamsVote.Location = new System.Drawing.Point(12, 12);
            this.butSetParamsVote.Name = "butSetParamsVote";
            this.butSetParamsVote.Size = new System.Drawing.Size(180, 23);
            this.butSetParamsVote.TabIndex = 1;
            this.butSetParamsVote.Text = "Create HTML-table and XLSX-file";
            this.butSetParamsVote.UseVisualStyleBackColor = true;
            this.butSetParamsVote.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // labLocPathVote
            // 
            this.labLocPathVote.AutoSize = true;
            this.labLocPathVote.Location = new System.Drawing.Point(13, 114);
            this.labLocPathVote.Name = "labLocPathVote";
            this.labLocPathVote.Size = new System.Drawing.Size(58, 13);
            this.labLocPathVote.TabIndex = 5;
            this.labLocPathVote.Text = "Local Path";
            this.labLocPathVote.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labLocPathVote.Visible = false;
            // 
            // vabCriteriaVote
            // 
            this.vabCriteriaVote.AutoSize = true;
            this.vabCriteriaVote.Location = new System.Drawing.Point(32, 89);
            this.vabCriteriaVote.Name = "vabCriteriaVote";
            this.vabCriteriaVote.Size = new System.Drawing.Size(39, 13);
            this.vabCriteriaVote.TabIndex = 5;
            this.vabCriteriaVote.Text = "Criteria";
            this.vabCriteriaVote.Visible = false;
            // 
            // textCriteriaVote
            // 
            this.textCriteriaVote.Location = new System.Drawing.Point(12, 66);
            this.textCriteriaVote.Name = "textCriteriaVote";
            this.textCriteriaVote.Size = new System.Drawing.Size(84, 20);
            this.textCriteriaVote.TabIndex = 2;
            this.textCriteriaVote.Visible = false;
            // 
            // butSetCritVote
            // 
            this.butSetCritVote.Location = new System.Drawing.Point(637, 67);
            this.butSetCritVote.Name = "butSetCritVote";
            this.butSetCritVote.Size = new System.Drawing.Size(75, 23);
            this.butSetCritVote.TabIndex = 7;
            this.butSetCritVote.Text = "Set Criteria";
            this.butSetCritVote.UseVisualStyleBackColor = true;
            this.butSetCritVote.Visible = false;
            this.butSetCritVote.Click += new System.EventHandler(this.sendCrit_Click);
            // 
            // butWorkVote
            // 
            this.butWorkVote.Location = new System.Drawing.Point(212, 12);
            this.butWorkVote.Name = "butWorkVote";
            this.butWorkVote.Size = new System.Drawing.Size(113, 23);
            this.butWorkVote.TabIndex = 9;
            this.butWorkVote.Text = "Start Table Creation";
            this.butWorkVote.UseVisualStyleBackColor = true;
            this.butWorkVote.Visible = false;
            this.butWorkVote.Click += new System.EventHandler(this.Work_Click);
            // 
            // labTableTitleVote
            // 
            this.labTableTitleVote.AutoSize = true;
            this.labTableTitleVote.Location = new System.Drawing.Point(561, 92);
            this.labTableTitleVote.Name = "labTableTitleVote";
            this.labTableTitleVote.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labTableTitleVote.Size = new System.Drawing.Size(57, 13);
            this.labTableTitleVote.TabIndex = 10;
            this.labTableTitleVote.Text = "Table Title";
            this.labTableTitleVote.Visible = false;
            // 
            // textTableTitleVote
            // 
            this.textTableTitleVote.Location = new System.Drawing.Point(547, 66);
            this.textTableTitleVote.Name = "textTableTitleVote";
            this.textTableTitleVote.Size = new System.Drawing.Size(84, 20);
            this.textTableTitleVote.TabIndex = 11;
            this.textTableTitleVote.Visible = false;
            // 
            // setTableTitleVote
            // 
            this.setTableTitleVote.Location = new System.Drawing.Point(637, 92);
            this.setTableTitleVote.Name = "setTableTitleVote";
            this.setTableTitleVote.Size = new System.Drawing.Size(75, 23);
            this.setTableTitleVote.TabIndex = 12;
            this.setTableTitleVote.Text = "Set Title";
            this.setTableTitleVote.UseVisualStyleBackColor = true;
            this.setTableTitleVote.Visible = false;
            this.setTableTitleVote.Click += new System.EventHandler(this.sendTableTitle_Click);
            // 
            // butSelectFolderVote
            // 
            this.butSelectFolderVote.Location = new System.Drawing.Point(92, 109);
            this.butSelectFolderVote.Name = "butSelectFolderVote";
            this.butSelectFolderVote.Size = new System.Drawing.Size(75, 23);
            this.butSelectFolderVote.TabIndex = 13;
            this.butSelectFolderVote.Text = "Select folder";
            this.butSelectFolderVote.UseVisualStyleBackColor = true;
            this.butSelectFolderVote.Visible = false;
            this.butSelectFolderVote.Click += new System.EventHandler(this.selectFolder_Click);
            // 
            // labPathVote
            // 
            this.labPathVote.AutoSize = true;
            this.labPathVote.Location = new System.Drawing.Point(198, 114);
            this.labPathVote.Name = "labPathVote";
            this.labPathVote.Size = new System.Drawing.Size(88, 13);
            this.labPathVote.TabIndex = 14;
            this.labPathVote.Text = "No path selected";
            this.labPathVote.Visible = false;
            // 
            // labSessionNameVote
            // 
            this.labSessionNameVote.AutoSize = true;
            this.labSessionNameVote.Location = new System.Drawing.Point(297, 64);
            this.labSessionNameVote.Name = "labSessionNameVote";
            this.labSessionNameVote.Size = new System.Drawing.Size(73, 13);
            this.labSessionNameVote.TabIndex = 15;
            this.labSessionNameVote.Text = "Session name";
            this.labSessionNameVote.Visible = false;
            // 
            // textSessionNameVote
            // 
            this.textSessionNameVote.Location = new System.Drawing.Point(12, 41);
            this.textSessionNameVote.Name = "textSessionNameVote";
            this.textSessionNameVote.Size = new System.Drawing.Size(619, 20);
            this.textSessionNameVote.TabIndex = 16;
            this.textSessionNameVote.Visible = false;
            // 
            // butSetSessionNameVote
            // 
            this.butSetSessionNameVote.Location = new System.Drawing.Point(637, 39);
            this.butSetSessionNameVote.Name = "butSetSessionNameVote";
            this.butSetSessionNameVote.Size = new System.Drawing.Size(75, 23);
            this.butSetSessionNameVote.TabIndex = 17;
            this.butSetSessionNameVote.Text = "Set Name";
            this.butSetSessionNameVote.UseVisualStyleBackColor = true;
            this.butSetSessionNameVote.Visible = false;
            this.butSetSessionNameVote.Click += new System.EventHandler(this.sendSessionName_Click);
            // 
            // butRename
            // 
            this.butRename.Location = new System.Drawing.Point(543, 12);
            this.butRename.Name = "butRename";
            this.butRename.Size = new System.Drawing.Size(75, 23);
            this.butRename.TabIndex = 18;
            this.butRename.Text = "Rename";
            this.butRename.UseVisualStyleBackColor = true;
            this.butRename.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // labLocPathRen
            // 
            this.labLocPathRen.AutoSize = true;
            this.labLocPathRen.Location = new System.Drawing.Point(13, 149);
            this.labLocPathRen.Name = "labLocPathRen";
            this.labLocPathRen.Size = new System.Drawing.Size(58, 13);
            this.labLocPathRen.TabIndex = 19;
            this.labLocPathRen.Text = "Local Path";
            this.labLocPathRen.Visible = false;
            // 
            // butSelectPathRen
            // 
            this.butSelectPathRen.Location = new System.Drawing.Point(92, 149);
            this.butSelectPathRen.Name = "butSelectPathRen";
            this.butSelectPathRen.Size = new System.Drawing.Size(75, 23);
            this.butSelectPathRen.TabIndex = 20;
            this.butSelectPathRen.Text = "Select folder";
            this.butSelectPathRen.UseVisualStyleBackColor = true;
            this.butSelectPathRen.Visible = false;
            this.butSelectPathRen.Click += new System.EventHandler(this.butSelectPathRen_Click);
            // 
            // labPathRen
            // 
            this.labPathRen.AutoSize = true;
            this.labPathRen.Location = new System.Drawing.Point(198, 154);
            this.labPathRen.Name = "labPathRen";
            this.labPathRen.Size = new System.Drawing.Size(88, 13);
            this.labPathRen.TabIndex = 21;
            this.labPathRen.Text = "No path selected";
            this.labPathRen.Visible = false;
            // 
            // labCriteriaRen
            // 
            this.labCriteriaRen.AutoSize = true;
            this.labCriteriaRen.Location = new System.Drawing.Point(16, 191);
            this.labCriteriaRen.Name = "labCriteriaRen";
            this.labCriteriaRen.Size = new System.Drawing.Size(39, 13);
            this.labCriteriaRen.TabIndex = 22;
            this.labCriteriaRen.Text = "Criteria";
            this.labCriteriaRen.Visible = false;
            // 
            // textCriteriaRen
            // 
            this.textCriteriaRen.Location = new System.Drawing.Point(92, 188);
            this.textCriteriaRen.Name = "textCriteriaRen";
            this.textCriteriaRen.Size = new System.Drawing.Size(127, 20);
            this.textCriteriaRen.TabIndex = 23;
            this.textCriteriaRen.Visible = false;
            // 
            // labFileExctRen
            // 
            this.labFileExctRen.AutoSize = true;
            this.labFileExctRen.Location = new System.Drawing.Point(16, 221);
            this.labFileExctRen.Name = "labFileExctRen";
            this.labFileExctRen.Size = new System.Drawing.Size(71, 13);
            this.labFileExctRen.TabIndex = 24;
            this.labFileExctRen.Text = "File extension";
            this.labFileExctRen.Visible = false;
            // 
            // textFileExtRen
            // 
            this.textFileExtRen.Location = new System.Drawing.Point(92, 218);
            this.textFileExtRen.Name = "textFileExtRen";
            this.textFileExtRen.Size = new System.Drawing.Size(100, 20);
            this.textFileExtRen.TabIndex = 25;
            this.textFileExtRen.Visible = false;
            // 
            // butSetCritRen
            // 
            this.butSetCritRen.Location = new System.Drawing.Point(234, 185);
            this.butSetCritRen.Name = "butSetCritRen";
            this.butSetCritRen.Size = new System.Drawing.Size(75, 23);
            this.butSetCritRen.TabIndex = 26;
            this.butSetCritRen.Text = "Set Criteria";
            this.butSetCritRen.UseVisualStyleBackColor = true;
            this.butSetCritRen.Visible = false;
            this.butSetCritRen.Click += new System.EventHandler(this.butSetCritRen_Click);
            // 
            // butSetFileExt
            // 
            this.butSetFileExt.Location = new System.Drawing.Point(234, 216);
            this.butSetFileExt.Name = "butSetFileExt";
            this.butSetFileExt.Size = new System.Drawing.Size(75, 23);
            this.butSetFileExt.TabIndex = 27;
            this.butSetFileExt.Text = "Set Ext";
            this.butSetFileExt.UseVisualStyleBackColor = true;
            this.butSetFileExt.Visible = false;
            this.butSetFileExt.Click += new System.EventHandler(this.butSetFileExt_Click);
            // 
            // butWorkRen
            // 
            this.butWorkRen.Location = new System.Drawing.Point(624, 12);
            this.butWorkRen.Name = "butWorkRen";
            this.butWorkRen.Size = new System.Drawing.Size(93, 23);
            this.butWorkRen.TabIndex = 28;
            this.butWorkRen.Text = "Rename Files";
            this.butWorkRen.UseVisualStyleBackColor = true;
            this.butWorkRen.Visible = false;
            this.butWorkRen.Click += new System.EventHandler(this.butWorkRen_Click);
            // 
            // butBack
            // 
            this.butBack.Location = new System.Drawing.Point(331, 13);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(75, 23);
            this.butBack.TabIndex = 29;
            this.butBack.Text = "Back";
            this.butBack.UseVisualStyleBackColor = true;
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // labPathToXLSX
            // 
            this.labPathToXLSX.AutoSize = true;
            this.labPathToXLSX.Location = new System.Drawing.Point(294, 114);
            this.labPathToXLSX.Name = "labPathToXLSX";
            this.labPathToXLSX.Size = new System.Drawing.Size(61, 13);
            this.labPathToXLSX.TabIndex = 30;
            this.labPathToXLSX.Text = "Path to xlsx";
            this.labPathToXLSX.Visible = false;
            // 
            // butSlectPathXLSX
            // 
            this.butSlectPathXLSX.Location = new System.Drawing.Point(361, 109);
            this.butSlectPathXLSX.Name = "butSlectPathXLSX";
            this.butSlectPathXLSX.Size = new System.Drawing.Size(75, 23);
            this.butSlectPathXLSX.TabIndex = 31;
            this.butSlectPathXLSX.Text = "Select folder";
            this.butSlectPathXLSX.UseVisualStyleBackColor = true;
            this.butSlectPathXLSX.Visible = false;
            this.butSlectPathXLSX.Click += new System.EventHandler(this.butSlectPathXSLX_Click);
            // 
            // labSelectedPathXLSX
            // 
            this.labSelectedPathXLSX.AutoSize = true;
            this.labSelectedPathXLSX.Location = new System.Drawing.Point(442, 114);
            this.labSelectedPathXLSX.Name = "labSelectedPathXLSX";
            this.labSelectedPathXLSX.Size = new System.Drawing.Size(88, 13);
            this.labSelectedPathXLSX.TabIndex = 32;
            this.labSelectedPathXLSX.Text = "No path selected";
            this.labSelectedPathXLSX.Visible = false;
            // 
            // butOpenFolderAfterRename
            // 
            this.butOpenFolderAfterRename.Location = new System.Drawing.Point(361, 149);
            this.butOpenFolderAfterRename.Name = "butOpenFolderAfterRename";
            this.butOpenFolderAfterRename.Size = new System.Drawing.Size(75, 23);
            this.butOpenFolderAfterRename.TabIndex = 33;
            this.butOpenFolderAfterRename.Text = "Open folder";
            this.butOpenFolderAfterRename.UseVisualStyleBackColor = true;
            this.butOpenFolderAfterRename.Visible = false;
            this.butOpenFolderAfterRename.Click += new System.EventHandler(this.butOpenFolderAfterRename_Click);
            // 
            // labOpenAfterRename
            // 
            this.labOpenAfterRename.AutoSize = true;
            this.labOpenAfterRename.Location = new System.Drawing.Point(289, 154);
            this.labOpenAfterRename.Name = "labOpenAfterRename";
            this.labOpenAfterRename.Size = new System.Drawing.Size(59, 13);
            this.labOpenAfterRename.TabIndex = 34;
            this.labOpenAfterRename.Text = "See results";
            this.labOpenAfterRename.Visible = false;
            // 
            // CouncilVouingResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 259);
            this.Controls.Add(this.labOpenAfterRename);
            this.Controls.Add(this.butOpenFolderAfterRename);
            this.Controls.Add(this.labSelectedPathXLSX);
            this.Controls.Add(this.butSlectPathXLSX);
            this.Controls.Add(this.labPathToXLSX);
            this.Controls.Add(this.butBack);
            this.Controls.Add(this.butWorkRen);
            this.Controls.Add(this.butSetFileExt);
            this.Controls.Add(this.butSetCritRen);
            this.Controls.Add(this.textFileExtRen);
            this.Controls.Add(this.labFileExctRen);
            this.Controls.Add(this.textCriteriaRen);
            this.Controls.Add(this.labCriteriaRen);
            this.Controls.Add(this.labPathRen);
            this.Controls.Add(this.butSelectPathRen);
            this.Controls.Add(this.labLocPathRen);
            this.Controls.Add(this.butRename);
            this.Controls.Add(this.butSetSessionNameVote);
            this.Controls.Add(this.textSessionNameVote);
            this.Controls.Add(this.labSessionNameVote);
            this.Controls.Add(this.labPathVote);
            this.Controls.Add(this.butSelectFolderVote);
            this.Controls.Add(this.setTableTitleVote);
            this.Controls.Add(this.textTableTitleVote);
            this.Controls.Add(this.labTableTitleVote);
            this.Controls.Add(this.butWorkVote);
            this.Controls.Add(this.butSetCritVote);
            this.Controls.Add(this.vabCriteriaVote);
            this.Controls.Add(this.labLocPathVote);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textCriteriaVote);
            this.Controls.Add(this.butSetParamsVote);
            this.Name = "CouncilVouingResults";
            this.Text = "CouncilVouingResults";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button butSetParamsVote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labLocPathVote;
        private System.Windows.Forms.Label vabCriteriaVote;
        private System.Windows.Forms.TextBox textCriteriaVote;
        private System.Windows.Forms.Button butSetCritVote;
        private System.Windows.Forms.Button butWorkVote;
        private System.Windows.Forms.Label labTableTitleVote;
        private System.Windows.Forms.TextBox textTableTitleVote;
        private System.Windows.Forms.Button setTableTitleVote;
        private System.Windows.Forms.Button butSelectFolderVote;
        private System.Windows.Forms.FolderBrowserDialog selectFolderDiagVote;
        private System.Windows.Forms.Label labPathVote;
        private System.Windows.Forms.Label labSessionNameVote;
        private System.Windows.Forms.TextBox textSessionNameVote;
        private System.Windows.Forms.Button butSetSessionNameVote;
        private System.Windows.Forms.Button butRename;
        private System.Windows.Forms.Label labLocPathRen;
        private System.Windows.Forms.Button butSelectPathRen;
        private System.Windows.Forms.Label labPathRen;
        private System.Windows.Forms.Label labCriteriaRen;
        private System.Windows.Forms.TextBox textCriteriaRen;
        private System.Windows.Forms.Label labFileExctRen;
        private System.Windows.Forms.TextBox textFileExtRen;
        private System.Windows.Forms.Button butSetCritRen;
        private System.Windows.Forms.Button butSetFileExt;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogRen;
        private System.Windows.Forms.Button butWorkRen;
        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.Label labPathToXLSX;
        private System.Windows.Forms.Button butSlectPathXLSX;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogXLSX;
        private System.Windows.Forms.Label labSelectedPathXLSX;
        private System.Windows.Forms.Button butOpenFolderAfterRename;
        private System.Windows.Forms.Label labOpenAfterRename;
    }
}

