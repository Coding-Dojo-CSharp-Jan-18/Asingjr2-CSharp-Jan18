// Program to practice unboxing
using System;
using System.Collections.Generic;

namespace unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Can call variable type object in list for flexibility and compile at run time
            List<object> ls1 = new List<object>();
            ls1.Add(7);
            ls1.Add(28);
            ls1.Add(-1);
            ls1.Add(true);
            ls1.Add("chair");
            int ls1_sum = 0;
            // C# can have variables exist as something but be referenced as something else
            foreach (var thing in ls1){
                System.Console.WriteLine(thing.GetType());
                if (thing is int){
                    ls1_sum += (int)thing;
                    // Cannot add object type and int type without casting..(int)variable
                }
                System.Console.WriteLine(thing);
            }
            System.Console.WriteLine(ls1_sum);
        }
    }
}
