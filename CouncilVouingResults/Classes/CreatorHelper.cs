using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace CouncilVouingResults.Classes
{
    public class CreatorHelper
    {
        Descisions DescisionsList;

        string PathHTML;
        public string TableTitle { get; private set; }
        public string PathEx { get; private set; }
        public string PathLOCAL { get; private set; }
        public string Criteria { get; private set; }
        public string SheetName { get; private set; }

        List<string> FilesPaths;
        List<string> HTMLpaths;
        List<string> DescNames;
        List<string> Yes;
        List<string> No;
        List<string> Refrained;
        List<string> DidntVote;
        List<string[]> ExcelRows;

        public CreatorHelper()
        {
            DescisionsList = new Descisions();
            FilesPaths = new List<string>();
            HTMLpaths = new List<string>();
            DescNames = new List<string>();
            Yes = new List<string>();
            No = new List<string>();
            Refrained = new List<string>();
            DidntVote = new List<string>();
            ExcelRows = new List<string[]>();
        }

        public void SetParams(string LOCALpath, string filesCriteria, string titleTable, string nameSheet, string PathToXLSX)
        {
            PathHTML = "http://rivnerada.gov.ua/portal-files/results-city-council-vote";
            TableTitle = titleTable;
            PathEx = PathToXLSX;
            PathLOCAL = LOCALpath;
            Criteria = filesCriteria;
            SheetName = nameSheet;
        }

        private void FillFilesList()
        {
            string year = Criteria.Substring(0, 4);
            year += @"/";
            DirectoryInfo dirInf = new DirectoryInfo(PathLOCAL);
            if (!dirInf.Exists)
            {
                throw new Exception("Directory with needed files does not exist!");
            }
            List<FileInfo> filesInfo = dirInf.GetFiles(Criteria + "*.html").ToList();
            filesInfo.Sort(new NaturalFileInfoNameComparer());
            FilesPaths = filesInfo.Select(s => PathLOCAL + "\\" + s.Name).ToList();
            for (int i = 0; i < filesInfo.Count; i++)
            {
                HTMLpaths.Add(PathHTML + "/" + year + filesInfo[i].Name);
            }
        }

        private void FillDescNames()
        {
            string start = "<td/><td colspan=\"9\" class=\"s2\">";
            string stop = "</td><td/>";
            string tmp = "";
            int from = 0;
            int to = 0;
            for (int i = 0; i < FilesPaths.Count; i++)
            {
                tmp = File.ReadAllText(FilesPaths[i]);
                from = tmp.IndexOf(start) + start.Length;
                to = tmp.IndexOf(stop, from);
                DescNames.Add(tmp.Substring(from, to - from));
            }
            for (int i = 0; i < DescNames.Count; i++)
            {
                DescNames[i] = DescNames[i].Replace("&quot;", "\"");
            }
        }

        private void FillYes()
        {
            string start = "<td colspan=\"11\" class=\"s3\">Так  ( Голосування: ";
            string stop = " )</td>";
            string tmp = "";
            int from = 0;
            int to = 0;
            for (int i = 0; i < FilesPaths.Count; i++)
            {
                tmp = File.ReadAllText(FilesPaths[i]);
                from = tmp.IndexOf(start) + start.Length;
                to = tmp.IndexOf(stop, from);
                Yes.Add(tmp.Substring(from, to - from));
            }
        }

        private void FillNo()
        {
            string start = "<td colspan=\"11\" class=\"s3\">Ні  ( Голосування: ";
            string stop = " )</td>";
            string tmp = "";
            int from = 0;
            int to = 0;
            for (int i = 0; i < FilesPaths.Count; i++)
            {
                tmp = File.ReadAllText(FilesPaths[i]);
                from = tmp.IndexOf(start) + start.Length;
                to = tmp.IndexOf(stop, from);
                No.Add(tmp.Substring(from, to - from));
            }
        }

        private void FillRefrained()
        {
            string start = "<td colspan=\"11\" class=\"s3\">Утрималися  ( Голосування: ";
            string stop = " )</td>";
            string tmp = "";
            int from = 0;
            int to = 0;
            for (int i = 0; i < FilesPaths.Count; i++)
            {
                tmp = File.ReadAllText(FilesPaths[i]);
                from = tmp.IndexOf(start) + start.Length;
                to = tmp.IndexOf(stop, from);
                Refrained.Add(tmp.Substring(from, to - from));
            }
        }

        private void FillDidntVote()
        {
            string start = "<td colspan=\"11\" class=\"s3\">Не голосували  ( Загалом: ";
            string stop = " )</td>";
            string tmp = "";
            int from = 0;
            int to = 0;
            for (int i = 0; i < FilesPaths.Count; i++)
            {
                tmp = File.ReadAllText(FilesPaths[i]);
                from = tmp.IndexOf(start) + start.Length;
                to = tmp.IndexOf(stop, from);
                DidntVote.Add(tmp.Substring(from, to - from));
            }
        }

        private void FillDescisionsList()
        {
            DescisionsList.SetSession(TableTitle);
            for (int i = 0; i < DescNames.Count; i++)
            {
                DescisionsList.AddDescision(i + 1, DescNames[i], Yes[i], No[i], Refrained[i], DidntVote[i], HTMLpaths[i]);
            }
        }

        private void FillForExcel()
        {
            string[] head = new string[] { "Назва пропозиції", "Так", "Ні", "Утримались", "Не голосували", "Посилання на рішення" };
            ExcelRows.Add(head);
            for (int i = 0; i < DescisionsList.Count; i++)
            {
                ExcelRows.Add(new string[] { DescisionsList[i].DecsName, DescisionsList[i].Yes,
                    DescisionsList[i].No, DescisionsList[i].Refrained, DescisionsList[i].DidntVote, DescisionsList[i].HTMLPath });
            }
        }

        public void Work()
        {
            FillFilesList();
            FillYes();
            FillNo();
            FillRefrained();
            FillDidntVote();
            FillDescNames();
            FillDescisionsList();
            FillForExcel();
        }

        public Descisions GetDescisions()
        {
            return DescisionsList;
        }

        public List<string[]> GetExcelRows()
        {
            return ExcelRows;
        }
    }

    [SuppressUnmanagedCodeSecurity]
    internal static class SafeNativeMethods
    {
        [DllImport("shlwapi.dll", CharSet = CharSet.Unicode)]
        public static extern int StrCmpLogicalW(string psz1, string psz2);
    }
    public sealed class NaturalStringComparer : IComparer<string>
    {
        public int Compare(string a, string b)
        {
            return SafeNativeMethods.StrCmpLogicalW(a, b);
        }
    }
    public sealed class NaturalFileInfoNameComparer : IComparer<FileInfo>
    {
        public int Compare(FileInfo a, FileInfo b)
        {
            return SafeNativeMethods.StrCmpLogicalW(a.Name, b.Name);
        }
    }
}
