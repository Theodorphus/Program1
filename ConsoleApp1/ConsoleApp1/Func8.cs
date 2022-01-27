using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Func8
    {

        public static void Fileread()
        {
            {

                using (StreamReader sr = File.OpenText(@"c:\temp\MyTest.txt"))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
        }
    }
}