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
                throw new Exception("Too many characters in WHAT or ONTO");
            DoReplaceSymb();
        }

        public void DoReplaceSymb()
        {
            string OldPath = "", NewPath = "", NewName = "";
            char what = What[0], onto = Onto[0];
            DirectoryInfo DirInfo = new DirectoryInfo(LocalPath);
            if(!DirInfo.Exists)
            {
                throw new Exception("Selected directory does not exist!");
            }
            FileNames = DirInfo.GetFiles().ToList();
            for (int i = 0; i < FileNames.Count; i++)
            {
                OldPath = LocalPath + "\\" + FileNames[i].Name;
                NewName = FileNames[i].Name.Replace(what, onto);
                NewPath = LocalPath + "\\" + NewName;
                File.Move(OldPath, NewPath);
            }
        }
    }
}
