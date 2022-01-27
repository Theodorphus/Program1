using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





public class Character
{


    Character myChar = new Character();

    Character enemy = new Character();


    public static void name1()
    {
        Console.Clear();
        Console.WriteLine("Enter the name of your character");
        string name = Console.ReadLine();
        Console.WriteLine("Your name is " + name);


    }

    public static void stats()
    {

        int health = Random.Shared.Next(1, 100);
        int strength = Random.Shared.Next(1, 100);
        int luck = Random.Shared.Next(1, 100);

        Console.WriteLine(" Your character's health is " + health + "  \n Your character's strength is " + strength + "  \n Your character's luck is " + luck);

        Console.WriteLine("\n Continue...");
    }
    public static void name2()
    {
        Console.Clear();
        Console.WriteLine("Enter the name of your enemy");
        string name = Console.ReadLine();
        Console.WriteLine("Your enemy is called " + name);


    }

    public static void stats2()
    {

        int health = Random.Shared.Next(1, 100);
        int strength = Random.Shared.Next(1, 100);
        int luck = Random.Shared.Next(1, 100);

        Console.WriteLine(" Your enemy's health is " + health + "  \n Your enemy's strength is " + strength + "  \n Your enemy's luck is " + luck);

        Console.WriteLine("\n Good luck.");
    }
}





