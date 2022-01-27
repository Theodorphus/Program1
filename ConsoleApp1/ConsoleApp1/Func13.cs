using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Func13
{

    public static void Thirt()
    {
        {

            Console.WriteLine("Write a number: ");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());


            for (int i = n; i <= m; i++)
            {
                Console.WriteLine(i);
            }


            for (int i = m; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}