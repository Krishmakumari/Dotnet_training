using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingDemo
{
    public class DirectoryDemo
    {
        public void DirectoryDemoFunc(string directoryName)
        {
            if (Directory.Exists(directoryName))
            {
                Console.WriteLine("Directory ALready exists");
            }
            else
            {
                Directory.CreateDirectory(directoryName);
                Console.WriteLine("Directory created");
            }
        }

        public void DriveInfoFunc(string driveName)
        {
            DriveInfo dInfo = new DriveInfo(driveName);
            Console.WriteLine($"Drive Name {dInfo.Name}");
            Console.WriteLine($"Drive FileType {dInfo.DriveType}");
            Console.WriteLine($"Drive Size {dInfo.TotalSize}");
        }

        public void PathDemo()
        {
            string s = @"D:\Dotnet\FileHandlingDemo";
            Console.WriteLine(Path.GetFileName(s));
            Console.WriteLine(Path.GetTempPath);
        }



    }
}
