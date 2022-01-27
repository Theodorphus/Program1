using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Func7
    {

        public static void harddisk()
        {
            Console.Clear();
            string input;
            input = Console.ReadLine();
            string path = @"c:\temp\MyTest.txt";
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(input);
                    sw.Close();


                }
            }
        }
    }
}

