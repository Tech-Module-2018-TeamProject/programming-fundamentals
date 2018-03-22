using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp37
{
    class Program
    {
        static void Main()
        {

            //Reading name of the drink
            string name = Console.ReadLine();
            //Reading volume
            var volume = double.Parse(Console.ReadLine());
            //Reading energy
            var energy = double.Parse(Console.ReadLine());
            //Reading sugar
            var sugar = double.Parse(Console.ReadLine());

            //Calculating zahar
            double zahar = volume / 100;

            //Writing the volume and name of the drink
            Console.WriteLine($"{volume}ml {name}:");
            //Calculating and writing kcal and grams of sugars
            Console.WriteLine($"{(energy * zahar)}kcal, {(sugar * zahar)}g sugars");

        }
    }
}
