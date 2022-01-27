using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Func3
    {

        public static void CColor()
        {

            Console.Clear();

            Console.WriteLine("Press '1' to change consolecolor, and '2' to revert it");


            int intTemp = Convert.ToInt32(Console.ReadLine());

            switch (intTemp)
            {
                case 1:
                    Console.BackgroundColor = ConsoleColor.Green;
                    break;
                case 2:
                    Console.ResetColor();
                    break;
            }

        }
    }
}
