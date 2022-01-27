using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    public class Func10 {

      public static void tabell () {
    

        for (int i = 0; i <= 10; i++)
{
    Console.Write(i + "\t");
    for (int j = 1; j <= 10; j++)
    {
        if (i > 0) Console.Write(i* j + "\t");
        else Console.Write(j + "\t");
    }
    Console.Write("\n");
}

}
}

