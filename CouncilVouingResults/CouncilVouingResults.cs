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
    }
}
