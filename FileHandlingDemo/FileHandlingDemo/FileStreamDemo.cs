using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingDemo
{
    public class FileStreamDemo
    {
        FileStream fs = null;
        public void CreateFile(string filename)
        {
            StreamWriter sw =null;
            try
            {
                fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(fs);
                sw.WriteLine("This is just a sample file for file IO Demo");
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine(e.Message); ;
            }
            catch(FileLoadException e)
            {
                Console.WriteLine(e.Message); ;
            }
            finally
            {
                sw.Close();
                fs.Close();
            }
        }
        public void ReadFile(string fileName)
        {
            fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            Console.WriteLine(sr.ReadToEnd());

            sr.Close();
            fs.Close();
        }
    }
}
