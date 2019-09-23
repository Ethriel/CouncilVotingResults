using System;
using System.Diagnostics;
using System.Windows.Forms;
using RenameNS;

namespace CouncilVouingResults
{
    public partial class Renamer : Form
    {
        Rename rename;
        string LocPathRen;
        string CriteriaRen;
        string FileExtRen;

        public Renamer()
        {
            InitializeComponent();
            rename = new Rename();
            MakeVisibleRen();
        }

        private void MakeVisibleRen()
        {
            labLocPathRen.Visible = true;
            butSelectPathRen.Visible = true;
            labPathRen.Visible = true;

            labCriteriaRen.Visible = true;
            textCriteriaRen.Visible = true;
            butSetCritRen.Visible = true;

            labFileExctRen.Visible = true;
            textFileExtRen.Visible = true;
            butSetFileExt.Visible = true;

            labOpenAfterRename.Visible = false;
            butOpenFolderAfterRename.Visible = false;
        }

        private void MakeInvisibleRen()
        {
            butWorkRen.Visible = false;

            labLocPathRen.Visible = false;
            butSelectPathRen.Visible = false;
            labPathRen.Visible = false;

            labCriteriaRen.Visible = false;
            textCriteriaRen.Visible = false;
            butSetCritRen.Visible = false;

            labFileExctRen.Visible = false;
            textFileExtRen.Visible = false;
            butSetFileExt.Visible = false;
            butWorkRen.Visible = false;
        }
        private bool AllParamsOkRen()
        {
            return !(string.IsNullOrWhiteSpace(LocPathRen) || string.IsNullOrWhiteSpace(CriteriaRen) || string.IsNullOrWhiteSpace(FileExtRen));
        }

        private void MakeAllTextBoxesEmptyRen()
        {
            labPathRen.Text = "No path selected";
            textCriteriaRen.Text = "";
            textFileExtRen.Text = "";
            LocPathRen = "";
            CriteriaRen = "";
            FileExtRen = "";
        }

        private void butSelectPathRen_Click_1(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                //dialog.SelectedPath = @"D:\Sesii\HTML";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    LocPathRen = dialog.SelectedPath;
                    labPathRen.Text = dialog.SelectedPath;
                }
            }
            if (AllParamsOkRen())
                butWorkRen.Visible = true;
        }

        private void butOpenFolderAfterRename_Click_1(object sender, EventArgs e)
        {
            Process.Start(LocPathRen);
        }

        private void butSetCritRen_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textCriteriaRen.Text))
            {
                MessageBox.Show("EMPTY textbox in CRITERIA");
                return;
            }
            CriteriaRen = textCriteriaRen.Text;
            if (AllParamsOkRen())
                butWorkRen.Visible = true;
        }

        private void butSetFileExt_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textFileExtRen.Text))
            {
                MessageBox.Show("EMPTY textbox in FILE EXTESION");
                return;
            }
            FileExtRen = textFileExtRen.Text;
            if (AllParamsOkRen())
                butWorkRen.Visible = true;
        }

        private void butWorkRen_Click_1(object sender, EventArgs e)
        {
            try
            {
                rename.SetParams(LocPathRen, CriteriaRen, FileExtRen);
                rename.DoRename();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Success!");
            labOpenAfterRename.Visible = true;
            butOpenFolderAfterRename.Visible = true;
        }
    }
}
