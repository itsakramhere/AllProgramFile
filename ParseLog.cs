using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp6
{
    class Program
    {

        public static void FileWriter(string path,string line)
        {
            using (StreamWriter sw=File.AppendText(path))
            {
                sw.WriteLine(line);
            }
        }
        static void Main(string[] args)
        {
            
            var warnPath = "D:\\warnFile.log";
            var errorPath = "D:\\errorFile.log";
            try
            {
                //2020-05-26 23:08:23 ERROR:
                string line = "";

                var warnRegex = @"[0-9]{1,}-[0-9]{1,}-[0-9]{1,}\s+[0-9]{1,}:[0-9]{1,}:[0-9]{1,}\s+WARN:";
                var errorRegex = @"[0-9]{1,}-[0-9]{1,}-[0-9]{1,}\s+[0-9]{1,}:[0-9]{1,}:[0-9]{1,}\s+ERROR:";
                Regex warnRe = new Regex(warnRegex);
                Regex errorRe = new Regex(errorRegex);

                using (StreamReader sr = new StreamReader("D:\\LogFile.log.log"))
                {

                    while ((line = sr.ReadLine()) != null)
                    {
                        if (warnRe.IsMatch(line))
                        {
                            FileWriter(warnPath, line);
                        }
                        else if (errorRe.IsMatch(line))
                        {
                            FileWriter(errorPath, line);
                        }
                    }

                }
            }
            catch (Exception e)
            {
               Console.WriteLine(e.Message);
            }
            

        }
    }
}
