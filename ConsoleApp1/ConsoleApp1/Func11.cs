using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Func11
{

    public static void Sort()
    {
        int Min = 0;
        int Max = 20;


        int[] test2 = new int[5];


        Random randNum = new Random();
        for (int i = 0; i < test2.Length; i++)
        {
            test2[i] = randNum.Next(Min, Max);


            int[] test3 = test2;


            int temp = 0;

            for (int c = 0; c < test3.Length - 1; c++)
            {
                for (int d = c + 1; d < test3.Length; d++)
                {
                    if (test3[c] > test3[d])
                    {
                        temp = test3[c];
                        test3[c] = test3[d];
                        test3[d] = temp;
                    }
                }
            }

            Console.WriteLine(test3[i]);


        }



    }
}
