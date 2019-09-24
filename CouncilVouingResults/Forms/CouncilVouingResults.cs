using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CouncilVouingResults
{
    public partial class CouncilVouingResults : Form
    {
        TablesCreator TableWork;
        AddTextToFilesNames AddTextToFilesWork;
        BulkRenameForm BulkRenameWork;
        ReplaceSymbForm ReplaceSymbWork;

        public CouncilVouingResults()
        {
            InitializeComponent();
        }

        public Button GetButtonCreateTable()
        {
            return butCreateTables;
        }

        public void SetButtonCreateTable(bool Enable)
        {
            butCreateTables.Enabled = Enable;
        }

        public Button GetButtonAddText()
        {
            return butAddText;
        }

        public void SetButtonAddText(bool Enabled)
        {
            butAddText.Enabled = Enabled;
        }

        public Button GetButtonBulkRename()
        {
            return butBulkRename;
        }

        public void SetButtonBulkRename(bool Enabled)
        {
            butBulkRename.Enabled = Enabled;
        }

        public Button GetButtonReplaceSymb()
        {
            return butReplaceSymb;
        }

        public void SetButtonReplaceSymb(bool Enable)
        {
            butReplaceSymb.Enabled = Enable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TableWork = new TablesCreator(this);
            butCreateTables.Enabled = false;
            try
            {
                TableWork.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddTextToFilesWork = new AddTextToFilesNames(this);
            butAddText.Enabled = false;
            try
            {
                AddTextToFilesWork.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butBulkRename_Click(object sender, EventArgs e)
        {
            BulkRenameWork = new BulkRenameForm(this);
            butBulkRename.Enabled = false;
            try
            {
                BulkRenameWork.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butReplaceSymb_Click(object sender, EventArgs e)
        {
            ReplaceSymbWork = new ReplaceSymbForm(this);
            butReplaceSymb.Enabled = false;
            try
            {
                ReplaceSymbWork.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butHelp_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Ethriel/ReNameIt/blob/master/README.md");
        }
    }
}
