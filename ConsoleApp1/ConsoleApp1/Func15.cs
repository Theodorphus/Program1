using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Func15
{

    public static void Fift()
    {
        {
            int i;
            int[] arr = new int[5];

            Console.Write("Enter five numbers:");
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }


            int sum = arr.Sum();

            Console.Write(sum);
        }
            }
        }
    