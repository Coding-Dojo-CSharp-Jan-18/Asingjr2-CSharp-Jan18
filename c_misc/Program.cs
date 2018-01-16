// Program to practice misc concepts or techniques
using System;

namespace c_misc {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Misc C# concept practice");
            string words = "some words";
            int nums = 45480;
            bool th = true;
            System.Console.WriteLine (nums.GetType ());
            System.Console.WriteLine (words.GetType ());
            try {
                if (th is int) {
                    System.Console.WriteLine ("Th is a bool");
                }
            } catch {
                System.Console.WriteLine ("Not working");
            }
        }
    }
}