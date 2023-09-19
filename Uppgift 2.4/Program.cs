using System;

namespace Uppgift_2._4
{

    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Hur mycket tjänar person 1?");
            string person1Text = Console.ReadLine();
            Console.WriteLine("Hur mycket tjänar person 2?");
            string person2Text = Console.ReadLine();
            Console.WriteLine("Hur mycket tjänar person 3?");
            string person3Text = Console.ReadLine();
            int person1 = int.Parse(person1Text);
            int person2 = int.Parse(person2Text);
            int person3 = int.Parse(person3Text);
            int medellön = (person1 + person2 + person3) / 3;
            Console.WriteLine("Medellönen för de tre personerna är " + medellön + ".");

            Console.ReadKey();
        }
    }
}