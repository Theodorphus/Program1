using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Class1
    {

        public static void Rand ()
        {
            Random rand = new Random();

            int number = rand.Next(0, 100);
        }
        private static int GetGuess()
        {
            int guess = 0;
            try
            {
                guess = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("You did not enter a valid guess.");
                guess = GetGuess();
            }
            return guess;
        }
    }
}
