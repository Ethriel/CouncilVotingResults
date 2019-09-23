using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CouncilVouingResults
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new CouncilVouingResults());
            }
            catch(Exception ex)
            {
                string mess = ex.Message + $". Time: {DateTime.Now}\n";
                mess+=$"Call stack: {ex.StackTrace}";
                MessageBox.Show(mess);
            }
        }
    }
}
