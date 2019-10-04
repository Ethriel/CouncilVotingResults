using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using System.IO;
using System.Security;
using System.Runtime.InteropServices;
using CouncilVouingResults.Classes;

namespace HTMLNS
{
    class CreateTable
    {
        string PathHTML;
        string PathLOCAL;
        string PathEx;
        string Criteria;
        string TableTitle;
        string output;
        string SheetName;
        string PathJson;

        List<string> FilesPaths;
        List<string> HTMLpaths;
        List<string> DescNames;
        List<string> Yes;
        List<string> No;
        List<string> Refrained;
        List<string> DidntVote;
        List<string[]> ExcelRows;
        ExcelPackage excel;

        Descisions DescisionsList;
        JSON JSONWork;
        
        public void SetParams(string LOCALpath, string filesCriteria, string titleTable, string nameSheet, string PathToXLSX)
        {
            PathHTML = "http://rivnerada.gov.ua/portal-files/results-city-council-vote";
            TableTitle = titleTable;
            PathEx = PathToXLSX;
            PathLOCAL = LOCALpath;
            Criteria = filesCriteria;
            SheetName = nameSheet;
        }
        public void SetJsonPath(string JsonPath)
        {
            PathJson = JsonPath;
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
            output = "";
            DescisionsList = new Descisions();
            JSONWork = new JSON();
            PathJson = "";
        }
        public CreateTable(string HTMLpath, string LOCALpath, string filesCriteria, string exPath, string _sessionName, string titleTable, string PathJSON = "")
        {
            PathHTML = HTMLpath;
            PathLOCAL = LOCALpath;
            Criteria = filesCriteria;
            PathEx = exPath;
            TableTitle = titleTable;
            output = "";
            FilesPaths = new List<string>();
            HTMLpaths = new List<string>();
            DescNames = new List<string>();
            Yes = new List<string>();
            No = new List<string>();
            Refrained = new List<string>();
            DidntVote = new List<string>();
            ExcelRows = new List<string[]>();
            excel = new ExcelPackage();
            DescisionsList = new Descisions();
            JSONWork = new JSON();
        }
        public void FillFilesList()
        {
            string year = Criteria.Substring(0, 4);
            year += @"/";
            DirectoryInfo dirInf = new DirectoryInfo(PathLOCAL);
            if(!dirInf.Exists)
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
        public void FillDescNames()
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
        public void FillYes()
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
        public void FillNo()
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
        public void FillRefrained()
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
        public void FillDidntVote()
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
        public void FillOutput()
        {
            string meta1 = "<html><head>\n<meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\">\n";
            string meta2 = "<meta name=Generator content=\"FastReport 4.0 http://www.fast-report.com\">\n</head>\n";
            string style = "<link rel=\"stylesheet\" href=\"css/styles.css\"/>\n";
            string body = "<body bgcolor=\"#FFFFFF\" text=\"#000000\">\n";
            string table = "<table cellpadding=\"7\" border=\"0px\"><caption>" + "<b>" + TableTitle + "</b>" + "</caption>\n";
            string start = meta1 + meta2 + style + body + table;
            string end = "</table>\n</body></html>";
            string currRow = "";
            output = start;
            for (int i = 0; i < FilesPaths.Count; i++)
            {
                currRow = "<tr><td><a target=\"_blank\" href=\"" + HTMLpaths[i] + "\"</a>" + DescNames[i] + "</td></tr>\n";
                output += currRow;
            }
            output += end;
            string year = Criteria.Substring(0, 4);

            string OutDirPath = PathLOCAL + "\\OUT\\";
            if (!new DirectoryInfo(OutDirPath).Exists)
            {
                Directory.CreateDirectory(OutDirPath);
            }
           
            string fullPath = OutDirPath + Criteria + ".html";
            File.WriteAllText(fullPath, output);
        }
        public void FillForExcel()
        {
            string[] head = new string[] { "Назва пропозиції", "Так", "Ні", "Утримались", "Не голосували", "Посилання на рішення" };
            ExcelRows.Add(head);
            for (int i = 0; i < HTMLpaths.Count; i++)
            {
                ExcelRows.Add(new string[] { DescNames[i], Yes[i], No[i], Refrained[i], DidntVote[i], HTMLpaths[i] });
            }
        }
        public void FillExcel()
        {
            string path = PathEx;
            path += @"\";
            string fileName = Criteria + ".xlsx";
            string quntity = (ExcelRows.Count).ToString();
            string range = "A1:" + "B" + quntity;
            excel.Workbook.Worksheets.Add(SheetName);
            int a = excel.Workbook.Worksheets.Count;
            FileInfo excelFile = new FileInfo(path + fileName);
            var excelWorksheet = excel.Workbook.Worksheets[SheetName];
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

        private void FillDescisionsList()
        {
            DescisionsList.SetSession(TableTitle);
            for (int i = 0; i < DescNames.Count; i++)
            {
                DescisionsList.AddDescision(i + 1, DescNames[i], Yes[i], No[i], Refrained[i], DidntVote[i], HTMLpaths[i]);
            }
        }

        public void WriteTOJSON()
        {
            if(string.IsNullOrEmpty(PathJson))
            {
                throw new Exception("Path to JSON is empty");
            }
            FillDescisionsList();
            JSONWork.SetDescisions(DescisionsList);
            JSONWork.Write(PathJson);
        }
        public void ReadFromJSON()
        {
            DescisionsList = JSONWork.Read(PathJson);
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
