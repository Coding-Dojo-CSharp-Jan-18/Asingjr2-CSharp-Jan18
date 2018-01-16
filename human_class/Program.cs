using System;

namespace human_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Human Joe = new Human("Joe");
            Human Mary = new Human("Mary", 5,6,4,95);
            System.Console.WriteLine(Mary.strength);
            System.Console.WriteLine(Joe.intelligence);
            System.Console.WriteLine(Mary.health);
            System.Console.WriteLine(Joe.health);
            Mary.Attack(Joe);
            System.Console.WriteLine(Joe.health);
        }
    }
}
