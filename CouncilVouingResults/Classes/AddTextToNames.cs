using System;
using System.IO;
using FolderValidatorNS;

namespace AddTextNS
{
    class AddTextToNames
    {
        string Path;
        string Criteria;
        string FileExt;
        string SessionNum;
        string MeetingNum;
        public void SetParams(string path, string sessionNum, string meetingNum, string fileExt)
        {
            if(FolderValidator.Validate(fileExt, path))
            {
                Path = path;
                SessionNum = sessionNum;
                MeetingNum = meetingNum;
                FileExt = fileExt;
                DoAddText();
            }
        }
        public void DoAddText()
        {
            FileExt = "." + FileExt;
            string filepath = "";
            string newfilepath = "";
            string notNum = "";
            string Date = "";
            DirectoryInfo di = new DirectoryInfo(Path);
            FileInfo[] filesInfo = di.GetFiles("*"+FileExt);
            Date = GetDateToString(filesInfo[0]);
            Criteria = Date + "_" + SessionNum + "_" + MeetingNum + "_";
            for (int i = 0, j = 1; i < filesInfo.Length; i++)
            {
                filepath = Path + "\\" + filesInfo[i].Name;
                if (!char.IsDigit(filesInfo[i].Name[0]))
                {
                    notNum = "d" + Convert.ToString(j);
                    newfilepath = Path + "\\" + Criteria + notNum + FileExt;
                    j++;
                }
                else
                {
                    newfilepath = Path + "\\" + Criteria + filesInfo[i].Name;
                }
                File.Move(filepath, newfilepath);
            }
        }
        private string GetDateToString(FileInfo info)
        {
            string Day = "", Month = "", Year = "", Date = "";
            if(info.LastWriteTime.Day.ToString().Length == 1)
            {
                Day = "0" + info.LastWriteTime.Day.ToString();
            }
            else
            {
                Day = info.LastWriteTime.Day.ToString();
            }
            if(info.LastWriteTime.Month.ToString().Length == 1)
            {
                Month = "0" + info.LastWriteTime.Month.ToString();
            }
            else
            {
                Month = info.LastWriteTime.Month.ToString();
            }
            Year = info.LastWriteTime.Year.ToString();
            Date = Year + Month + Day;
            return Date;
        }
    }
}
