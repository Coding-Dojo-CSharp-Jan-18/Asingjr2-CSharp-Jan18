using System;

namespace first_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Below are basic print statements with some interpolation
            Console.WriteLine("Hello All Worlds!");
            // Interger variable define and used
            int testnum = 1001;
            Console.WriteLine("the following is an int var testnum", testnum);
            Console.WriteLine(testnum);
            Console.WriteLine("Writing in double quotations to practice string interpolation with brackets to write numbers like {0}", testnum);
            Console.WriteLine("Checking interpolation using two numbers and one string within WriteLines(), {0}{1}{2}", 1,2, "3");
            string mathy = $"Trying use of math functions in strings with 3 plus 6 equaling {3+6}, 4 multiplied by 1012 equaling {4*1012}";
            Console.WriteLine(mathy);
            Console.WriteLine($"{5*4} was created by inserting 4 * 5 into brackets within quotations as a string prefaced by the $ sign");
            // Trying basic for loop
            for (int i =1; i < 6; i++){
                Console.WriteLine("writing increasing variable");
                Console.WriteLine(i);
            }
            // Trying basic while loop
            int l = 4;
            while (l > 0){
                Console.WriteLine("Increasing variable with while loop");
                Console.WriteLine(l);
                l--;
            }
            // Trying random, rand.Next(), rand.Next(Int32), rand.Next(Int32, Int32), rand.NextDouble()
            Random rand = new Random();
            for (int a = 0; a < 4; a++){
                Console.WriteLine("Random integer followed by standard interger");
                Console.WriteLine(rand.Next(2,50));
                int thing = rand.Next(10); 
                Console.WriteLine(thing);
            }

        }
    }
}
