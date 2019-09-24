using System;
using System.Diagnostics;
using System.Windows.Forms;
using AddTextNS;

namespace CouncilVouingResults
{
    public partial class AddTextToFilesNames : Form
    {
        AddTextToNames RenameWork;
        string LocPathRen;
        CouncilVouingResults BaseForm;

        public AddTextToFilesNames()
        {
            InitializeComponent();
            RenameWork = new AddTextToNames();
            MakeVisibleRen();
            BaseForm = new CouncilVouingResults();
        }
        public AddTextToFilesNames(CouncilVouingResults e)
        {
            InitializeComponent();
            RenameWork = new AddTextToNames();
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
            BaseForm.SetButtonAddText(true);
        }

        private void butSetTextParams_Click(object sender, EventArgs e)
        {
            if (!AllParamsOkRen())
            {
                MessageBox.Show("Some parameters are EMPTY");
                return;
            }
                butWorkRen.Visible = true;
        }

        private bool AllParamsOkRen()
        {
            return !(string.IsNullOrEmpty(textCriteriaRen.Text) || string.IsNullOrEmpty(textFileExtRen.Text) || string.IsNullOrEmpty(LocPathRen));
        }
    }
}
