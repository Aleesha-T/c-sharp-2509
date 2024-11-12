using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignmentsPart8
{
    public class FileHelper
    {
        public bool IsValidFile(string filePath)
        {
            FileInfo fileInfo = new FileInfo(filePath);
            bool Valid = fileInfo.Exists && fileInfo.Length < 1024 * 1024;
            //Checks if file exists and file size less than 1 MB.
            return Valid;
        }
        //Returns true if exists and less than 1 MB.
    }
}
