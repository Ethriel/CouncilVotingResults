using System;
using System.Collections.Generic;
using OfficeOpenXml;
using System.IO;
using CouncilVouingResults.Classes;

namespace HTMLNS
{
    partial class CreateTable
    {
        string output;
        string PathJson;
        string OutDirPath;
        List<string[]> ExcelRows;
        
        ExcelPackage excel;
        CreatorHelper Helper;
        JSON JSONWork;
        Descisions DescisionsList;
        
        public void SetParams(string LOCALpath, string filesCriteria, string titleTable, string nameSheet, string PathToXLSX)
        {
            OutDirPath = LOCALpath + "\\OUT\\";
            Helper.SetParams(LOCALpath, filesCriteria, titleTable, nameSheet, PathToXLSX);
        }

        public void SetJsonPath(string JsonPath)
        {
            PathJson = JsonPath;
        }

        public CreateTable()
        {
            Helper = new CreatorHelper();
            ExcelRows = new List<string[]>();
            excel = new ExcelPackage();
            output = "";
            DescisionsList = new Descisions();
            JSONWork = new JSON();
            PathJson = "";
        }

        public CreateTable(string HTMLpath, string LOCALpath, string filesCriteria, string exPath, string _sessionName, string titleTable, string PathJSON = "")
        {
            Helper = new CreatorHelper();
            ExcelRows = new List<string[]>();
            excel = new ExcelPackage();
            output = "";
            DescisionsList = new Descisions();
            JSONWork = new JSON();
            PathJson = PathJSON;
        }

        private void FillOutput()
        {
            string meta1 = "<html><head>\n<meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\">\n";
            string meta2 = "<meta name=Generator content=\"FastReport 4.0 http://www.fast-report.com\">\n</head>\n";
            string style = "<link rel=\"stylesheet\" href=\"css/styles.css\"/>\n";
            string body = "<body bgcolor=\"#FFFFFF\" text=\"#000000\">\n";
            string table = "<table cellpadding=\"7\" border=\"0px\"><caption>" + "<b>" + Helper.TableTitle + "</b>" + "</caption>\n";
            string start = meta1 + meta2 + style + body + table;
            string end = "</table>\n</body></html>";
            string currRow = "";
            output = start;
            for (int i = 0; i < DescisionsList.Count; i++)
            {
                currRow = "<tr><td><a target=\"_blank\" href=\"" + DescisionsList[i].HTMLPath + "\"</a>" + DescisionsList[i].DecsName + "</td></tr>\n";
                output += currRow;
            }
            output += end;

            if (!new DirectoryInfo(OutDirPath).Exists)
            {
                Directory.CreateDirectory(OutDirPath);
            }
           
            string fullPath = OutDirPath + Helper.Criteria + ".html";
            File.WriteAllText(fullPath, output);
        }

        private void FillExcel()
        {
            string path = Helper.PathEx;
            path += @"\";
            string fileName = Helper.Criteria + ".xlsx";
            string quntity = (ExcelRows.Count).ToString();
            string range = "A1:" + "B" + quntity;
            excel.Workbook.Worksheets.Add(Helper.SheetName);
            int a = excel.Workbook.Worksheets.Count;
            FileInfo excelFile = new FileInfo(path + fileName);
            var excelWorksheet = excel.Workbook.Worksheets[Helper.SheetName];
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
            Helper.Work();
            DescisionsList = Helper.GetDescisions();
            ExcelRows = Helper.GetExcelRows();
            FillOutput();
            FillExcel();
        }

        public void WriteTOJSON()
        {
            if(string.IsNullOrEmpty(PathJson))
            {
                throw new Exception("Path to JSON is empty");
            }
            
            JSONWork.SetDescisions(DescisionsList);
            JSONWork.Write(PathJson);
        }

        public void ReadFromJSON()
        {
            DescisionsList = JSONWork.Read(PathJson);
        }

        public void CreateReadableJson()
        {
            JSONWork.CreateReadable(PathJson);
        }
    }
}
