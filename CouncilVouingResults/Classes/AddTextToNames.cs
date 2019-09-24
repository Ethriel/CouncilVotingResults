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
        public void SetParams(string path, string criteria, string fileExt)
        {
            if(FolderValidator.Validate(fileExt, path))
            {
                Path = path;
                Criteria = criteria;
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
            DirectoryInfo di = new DirectoryInfo(Path);
            FileInfo[] filesInfo = di.GetFiles("*"+FileExt);
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
    }
}
