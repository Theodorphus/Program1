using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Func2
    {

        public static void UserInput()
        {
            String name;
            int age;

            Console.Clear();

            Console.WriteLine("What is your full name?");

            name = Console.ReadLine();


            Console.WriteLine("How old are you?");

            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your name is " + name + " and you are " + age + " years old.");

        }
    }
}
