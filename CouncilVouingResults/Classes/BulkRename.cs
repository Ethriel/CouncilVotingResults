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
            if(FolderValidator.Validate(ext, path))
            {
                FilesNames = new List<FileInfo>();
                LocalPath = path;
                FileExt = ext;
                Param = param;
            }
        }

        public void SetParams(string path, string ext, string param)
        {
            if (FolderValidator.Validate(ext, path))
            {
                LocalPath = path;
                FileExt = ext;
                Param = param;
                DoBulkRename();
            }
        }

        public void DoBulkRename()
        {
            FileExt = "." + FileExt;
            string OldPath = "", NewPath = "";
            DirectoryInfo DirInf = new DirectoryInfo(LocalPath);
            FilesNames = DirInf.GetFiles("*" + FileExt).ToList();
            for (int i = 0, j = 1; i < FilesNames.Count; i++)
            {
                OldPath = LocalPath + "\\" + FilesNames[i].Name;
                NewPath = LocalPath + "\\" + Param + Convert.ToString(j++) + FileExt;
                File.Move(OldPath, NewPath);
            }
        }
    }
}
