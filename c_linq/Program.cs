// Program to practice using Linq

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace c_linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<string> StringList = new List<string> {
                              "apple",
                              "banana",
                              "carrot",
                              "asparagus",
                              "tomato",
                              "artichoke"
                          };
            IEnumerable<string> TransformedList = StringList.Where(str => str[0] == 'a');
            foreach (string thing in TransformedList){
            System.Console.WriteLine(thing);
            }
            // TransformedList == {"apple", "asparagus", "artichoke"}

        }
    }
}
