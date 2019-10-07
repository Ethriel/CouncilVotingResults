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
        string PathToJSON;
        bool TablesCreated;

        public TablesCreator()
        {
            InitializeComponent();
            TableWork = new CreateTable();
            MakeVisibleTable();
            BaseForm = new CouncilVouingResults();
            TablesCreated = false;
        }

        public TablesCreator(CouncilVouingResults e)
        {
            InitializeComponent();
            TableWork = new CreateTable();
            MakeVisibleTable();
            BaseForm = e;
            TablesCreated = false;
        }

        private void MakeVisibleTable()
        {
            labLocPathVote.Visible = true;
            butSelectFolderVote.Visible = true;

            vabCriteriaVote.Visible = true;
            textCriteriaVote.Visible = true;

            labTableTitleVote.Visible = true;
            textTableTitleVote.Visible = true;

            labSessionNameVote.Visible = true;
            textSessionNameVote.Visible = true;

            butSlectPathXLSX.Visible = true;
            labPathToXLSX.Visible = true;
        }

        private void butSelectFolderVote_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    LocPathVote = dialog.SelectedPath;
                    labPathLocalText.Text = dialog.SelectedPath;
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
                }
                labPathXlsxText.Text = dialog.SelectedPath;
            }
        }

        private void butWorkVote_Click(object sender, EventArgs e)
        {
            try
            {
                var Watch = Stopwatch.StartNew();
                TableWork.SetParams(LocPathVote, textCriteriaVote.Text, textTableTitleVote.Text, textSessionNameVote.Text, PathToXLSX);
                TableWork.Work();
                Watch.Stop();
                MessageBox.Show("Tables created!", "All OK");
                labTimePassed.Visible = true;
                labTimePassed.Text = $"Time passed: {Watch.ElapsedMilliseconds} ms";
                TablesCreated = true;
                if(!string.IsNullOrEmpty(PathToJSON))
                    butWriteToJson.Visible = true;
            }
            catch (Exception ex)
            {
                string mess = "Error during tables creation operation:\n" + ex.Message + $"\n. Time: {DateTime.Now}\n";
                mess += $"Call stack: {ex.StackTrace}";
                MessageBox.Show(mess, "Error");
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
                MessageBox.Show("Some parameters are EMPTY", "Error");
                return;
            }
            butWorkVote.Visible = true;
        }

        private bool AllParamsOkVote()
        {
            return !(string.IsNullOrWhiteSpace(textSessionNameVote.Text) || string.IsNullOrWhiteSpace(textCriteriaVote.Text)
                || string.IsNullOrWhiteSpace(textTableTitleVote.Text) || string.IsNullOrWhiteSpace(LocPathVote) || string.IsNullOrWhiteSpace(PathToXLSX));
        }

        private void butWriteToJson_Click(object sender, EventArgs e)
        {
            try
            {
                TableWork.SetJsonPath(PathToJSON);
                TableWork.WriteTOJSON();
                MessageBox.Show("JSON file was created", "All OK");
                butSaveReadableJson.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during JSON operation:\n" + $". Time: {DateTime.Now}\n" + ex.Message, "Error");
            }
        }

        private void butPathToJSON_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    PathToJSON = dialog.SelectedPath;
                    labPathJsonText.Text = dialog.SelectedPath;
                }
                if(TablesCreated)
                    butWriteToJson.Visible = true;
                
            }
        }

        private void butSaveReadableJson_Click(object sender, EventArgs e)
        {
            try
            {
                TableWork.CreateReadableJson();
                MessageBox.Show("Readable JSON file was created", "All OK");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during creating readable JSON file: " + ex.Message, "Error");
            }
        }
    }
}
