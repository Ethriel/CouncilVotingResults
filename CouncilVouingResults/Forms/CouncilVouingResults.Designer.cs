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
            this.butCreateTables = new System.Windows.Forms.Button();
            this.butAddText = new System.Windows.Forms.Button();
            this.butHelp = new System.Windows.Forms.Button();
            this.butBulkRename = new System.Windows.Forms.Button();
            this.butReplaceSymb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butCreateTables
            // 
            this.butCreateTables.Location = new System.Drawing.Point(12, 12);
            this.butCreateTables.Name = "butCreateTables";
            this.butCreateTables.Size = new System.Drawing.Size(209, 23);
            this.butCreateTables.TabIndex = 1;
            this.butCreateTables.Text = "Create HTML-table and XLSX-file";
            this.butCreateTables.UseVisualStyleBackColor = true;
            this.butCreateTables.Click += new System.EventHandler(this.button1_Click);
            // 
            // butAddText
            // 
            this.butAddText.Location = new System.Drawing.Point(227, 12);
            this.butAddText.Name = "butAddText";
            this.butAddText.Size = new System.Drawing.Size(159, 23);
            this.butAddText.TabIndex = 18;
            this.butAddText.Text = "Add text to files names";
            this.butAddText.UseVisualStyleBackColor = true;
            this.butAddText.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // butHelp
            // 
            this.butHelp.Location = new System.Drawing.Point(311, 41);
            this.butHelp.Name = "butHelp";
            this.butHelp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.butHelp.Size = new System.Drawing.Size(75, 23);
            this.butHelp.TabIndex = 19;
            this.butHelp.Text = "Help";
            this.butHelp.UseVisualStyleBackColor = true;
            this.butHelp.Click += new System.EventHandler(this.butHelp_Click);
            // 
            // butBulkRename
            // 
            this.butBulkRename.Location = new System.Drawing.Point(12, 41);
            this.butBulkRename.Name = "butBulkRename";
            this.butBulkRename.Size = new System.Drawing.Size(102, 23);
            this.butBulkRename.TabIndex = 20;
            this.butBulkRename.Text = "Bulk rename files";
            this.butBulkRename.UseVisualStyleBackColor = true;
            this.butBulkRename.Click += new System.EventHandler(this.butBulkRename_Click);
            // 
            // butReplaceSymb
            // 
            this.butReplaceSymb.Location = new System.Drawing.Point(120, 41);
            this.butReplaceSymb.Name = "butReplaceSymb";
            this.butReplaceSymb.Size = new System.Drawing.Size(185, 23);
            this.butReplaceSymb.TabIndex = 21;
            this.butReplaceSymb.Text = "Replace symbol in files names";
            this.butReplaceSymb.UseVisualStyleBackColor = true;
            this.butReplaceSymb.Click += new System.EventHandler(this.butReplaceSymb_Click);
            // 
            // CouncilVouingResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 73);
            this.Controls.Add(this.butReplaceSymb);
            this.Controls.Add(this.butBulkRename);
            this.Controls.Add(this.butHelp);
            this.Controls.Add(this.butAddText);
            this.Controls.Add(this.butCreateTables);
            this.Name = "CouncilVouingResults";
            this.Text = "Council Vouing Results";
            this.Load += new System.EventHandler(this.CouncilVouingResults_Load);
            this.Resize += new System.EventHandler(this.CouncilVouingResults_Resize);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button butCreateTables;
        private System.Windows.Forms.Button butAddText;
        private System.Windows.Forms.Button butHelp;
        private System.Windows.Forms.Button butBulkRename;
        private System.Windows.Forms.Button butReplaceSymb;
    }
}

