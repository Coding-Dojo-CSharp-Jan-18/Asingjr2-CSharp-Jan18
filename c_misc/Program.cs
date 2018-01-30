// Program to practice misc concepts or techniques
using System;

namespace c_misc {
    class Program {
        static void Main (string[] args) {
            System.Console.WriteLine("***************************************");
            Console.WriteLine ("Misc C# concept practice");
            string words = "some words";
            int nums = 45480;
            bool th = true;
            System.Console.WriteLine($"Nums int variable is {nums} and th bool variable is {th} and type of each is num: {nums.GetType()} and th: {th.GetType()}");
            System.Console.WriteLine("***************************************");
            System.Console.WriteLine("Trying Case statements....if code block is blank next block executes...");
                    // Variable
            switch (nums)
            {
                // If statement
                case 50:
                    System.Console.WriteLine("is true");
                    break;
                // Final else statement
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
            System.Console.WriteLine("***************************************");
            System.Console.WriteLine("Practice with ternary statement which returns  a boolean value only");
            string tern = nums == 400 ? "400 is corect" : "nums is DEF not 400";
            System.Console.WriteLine($"The result of ternary true false for nums == 400 is {tern}");
            System.Console.WriteLine("***************************************");






        }
    }
}