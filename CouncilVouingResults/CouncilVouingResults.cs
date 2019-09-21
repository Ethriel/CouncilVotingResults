using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HTMLNS;
using RenameNS;

namespace CouncilVouingResults
{
    public partial class CouncilVouingResults : Form
    {
        CreateTable tableWork;
        Rename renamer;

        string LocPathVote;
        string CriteriaVote;
        string SessNameVote;
        string TitleVote;
        string PathToXLSX;

        string LocPathRen;
        string CriteriaRen;
        string FileExtRen;
        public CouncilVouingResults()
        {
            InitializeComponent();
            tableWork = new CreateTable();
            renamer = new Rename();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            butSetParamsVote.Visible = false;
            MakeInvisibleRen();
            MakeVisibleTable();
        }
        private void selectFolder_Click(object sender, EventArgs e)
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

        private void sendCrit_Click(object sender, EventArgs e)
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

        private void sendTableTitle_Click(object sender, EventArgs e)
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

        private void sendSessionName_Click(object sender, EventArgs e)
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

        private void butSlectPathXSLX_Click(object sender, EventArgs e)
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

        private void Work_Click(object sender, EventArgs e)
        {
            try
            {
                tableWork.SetParams(LocPathVote, CriteriaVote, TitleVote, SessNameVote, PathToXLSX);
                tableWork.Work();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Success!");
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
            butSetParamsVote.Visible = false;
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

        //----------------------------------------RENAMER-----------------------------------//

        private void button1_Click_1(object sender, EventArgs e)
        {
            butRename.Visible = false;
            MakeInvisibleTable();
            MakeVisibleRen();
        }

        private void butSelectPathRen_Click(object sender, EventArgs e)
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

        private void butSetCritRen_Click(object sender, EventArgs e)
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

        private void butSetFileExt_Click(object sender, EventArgs e)
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

        private void butWorkRen_Click(object sender, EventArgs e)
        {
            try
            {
                renamer.SetParams(LocPathRen, CriteriaRen, FileExtRen);
                renamer.DoRename();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Success!");
            labOpenAfterRename.Visible = true;
            butOpenFolderAfterRename.Visible = true;
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
            butRename.Visible = false;
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

        private void butBack_Click(object sender, EventArgs e)
        {
            MakeInvisibleRen();
            MakeInvisibleTable();
            MakeAllTextBoxesEmptyVote();
            MakeAllTextBoxesEmptyRen();

            butRename.Visible = true;
            butSetParamsVote.Visible = true;
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

        private void butOpenFolderAfterRename_Click(object sender, EventArgs e)
        {
            Process.Start(LocPathRen);
        }
    }
}
