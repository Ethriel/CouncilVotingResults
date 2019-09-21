using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using System.IO;
using System.Security;
using System.Runtime.InteropServices;

namespace HTMLNS
{
    class CreateTable
    {
        string pathHTML;
        string pathLOCAL;
        string pathEx;
        string criteria;
        string tableTitle;
        string output;
        string sheetName;
        List<string> FilesPaths;
        List<string> HTMLpaths;
        List<string> DescNames;
        List<string> Yes;
        List<string> No;
        List<string> Refrained;
        List<string> DidntVote;
        List<string[]> ExcelRows;
        ExcelPackage excel;
        public void SetParams(string LOCALpath, string filesCriteria, string titleTable, string nameSheet, string PathToXLSX)
        {
            pathHTML = "http://rivnerada.gov.ua/portal-files/results-city-council-vote";
            tableTitle = titleTable;
            pathEx = PathToXLSX;
            pathLOCAL = LOCALpath;
            criteria = filesCriteria;
            sheetName = nameSheet;
        }
        public CreateTable()
        {
            FilesPaths = new List<string>();
            HTMLpaths = new List<string>();
            DescNames = new List<string>();
            Yes = new List<string>();
            No = new List<string>();
            Refrained = new List<string>();
            DidntVote = new List<string>();
            ExcelRows = new List<string[]>();
            excel = new ExcelPackage();
        }
        public CreateTable(string HTMLpath, string LOCALpath, string filesCriteria, string exPath, string _sessionName, string titleTable)
        {
            pathHTML = HTMLpath;
            pathLOCAL = LOCALpath;
            criteria = filesCriteria;
            pathEx = exPath;
            tableTitle = titleTable;
            output = "";
            FilesPaths = new List<string>();
            HTMLpaths = new List<string>();
            DescNames = new List<string>();
            Yes = new List<string>();
            No = new List<string>();
            Refrained = new List<string>();
            DidntVote = new List<string>();
            ExcelRows = new List<string[]>();
            ExcelRows = new List<string[]>();
            excel = new ExcelPackage();
            Work();
        }
        public void FillFilesList()
        {
            string _path = pathLOCAL;
            string year = criteria.Substring(0, 4);
            string htmlPath = "";
            year += @"/";
            DirectoryInfo dirInf = new DirectoryInfo(_path);
            List<FileInfo> filesInfo = dirInf.GetFiles(criteria + "*.html").ToList();
            filesInfo.Sort(new NaturalFileInfoNameComparer());
            FilesPaths = filesInfo.Select(s => _path + "\\" + s.Name).ToList();
            for (int i = 0; i < filesInfo.Count; i++)
            {
                htmlPath = pathHTML + "/" + year + filesInfo[i].Name;
                HTMLpaths.Add(htmlPath);
            }
        }
        public void FillDescNames()
        {
            string start = "<td/><td colspan=\"9\" class=\"s2\">";
            string stop = "</td><td/>";
            string currFile = "";
            string tmp = "";
            string toWrite = "";
            int from = 0;
            int to = 0;
            for (int i = 0; i < FilesPaths.Count; i++)
            {
                currFile = FilesPaths[i];
                tmp = File.ReadAllText(currFile);
                from = tmp.IndexOf(start) + start.Length;
                to = tmp.IndexOf(stop, from);
                toWrite = tmp.Substring(from, to - from);
                DescNames.Add(toWrite);
            }
            for (int i = 0; i < DescNames.Count; i++)
            {
                DescNames[i] = DescNames[i].Replace("&quot;", "\"");
            }
        }
        public void FillYes()
        {
            string start = "<td colspan=\"11\" class=\"s3\">Так  ( Голосування: ";
            string stop = " )</td>";
            string currFile = "";
            string tmp = "";
            string toWrite = "";
            int from = 0;
            int to = 0;
            for (int i = 0; i < FilesPaths.Count; i++)
            {
                currFile = FilesPaths[i];
                tmp = File.ReadAllText(currFile);
                from = tmp.IndexOf(start) + start.Length;
                to = tmp.IndexOf(stop, from);
                toWrite = tmp.Substring(from, to - from);
                Yes.Add(toWrite);
            }
        }
        public void FillNo()
        {
            string start = "<td colspan=\"11\" class=\"s3\">Ні  ( Голосування: ";
            string stop = " )</td>";
            string currFile = "";
            string tmp = "";
            string toWrite = "";
            int from = 0;
            int to = 0;
            for (int i = 0; i < FilesPaths.Count; i++)
            {
                currFile = FilesPaths[i];
                tmp = File.ReadAllText(currFile);
                from = tmp.IndexOf(start) + start.Length;
                to = tmp.IndexOf(stop, from);
                toWrite = tmp.Substring(from, to - from);
                No.Add(toWrite);
            }
        }
        public void FillRefrained()
        {
            string start = "<td colspan=\"11\" class=\"s3\">Утрималися  ( Голосування: ";
            string stop = " )</td>";
            string currFile = "";
            string tmp = "";
            string toWrite = "";
            int from = 0;
            int to = 0;
            for (int i = 0; i < FilesPaths.Count; i++)
            {
                currFile = FilesPaths[i];
                tmp = File.ReadAllText(currFile);
                from = tmp.IndexOf(start) + start.Length;
                to = tmp.IndexOf(stop, from);
                toWrite = tmp.Substring(from, to - from);
                Refrained.Add(toWrite);
            }
        }
        public void FillDidntVote()
        {
            string start = "<td colspan=\"11\" class=\"s3\">Не голосували  ( Загалом: ";
            string stop = " )</td>";
            string currFile = "";
            string tmp = "";
            string toWrite = "";
            int from = 0;
            int to = 0;
            for (int i = 0; i < FilesPaths.Count; i++)
            {
                currFile = FilesPaths[i];
                tmp = File.ReadAllText(currFile);
                from = tmp.IndexOf(start) + start.Length;
                to = tmp.IndexOf(stop, from);
                toWrite = tmp.Substring(from, to - from);
                DidntVote.Add(toWrite);
            }
        }
        public void FillOutput()
        {
            string meta1 = "<html><head>\n<meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\">\n";
            string meta2 = "<meta name=Generator content=\"FastReport 4.0 http://www.fast-report.com\">\n</head>\n";
            string body = "<body bgcolor=\"#FFFFFF\" text=\"#000000\">\n";
            string table = "<table cellpadding=\"7\" border=\"0px\"><caption>" + "<b>" + tableTitle + "</b>" + "</caption>\n";
            string start = meta1 + meta2 + body + table;
            string end = "</table>\n</body></html>";
            string currRow = "";
            string currName = "";
            string currPath = "";
            output = start;
            for (int i = 0; i < FilesPaths.Count; i++)
            {
                currPath = HTMLpaths[i];
                currName = DescNames[i];
                currRow = "<tr><td><a target=\"_blank\" href=\"" + currPath + "\"</a>" + currName + "</td></tr>\n";
                output += currRow;
            }
            output += end;
            string year = criteria.Substring(0, 4);
            string fullPath = pathLOCAL + "\\OUT\\" + criteria + ".html";
            File.WriteAllText(fullPath, output);
        }
        public void FillForExcel()
        {
            string[] head = new string[] { "Назва пропозиції", "Так", "Ні", "Утримались", "Не голосували", "Посилання на рішення" };
            ExcelRows.Add(head);
            for (int i = 0; i < HTMLpaths.Count; i++)
            {
                string[] tmp = new string[] { DescNames[i], Yes[i], No[i], Refrained[i], DidntVote[i], HTMLpaths[i] };
                ExcelRows.Add(tmp);
            }
        }
        public void FillExcel()
        {
            string _path = pathEx;
            _path += @"\";
            string fileName = criteria + ".xlsx";
            string quntity = (ExcelRows.Count).ToString();
            string range = "A1:" + "B" + quntity;
            excel.Workbook.Worksheets.Add(sheetName);
            int a = excel.Workbook.Worksheets.Count;
            FileInfo excelFile = new FileInfo(_path + fileName);
            var excelWorksheet = excel.Workbook.Worksheets[sheetName];
            excelWorksheet.Cells[range].LoadFromArrays(ExcelRows);
            excelWorksheet.Column(1).Width = 180;
            excelWorksheet.Column(2).Width = 5;
            excelWorksheet.Column(3).Width = 5;
            excelWorksheet.Column(4).Width = 12;
            excelWorksheet.Column(5).Width = 15;
            excelWorksheet.Column(6).Width = 80;
            excel.SaveAs(excelFile);
        }
        public void Work()
        {
            FillFilesList();
            FillYes();
            FillNo();
            FillRefrained();
            FillDidntVote();
            FillDescNames();
            FillOutput();
            FillForExcel();
            FillExcel();
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
