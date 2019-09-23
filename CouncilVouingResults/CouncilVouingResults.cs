using System;
using System.Diagnostics;
using System.Windows.Forms;


namespace CouncilVouingResults
{
    public partial class CouncilVouingResults : Form
    {
        TablesCreator TableWork;
        Renamer RenameWork;

        public CouncilVouingResults()
        {
            InitializeComponent();
        }

        public Button GetButtonRenamer()
        {
            return butRename;
        }

        public void SetButtonRenamer(bool Enabled)
        {
            butRename.Enabled = Enabled;
        }

        public Button GetButtonCreateTable()
        {
            return butCreateTables;
        }

        public void SetButtonCreateTable(bool Enable)
        {
            butCreateTables.Enabled = Enable;
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
            RenameWork = new Renamer(this);
            butRename.Enabled = false;
            try
            {
                RenameWork.Show();
            }
            catch(Exception ex)
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
