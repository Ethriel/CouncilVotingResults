using System;
using System.Diagnostics;
using System.Windows.Forms;


namespace CouncilVouingResults
{
    public partial class CouncilVouingResults : Form
    {
        TablesCreator TablesCreator;
        Renamer Renamer;

        public CouncilVouingResults()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var curr = TablesCreator;
            if(curr == null)
                TablesCreator = new TablesCreator();
            TablesCreator.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var curr = Renamer;
            if (curr == null)
                Renamer = new Renamer();
            Renamer.Show();
        }

        private void butHelp_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Ethriel/ReNameIt/blob/master/README.md");
        }
    }
}
