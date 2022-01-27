using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }


        }
        public static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("0) Exit");
            Console.WriteLine("1) Print Hello World!");
            Console.WriteLine("2) Name and age");
            Console.WriteLine("3) Change console color");
            Console.WriteLine("4) Check todays date");
            Console.WriteLine("5) Print the highest value");
            Console.WriteLine("6) Try to guess the correct number");
            Console.WriteLine("7) Print textfile on harddrive");
            Console.WriteLine("8) Read the textfile from harddrive");
            Console.WriteLine("9) Send a decimal, receive calculations");
            Console.WriteLine("10) Multiplication");
            Console.WriteLine("11) Sort array with random values");
            Console.WriteLine("12) Palindrome control");
            Console.WriteLine("13) Print numbers between inputs");
            Console.WriteLine("14) Sort odd and even numbers");
            Console.WriteLine("15) Calculate sum of input numbers");
            Console.WriteLine("16) Name your character and foe, and wish for the best ");
            Console.Write("\r\nSelect a function: ");



            switch (Console.ReadLine())
            {
                case "0":
                    return false;

                case "1":
                    Func1.PrintHello();
                    DisplayResult();
                    return true;

                case "2":
                    Func2.UserInput();
                    DisplayResult();
                    return true;

                case "3":
                    Func3.CColor();
                    DisplayResult();
                    return true;

                case "4":
                    Func4.DayDate();
                    DisplayResult();
                    return true;
                    
                case "5":
                    Func5.ValueInput();
                    DisplayResult();
                    return true;

                case "6":
                    Func6.rand();
                    return true;

                case "7":
                    Func7.harddisk();
                    return true;

                case "8":
                    Func8.Fileread();
                    DisplayResult();
                    return true;

                case "9":
                    Func9.Goo();
                    DisplayResult();
                    return true;

                case "10":
                    Func10.tabell();
                    DisplayResult();
                    return true;

                case "11":
                    Func11.Sort();
                    DisplayResult();
                    return true;

             
                case "12":
                    Func12.Gool();
                    DisplayResult();
                    return true;


                case "13":
                    Func13.Thirt();
                    DisplayResult();
                    return true;

                case "14":
                    Func14.Fourt();
                    DisplayResult();
                    return true;

                case "15":
                    Func15.Fift();
                    DisplayResult();
                    return true;

                case "16":
                    Console.Clear();
                    Character.name1();
                    Character.stats();
                    Console.ReadLine();
                    Character.name2();
                    Character.stats2();
                    DisplayResult();
                    return true;



                default:
                    return true;
            }
        }

        public static void DisplayResult()
        {

            Console.Write("\r\nPress Enter to return to Main Menu");
            Console.ReadLine();
}

        public static string CaptureInput()
        {

            return Console.ReadLine();
        
        }




                
    }

           
}





        




    




      
    
