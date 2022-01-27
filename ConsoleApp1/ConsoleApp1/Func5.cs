using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Func5
    {

        public static void ValueInput()
        {
            Console.Clear();

            Console.WriteLine("Insert first value");

            int value1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insert second value");

            int value2 = Convert.ToInt32(Console.ReadLine());

            int biggest = Math.Max(value1, value2);


            Console.WriteLine("The highest value is: " + biggest);

           
        }

    }
}
