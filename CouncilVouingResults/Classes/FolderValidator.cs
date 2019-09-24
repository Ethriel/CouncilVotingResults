using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace FolderValidatorNS
{
    public static class FolderValidator
    {
        static bool IsExtensionValid(string ext)
        {
            char dot = '.';
            if (ext.Contains(dot))
                return false;
            return true;
        }

        public static bool ValidateFolder(string ext, string path)
        {
            if(!Directory.Exists(path))
            {
                throw new Exception("Folder does not exist");
            }
            if (IsExtensionValid(ext))
            {
                DirectoryInfo DirInfo = new DirectoryInfo(path);
                List<FileInfo> FilesInfo = DirInfo.GetFiles(path).ToList();
                if (FilesInfo.Count == 0 || FilesInfo == null)
                    throw new Exception("Folder does not contain files with such extension");
            }
            else
                throw new Exception("Invalid extension: contains dot");
            return true;
        }
    }
}
