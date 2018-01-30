// Program to practice misc concepts or techniques
using System;

namespace c_misc {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Misc C# concept practice");
            string words = "some words";
            int nums = 45480;
            bool th = true;
            System.Console.WriteLine($"Nums int variable is {nums} and th bool variable is {th} and type of each is num: {nums.GetType()} and th: {th.GetType()}");
            try {
                if (th is int) {
                    System.Console.WriteLine ("Th is a bool");
                }
            } catch {
                System.Console.WriteLine ("Not working");
            }

            System.Console.WriteLine("***************************************");
            System.Console.WriteLine("Experimenting with cases and ternary statements");
                        





        }
    }
}