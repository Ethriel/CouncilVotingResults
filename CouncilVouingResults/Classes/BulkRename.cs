using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using FolderValidatorNS;

namespace BulkRenameNS
{
    class BulkRename
    {
        List<FileInfo> FilesNames;
        string LocalPath;
        string FileExt;
        string Param;

        public BulkRename()
        {
            FilesNames = new List<FileInfo>();
            LocalPath = "";
            FileExt = "";
        }

        public BulkRename(string path, string ext, string param)
        {
            if(FolderValidator.ValidateFolder(ext, path))
            {
                FilesNames = new List<FileInfo>();
                LocalPath = path;
                FileExt = ext;
                Param = param;
            }
        }

        public void SetParams(string path, string ext, string param)
        {
            if (FolderValidator.ValidateFolder(ext, path))
            {
                LocalPath = path;
                FileExt = ext;
                Param = param;
                DoBulkRename();
            }
        }

        public void DoBulkRename()
        {
            string OldPath = "", NewPath = "", CurrFile = "";
            DirectoryInfo DirInf = new DirectoryInfo(LocalPath);
            FilesNames = DirInf.GetFiles("*" + FileExt).ToList();
            for (int i = 0, j = 0; i < FilesNames.Count; i++)
            {
                CurrFile = FilesNames[i].Name;
                OldPath = LocalPath + "\\" + CurrFile;
                NewPath = LocalPath + "\\" + Param + Convert.ToString(j++) + FileExt;
                File.Move(OldPath, NewPath);
            }
        }
    }
}
