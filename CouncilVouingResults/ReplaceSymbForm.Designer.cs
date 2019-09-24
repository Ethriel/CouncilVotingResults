namespace CouncilVouingResults
{
    partial class ReplaceSymbForm
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
            this.labWhat = new System.Windows.Forms.Label();
            this.labOnto = new System.Windows.Forms.Label();
            this.butSelectFolder = new System.Windows.Forms.Button();
            this.butStart = new System.Windows.Forms.Button();
            this.butShowResults = new System.Windows.Forms.Button();
            this.textWhat = new System.Windows.Forms.TextBox();
            this.textOnto = new System.Windows.Forms.TextBox();
            this.butSetParams = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labWhat
            // 
            this.labWhat.AutoSize = true;
            this.labWhat.Location = new System.Drawing.Point(13, 12);
            this.labWhat.Name = "labWhat";
            this.labWhat.Size = new System.Drawing.Size(33, 13);
            this.labWhat.TabIndex = 0;
            this.labWhat.Text = "What";
            // 
            // labOnto
            // 
            this.labOnto.AutoSize = true;
            this.labOnto.Location = new System.Drawing.Point(13, 39);
            this.labOnto.Name = "labOnto";
            this.labOnto.Size = new System.Drawing.Size(30, 13);
            this.labOnto.TabIndex = 1;
            this.labOnto.Text = "Onto";
            // 
            // butSelectFolder
            // 
            this.butSelectFolder.Location = new System.Drawing.Point(16, 65);
            this.butSelectFolder.Name = "butSelectFolder";
            this.butSelectFolder.Size = new System.Drawing.Size(75, 23);
            this.butSelectFolder.TabIndex = 2;
            this.butSelectFolder.Text = "Select folder";
            this.butSelectFolder.UseVisualStyleBackColor = true;
            this.butSelectFolder.Click += new System.EventHandler(this.butSelectFolder_Click);
            // 
            // butStart
            // 
            this.butStart.Location = new System.Drawing.Point(159, 39);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(75, 23);
            this.butStart.TabIndex = 3;
            this.butStart.Text = "Start";
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Visible = false;
            this.butStart.Click += new System.EventHandler(this.butStart_Click);
            // 
            // butShowResults
            // 
            this.butShowResults.Location = new System.Drawing.Point(159, 65);
            this.butShowResults.Name = "butShowResults";
            this.butShowResults.Size = new System.Drawing.Size(75, 23);
            this.butShowResults.TabIndex = 4;
            this.butShowResults.Text = "Show results";
            this.butShowResults.UseVisualStyleBackColor = true;
            this.butShowResults.Visible = false;
            this.butShowResults.Click += new System.EventHandler(this.butShowResults_Click);
            // 
            // textWhat
            // 
            this.textWhat.Location = new System.Drawing.Point(53, 12);
            this.textWhat.Name = "textWhat";
            this.textWhat.Size = new System.Drawing.Size(100, 20);
            this.textWhat.TabIndex = 5;
            // 
            // textOnto
            // 
            this.textOnto.Location = new System.Drawing.Point(53, 39);
            this.textOnto.Name = "textOnto";
            this.textOnto.Size = new System.Drawing.Size(100, 20);
            this.textOnto.TabIndex = 6;
            // 
            // butSetParams
            // 
            this.butSetParams.Location = new System.Drawing.Point(160, 8);
            this.butSetParams.Name = "butSetParams";
            this.butSetParams.Size = new System.Drawing.Size(75, 23);
            this.butSetParams.TabIndex = 7;
            this.butSetParams.Text = "Set params";
            this.butSetParams.UseVisualStyleBackColor = true;
            this.butSetParams.Click += new System.EventHandler(this.butSetParams_Click);
            // 
            // ReplaceSymbForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 105);
            this.Controls.Add(this.butSetParams);
            this.Controls.Add(this.textOnto);
            this.Controls.Add(this.textWhat);
            this.Controls.Add(this.butShowResults);
            this.Controls.Add(this.butStart);
            this.Controls.Add(this.butSelectFolder);
            this.Controls.Add(this.labOnto);
            this.Controls.Add(this.labWhat);
            this.Name = "ReplaceSymbForm";
            this.Text = "Replace Symb";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReplaceSymbForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labWhat;
        private System.Windows.Forms.Label labOnto;
        private System.Windows.Forms.Button butSelectFolder;
        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.Button butShowResults;
        private System.Windows.Forms.TextBox textWhat;
        private System.Windows.Forms.TextBox textOnto;
        private System.Windows.Forms.Button butSetParams;
    }
}