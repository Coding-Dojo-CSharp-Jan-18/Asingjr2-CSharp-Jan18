using System;

namespace fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fundamentals Assignment");
            Console.WriteLine("Loop for 1 to 255");
            for (int i =1; i<256;i++){
                Console.WriteLine(i);
            }
            Console.WriteLine("Loop for 1 to 100 divisible by 3, 5, and both");
            for (int a=1; a<101; a++){
                if (a % 3 == 0){ Console.WriteLine("Fizz");}
                if (a % 5 == 0) { Console.WriteLine("Buzz");}
                if (a % 15== 00) { Console.WriteLine("FizzBuzz"); }
            }
            Console.WriteLine("Loop for 1 to 100 divisible by 3 and 5 but not both");
                for (int a=1; a<100; a++){
                    if (a % 3 == 0 && a%5 !=0){ Console.WriteLine("Fizz");}
                    if (a % 5 == 0 && a % 3 != 0) { Console.WriteLine("Buzz"); }
                }
            Console.Write("Loop for ten random numbers divisible by 3 or 5");
            Random rand = new Random();

            for (int i = 1; i<11; i++){  
                int value = rand.Next(101);
                
                if (value % 3 == 0 && value % 5 != 0) { Console.WriteLine($"Fizz {value}"); }
                if (value % 5 == 0 && value % 3 != 0) { Console.WriteLine($"Buzz {value}"); }
            }
        }
    }
}
