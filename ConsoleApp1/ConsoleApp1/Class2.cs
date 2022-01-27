using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Func14
{

    public static void Fourt()
    {
        {

            int i;
            int[] arr = new int[10];

            Console.Write("Enter ten numbers:");
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Even list is:");
            for (i = 0; i < 10; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.Write(" " + arr[i]);
                }
            }

            Console.Write("\nOdd List is:");
            for (i = 0; i < 10; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    Console.Write(" " + arr[i]);

                }
            }
        }
    }
}
