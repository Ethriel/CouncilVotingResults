using System;
using System.Windows.Forms;
using HTMLNS;

namespace CouncilVouingResults
{
    public partial class TablesCreator : Form
    {
        CreateTable TableWork;
        CouncilVouingResults BaseForm;
        string LocPathVote;
        string CriteriaVote;
        string SessNameVote;
        string TitleVote;
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
            butSetCritVote.Visible = true;

            labTableTitleVote.Visible = true;
            textTableTitleVote.Visible = true;
            setTableTitleVote.Visible = true;

            labSessionNameVote.Visible = true;
            textSessionNameVote.Visible = true;
            butSetSessionNameVote.Visible = true;

            butSlectPathXLSX.Visible = true;
            labPathToXLSX.Visible = true;
            labSelectedPathXLSX.Visible = true;
        }

        private void MakeInvisibleTable()
        {
            butWorkVote.Visible = false;

            labLocPathVote.Visible = false;
            butSelectFolderVote.Visible = false;
            labPathVote.Visible = false;

            vabCriteriaVote.Visible = false;
            textCriteriaVote.Visible = false;
            butSetCritVote.Visible = false;

            labTableTitleVote.Visible = false;
            textTableTitleVote.Visible = false;
            setTableTitleVote.Visible = false;

            labSessionNameVote.Visible = false;
            textSessionNameVote.Visible = false;
            butSetSessionNameVote.Visible = false;

            butSlectPathXLSX.Visible = false;
            labPathToXLSX.Visible = false;
            labSelectedPathXLSX.Visible = false;
        }


        private bool AllParamsOkVote()
        {
            return !(string.IsNullOrWhiteSpace(LocPathVote) || string.IsNullOrWhiteSpace(CriteriaVote) || string.IsNullOrWhiteSpace(SessNameVote)
                || string.IsNullOrWhiteSpace(TitleVote) || string.IsNullOrWhiteSpace(PathToXLSX));
        }

        private void MakeAllTextBoxesEmptyVote()
        {
            labPathVote.Text = "No path selected";
            textCriteriaVote.Text = "";
            textSessionNameVote.Text = "";
            textTableTitleVote.Text = "";
            LocPathVote = "";
            CriteriaVote = "";
            SessNameVote = "";
            TitleVote = "";
            PathToXLSX = "";
        }

        private void butSelectFolderVote_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                //dialog.SelectedPath = @"D:\Sesii\HTML";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    LocPathVote = dialog.SelectedPath;
                    labPathVote.Text = dialog.SelectedPath;
                }
            }
            if (AllParamsOkVote())
                butWorkVote.Visible = true;
        }

        private void butSlectPathXLSX_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                //dialog.SelectedPath = @"D:\Sesii\HTML";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    PathToXLSX = dialog.SelectedPath;
                    labSelectedPathXLSX.Text = dialog.SelectedPath;
                }
            }
            if (AllParamsOkVote())
                butWorkVote.Visible = true;
        }

        private void butSetSessionNameVote_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textSessionNameVote.Text))
            {
                MessageBox.Show("EMPTY textbox in SESSION NAME");
                return;
            }
            SessNameVote = textSessionNameVote.Text;
            if (AllParamsOkVote())
                butWorkVote.Visible = true;
        }

        private void butSetCritVote_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textCriteriaVote.Text))
            {
                MessageBox.Show("EMPTY textbox in CRITERIA");
                return;
            }
            CriteriaVote = textCriteriaVote.Text;
            if (AllParamsOkVote())
                butWorkVote.Visible = true;
        }

        private void setTableTitleVote_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textTableTitleVote.Text))
            {
                MessageBox.Show("EMPTY textbox in TITLE");
                return;
            }
            TitleVote = textTableTitleVote.Text;
            if (AllParamsOkVote())
                butWorkVote.Visible = true;
        }

        private void butWorkVote_Click(object sender, EventArgs e)
        {
            try
            {
                TableWork.SetParams(LocPathVote, CriteriaVote, TitleVote, SessNameVote, PathToXLSX);
                TableWork.Work();
            }
            catch (Exception ex)
            {
                string mess = "";
                mess = ex.Message + $". Time: {DateTime.Now}\n";
                mess += $"Call stack: {ex.StackTrace}";
                MessageBox.Show(mess);
            }
            MessageBox.Show("Success!");
        }

        private void TablesCreator_FormClosed(object sender, FormClosedEventArgs e)
        {
            BaseForm.SetButtonCreateTable(true);
        }
    }
}
