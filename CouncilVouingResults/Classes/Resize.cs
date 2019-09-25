using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


//=============AUTHOR: https://www.codeproject.com/Members/emerR46 =============================================//
//============ARTICLE: https://www.codeproject.com/Tips/749619/Csharp-Resize-ALL-Controls-at-Runtime ===========//
namespace CouncilVouingResults.Classes
{
    public class Resize
    {
        private Form form { get; set; }
        private float FontSize { get; set; }
        private System.Drawing.SizeF FormSize { get; set; }
        List<System.Drawing.Rectangle> ArrControlStorage = new List<System.Drawing.Rectangle>();
        private bool ShowRowHeader = false;

        public Resize(Form form)
        {
            this.form = form;
            FormSize = form.ClientSize;
            FontSize = form.Font.Size;
        }

        public void GetInitialSize()
        {
            var Controls = GetAllControls(form);
            foreach (Control control in Controls)
            {
                ArrControlStorage.Add(control.Bounds);          
                if (control.GetType() == typeof(DataGridView))
                    DgvColumnAdjust(((DataGridView)control), ShowRowHeader);
            }
        }

        public void DoResize()
        {
            double FormRatioWidth = form.ClientSize.Width / (double)FormSize.Width;
            double FormRatioHeight = form.ClientSize.Height / (double)FormSize.Height;
            var Controls = GetAllControls(form);
            int Pos = -1;
            foreach (Control control in Controls)
            {
                Pos++;
                System.Drawing.Size _controlSize = new System.Drawing.Size((int)(ArrControlStorage[Pos].Width * FormRatioWidth),
                (int)(ArrControlStorage[Pos].Height * FormRatioHeight));
                System.Drawing.Point _controlposition = new System.Drawing.Point((int)
                (ArrControlStorage[Pos].X * FormRatioWidth), (int)(ArrControlStorage[Pos].Y * FormRatioHeight));
                control.Bounds = new System.Drawing.Rectangle(_controlposition, _controlSize);
                if (control.GetType() == typeof(DataGridView))
                    DgvColumnAdjust(((DataGridView)control), ShowRowHeader);
                control.Font = new System.Drawing.Font(form.Font.FontFamily,
             (float)(((Convert.ToDouble(FontSize) * FormRatioWidth) / 2) +
              ((Convert.ToDouble(FontSize) * FormRatioHeight) / 2)));
            }
        }

        private static IEnumerable<Control> GetAllControls(Control c)
        {
            return c.Controls.Cast<Control>().SelectMany(item => GetAllControls(item)).Concat(c.Controls.Cast<Control>()).Where(control => control.Name != string.Empty);
        }

        private void DgvColumnAdjust(DataGridView dgv, bool ShowRowHeader)
        {
            int IntRowHeader = 0;
            const int Hscrollbarwidth = 5;
            if (ShowRowHeader)
                IntRowHeader = dgv.RowHeadersWidth;
            else
                dgv.RowHeadersVisible = false;

            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                if (dgv.Dock == DockStyle.Fill)
                    dgv.Columns[i].Width = ((dgv.Width - IntRowHeader) / dgv.ColumnCount);
                else
                    dgv.Columns[i].Width = ((dgv.Width - IntRowHeader - Hscrollbarwidth) / dgv.ColumnCount);
            }
        }
    }
}
