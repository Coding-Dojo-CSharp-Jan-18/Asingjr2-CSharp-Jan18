// Program to practice creating functions
// *********************FUNCTIONS MUST BE DECLARED OUTSIDE OF MAIN AND DEFAULT TO PRIVATE***********************
using System;

namespace c__functions
{
    class Program
    {
        public static void SayHello(string name)
        {
            System.Console.WriteLine($"Sup, {name}, here are some words from created function SayHello function");
        }
        // Can create function with a default argument in case on is not passed directly...name="Hey Stranger"
        public static void SayHi(string name="Stranger")
        {
            System.Console.WriteLine($"Sup, {name}, here are some words from created function SayHi function");
        }
        // Function that returns data reverse nothing like void
        // Can use $ Outside of console.write statements......!!!!!!!!!!!
        public static string SayHi2(string name = "Stranger")
        {
            return $"Sup, {name}, here are some words from created function SayHi function";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string person_name = "Joe";
            SayHello("Robert");
            SayHello(person_name);
            SayHi();
            SayHi(person_name);
            string sent = SayHi2(person_name);
            // Using information returned from variable
            System.Console.WriteLine("Welcome to C#.  {0}", sent);
        }
    }
}
