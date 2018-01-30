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
            switch (nums)
            {
                case 50:
                    System.Console.WriteLine("is true");
                    break;
                default:
                    System.Console.WriteLine("is false");
                    break;
            }
            switch (nums)
            {
                case 45480:
                case 50:
                    System.Console.WriteLine("is true");
                    break;
                default:
                    System.Console.WriteLine("is false");
                    break;
            }
            switch (th)
            {
                case false:
                    System.Console.WriteLine("dang");
                    break;
                default:
                    System.Console.WriteLine("darn");
                    break;
            }
            System.Console.WriteLine("***************************************");
            System.Console.WriteLine("Experimenting with cases and ternary statements");






        }
    }
}