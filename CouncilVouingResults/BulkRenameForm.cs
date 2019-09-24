using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BulkRenameNS;
using System.Diagnostics;

namespace CouncilVouingResults
{
    public partial class BulkRenameForm : Form
    {
        string LocalPath;
        BulkRename BulkRenameWork;
        CouncilVouingResults BaseForm;
        public BulkRenameForm()
        {
            InitializeComponent();
            BulkRenameWork = new BulkRename();
            BaseForm = new CouncilVouingResults();
        }
        public BulkRenameForm(CouncilVouingResults e)
        {
            InitializeComponent();
            BulkRenameWork = new BulkRename();
            BaseForm = e;
        }

        private void butSetParams_Click(object sender, EventArgs e)
        {
            if(!AllParamsOk())
            {
                MessageBox.Show("Some fields are EMPTY or NO FOLDER SELECTED");
                return;
            }
            butRename.Visible = true;
        }

        private void butSelectFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    LocalPath = dialog.SelectedPath;
                }
            }
        }

        private bool AllParamsOk()
        {
            return !(string.IsNullOrWhiteSpace(LocalPath) || string.IsNullOrWhiteSpace(textFileExt.Text) || string.IsNullOrWhiteSpace(textReplaceWord.Text));
        }

        private void butRename_Click(object sender, EventArgs e)
        {
            try
            {
                BulkRenameWork.SetParams(LocalPath, textFileExt.Text, textReplaceWord.Text);
                MessageBox.Show("Success!");
                butShowResults.Visible = true;
            }
            catch(Exception ex)
            {
                string mess = ex.Message + $". Time: {DateTime.Now}\n";
                mess += $"Call stack: {ex.StackTrace}";
                MessageBox.Show(mess);
            }
        }

        private void butShowResults_Click(object sender, EventArgs e)
        {
            Process.Start(LocalPath);
        }

        private void BulkRenameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            BaseForm.SetButtonBulkRename(true);
        }
    }
}
