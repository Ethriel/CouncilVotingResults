using System;
using System.Diagnostics;
using System.Windows.Forms;
using RenameNS;

namespace CouncilVouingResults
{
    public partial class Renamer : Form
    {
        Rename RenameWork;
        string LocPathRen;
        CouncilVouingResults BaseForm;

        public Renamer()
        {
            InitializeComponent();
            RenameWork = new Rename();
            MakeVisibleRen();
            BaseForm = new CouncilVouingResults();
        }
        public Renamer(CouncilVouingResults e)
        {
            InitializeComponent();
            RenameWork = new Rename();
            MakeVisibleRen();
            BaseForm = e;
        }
        private void MakeVisibleRen()
        {
            labLocPathRen.Visible = true;
            butSelectPathRen.Visible = true;
            labPathRen.Visible = true;

            labCriteriaRen.Visible = true;
            textCriteriaRen.Visible = true;

            labFileExctRen.Visible = true;
            textFileExtRen.Visible = true;

            labOpenAfterRename.Visible = false;
            butOpenFolderAfterRename.Visible = false;
        }

        private void butSelectPathRen_Click_1(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    LocPathRen = dialog.SelectedPath;
                    labPathRen.Text = dialog.SelectedPath;
                }
            }
        }

        private void butOpenFolderAfterRename_Click_1(object sender, EventArgs e)
        {
            Process.Start(LocPathRen);
        }

        private void butWorkRen_Click_1(object sender, EventArgs e)
        {
            try
            {
                var Watch = Stopwatch.StartNew();
                RenameWork.SetParams(LocPathRen, textCriteriaRen.Text, textFileExtRen.Text);
                Watch.Stop();
                labTimePassed.Text = $"Time passed: {Watch.ElapsedMilliseconds} ms";
                MessageBox.Show("Success!");
                labTimePassed.Visible = true;
                labOpenAfterRename.Visible = true;
                butOpenFolderAfterRename.Visible = true;
            }
            catch (Exception ex)
            {
                string mess = ex.Message + $". Time: {DateTime.Now}\n";
                mess += $"Call stack: {ex.StackTrace}";
                MessageBox.Show(mess);
            }
        }

        private void Renamer_FormClosed(object sender, FormClosedEventArgs e)
        {
            BaseForm.SetButtonRenamer(true);
        }

        private void butSetTextParams_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textCriteriaRen.Text))
            {
                MessageBox.Show("EMPTY textbox in CRITERIA");
                return;
            }
            if (string.IsNullOrEmpty(textFileExtRen.Text))
            {
                MessageBox.Show("EMPTY textbox in FILE EXTESION");
                return;
            }
            if (string.IsNullOrEmpty(LocPathRen))
            {
                MessageBox.Show("NO PATH SELECTED");
                return;
            }
            if (AllParamsOkRen())
                butWorkRen.Visible = true;
        }

        private bool AllParamsOkRen()
        {
            return !(string.IsNullOrEmpty(textCriteriaRen.Text) || string.IsNullOrEmpty(textFileExtRen.Text) || string.IsNullOrEmpty(LocPathRen));
        }
    }
}
