using System;
using System.Diagnostics;
using System.Windows.Forms;
using HTMLNS;

namespace CouncilVouingResults
{
    public partial class TablesCreator : Form
    {
        CreateTable TableWork;
        CouncilVouingResults BaseForm;
        string LocPathVote;
        string PathToXLSX;

        public TablesCreator()
        {
            InitializeComponent();
            TableWork = new CreateTable();
            MakeVisibleTable();
            BaseForm = new CouncilVouingResults();
        }

        public TablesCreator(CouncilVouingResults e)
        {
            InitializeComponent();
            TableWork = new CreateTable();
            MakeVisibleTable();
            BaseForm = e;
        }

        private void MakeVisibleTable()
        {
            labLocPathVote.Visible = true;
            butSelectFolderVote.Visible = true;
            labPathVote.Visible = true;

            vabCriteriaVote.Visible = true;
            textCriteriaVote.Visible = true;

            labTableTitleVote.Visible = true;
            textTableTitleVote.Visible = true;

            labSessionNameVote.Visible = true;
            textSessionNameVote.Visible = true;

            butSlectPathXLSX.Visible = true;
            labPathToXLSX.Visible = true;
            labSelectedPathXLSX.Visible = true;
        }

        private void butSelectFolderVote_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    LocPathVote = dialog.SelectedPath;
                    labPathVote.Text = dialog.SelectedPath;
                }
            }
        }

        private void butSlectPathXLSX_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    PathToXLSX = dialog.SelectedPath;
                    labSelectedPathXLSX.Text = dialog.SelectedPath;
                }
            }
        }

        private void butWorkVote_Click(object sender, EventArgs e)
        {
            try
            {
                var Watch = Stopwatch.StartNew();
                TableWork.SetParams(LocPathVote, textCriteriaVote.Text, textTableTitleVote.Text, textSessionNameVote.Text, PathToXLSX);
                Watch.Stop();
                MessageBox.Show("Success!");
                labTimePassed.Visible = true;
                labTimePassed.Text = $"Time passed: {Watch.ElapsedMilliseconds} ms";
            }
            catch (Exception ex)
            {
                string mess = ex.Message + $". Time: {DateTime.Now}\n";
                mess += $"Call stack: {ex.StackTrace}";
                MessageBox.Show(mess);
            }
        }

        private void TablesCreator_FormClosed(object sender, FormClosedEventArgs e)
        {
            BaseForm.SetButtonCreateTable(true);
        }

        private void butSetParams_Click(object sender, EventArgs e)
        {
            if (!AllParamsOkVote())
            {
                MessageBox.Show("Some parameters are EMPTY");
                return;
            }
            butWorkVote.Visible = true;
        }

        private bool AllParamsOkVote()
        {
            return !(string.IsNullOrWhiteSpace(textSessionNameVote.Text) || string.IsNullOrWhiteSpace(textCriteriaVote.Text)
                || string.IsNullOrWhiteSpace(textTableTitleVote.Text) || string.IsNullOrWhiteSpace(LocPathVote) || string.IsNullOrWhiteSpace(PathToXLSX));
        }
    }
}
