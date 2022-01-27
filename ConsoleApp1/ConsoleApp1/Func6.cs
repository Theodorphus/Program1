using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Func6
{


   public static void rand()
    {

        while (true)
        {
            int randnum = Mynum(1, 101);
            int count = 1;
            while (true)
            {
                Console.WriteLine("Enter a number between 1 and 100:(0 to quit)");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == 0)
                    return;
                else if (input < randnum)
                {
                    Console.WriteLine("Low, try again.");
                    ++count;
                    continue;
                }
                else if (input > randnum)
                {
                    Console.WriteLine("High, try again.");
                    ++count;
                    continue;
                }
                else
                {
                    Console.WriteLine("You guessed right! The correct number was {0}!",
                                       randnum);
                    Console.WriteLine("It took you {0} {1}.\n", count,
                                       count == 1 ? "try" : "tries");
                    break;
                }
            }
        }


        static int Mynum(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }



    }
}