using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace ReplaceSymbNS
{
    class ReplaceSymb
    {
        string LocalPath;
        List<FileInfo> FileNames;
        char[] What;
        char[] Onto;

        public ReplaceSymb()
        {
            FileNames = new List<FileInfo>();
            LocalPath = "";
        }

        public ReplaceSymb(string path)
        {
            FileNames = new List<FileInfo>();
            LocalPath = path;
        }

        public void SetParams(string path, string what, string onto)
        {
            LocalPath = path;
            What = what.ToCharArray();
            Onto = onto.ToCharArray();
            if (What.Length > 1 || Onto.Length > 1)
                throw new Exception("Too many characters int WHAT or ONTO");
            DoReplaceSymb();
        }

        public void DoReplaceSymb()
        {
            string CurrFile = "", OldPath = "", NewPath = "", NewName = "";
            char what = What[0], onto = Onto[0];
            DirectoryInfo DirInfo = new DirectoryInfo(LocalPath);
            FileNames = DirInfo.GetFiles().ToList();
            for (int i = 0; i < FileNames.Count; i++)
            {
                CurrFile = FileNames[i].Name;
                OldPath = LocalPath + "\\" + CurrFile;
                NewName = CurrFile.Replace(what, onto);
                NewPath = LocalPath + "\\" + NewName;
                File.Move(OldPath, NewPath);
            }
        }
    }
}
