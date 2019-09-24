using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AddTextNS
{
    class AddTextToNames
    {
        string path;
        string criteria;
        string fileExt;
        public void SetParams(string _path, string _criteria, string _fileExt)
        {
            path = _path;
            criteria = _criteria;
            fileExt = _fileExt;
            DoAddText();
        }
        public void DoAddText()
        {
            string filepath = "";
            string newfilepath = "";
            string notNum = "";
            DirectoryInfo di = new DirectoryInfo(path);
            FileInfo[] filesInfo = di.GetFiles("*"+fileExt);
            for (int i = 0, j = 1; i < filesInfo.Length; i++)
            {
                filepath = path + "\\" + filesInfo[i].Name;
                if (!char.IsDigit(filesInfo[i].Name[0]))
                {
                    notNum = "d" + Convert.ToString(j);
                    newfilepath = path + "\\" + criteria + notNum + fileExt;
                    j++;
                }
                else
                {
                    newfilepath = path + "\\" + criteria + filesInfo[i].Name;
                }
                File.Move(filepath, newfilepath);
            }
        }
    }
}
