using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterStats_Alternative
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var health = int.Parse(Console.ReadLine());
            var maxHealth = int.Parse(Console.ReadLine());
            var energy = int.Parse(Console.ReadLine());
            var maxEnergy = int.Parse(Console.ReadLine());
            var healthEmpty = maxHealth - health;
            var energyEmpty = maxEnergy - energy;

            Console.WriteLine("Name: {0}", name);

            Console.Write("Health: " + "|");
            Console.Write("{0}{1}", new string('|', health), new string('.', healthEmpty));
            Console.WriteLine("|");
   
            Console.Write("Energy: " + "|");
            Console.Write("{0}{1}", new string('|', energy), new string('.', energyEmpty));
            Console.WriteLine("|");
        }
    }
}
