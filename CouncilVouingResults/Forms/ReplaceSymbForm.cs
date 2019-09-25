using System;
using System.Windows.Forms;
using ReplaceSymbNS;
using System.Diagnostics;
using CouncilVouingResults.Classes;

namespace CouncilVouingResults
{
    public partial class ReplaceSymbForm : Form
    {
        string LocalPath;
        CouncilVouingResults BaseForm;
        ReplaceSymb ReplaceSymbWork;
        Resize FormResize;

        public ReplaceSymbForm()
        {
            InitializeComponent();
            LocalPath = "";
            BaseForm = new CouncilVouingResults();
            ReplaceSymbWork = new ReplaceSymb();
            FormResize = new Resize(this);
            Load += new EventHandler(ReplaceSymbForm_Load);
        }

        public ReplaceSymbForm(CouncilVouingResults e)
        {
            InitializeComponent();
            LocalPath = "";
            BaseForm = e;
            ReplaceSymbWork = new ReplaceSymb();
            FormResize = new Resize(this);
            Load += new EventHandler(ReplaceSymbForm_Load);
        }

        private void butSetParams_Click(object sender, EventArgs e)
        {
            if (!AllParamsOk())
            {
                MessageBox.Show("Some params are EMPTY");
                return;
            }
            butStart.Visible = true;
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

        private void butStart_Click(object sender, EventArgs e)
        {
            try
            {
                ReplaceSymbWork.SetParams(LocalPath, textWhat.Text, textOnto.Text);
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

        private bool AllParamsOk()
        {
            return !(string.IsNullOrEmpty(textWhat.Text) || string.IsNullOrEmpty(textOnto.Text) || string.IsNullOrEmpty(LocalPath));
        }

        private void ReplaceSymbForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            BaseForm.SetButtonReplaceSymb(true);
        }

        private void butShowResults_Click(object sender, EventArgs e)
        {
            Process.Start(LocalPath);
        }

        private void ReplaceSymbForm_Load(object sender, EventArgs e)
        {
            FormResize.GetInitialSize();
        }

        private void ReplaceSymbForm_Resize(object sender, EventArgs e)
        {
            FormResize.DoResize();
        }
    }
}
