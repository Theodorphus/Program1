using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Func9 { 

public static void Goo () {

double input = 0.0;

do
{
    Console.WriteLine("Please enter floating point value");
}
while (!double.TryParse(Console.ReadLine(), out input));




Console.WriteLine(Math.Sqrt(input));
Console.WriteLine(Math.Pow(input, 2));
Console.WriteLine(Math.Pow(input, 10));

}
}