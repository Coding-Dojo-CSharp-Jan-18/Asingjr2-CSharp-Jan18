// Program to practice interfaces
// Can use interface through class "inheritence" or through creation of interface object as class obj
using System;

namespace c_interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("*********************");
            // Below are implementations of an interface thru different classes
            Dinner d1 = new Dinner();
            // Created string variable for output of returned information
            string new_food = d1.foods();
            System.Console.WriteLine(new_food);
            // Breakfast class below has two interfaces
            Breakfast b1 = new Breakfast();
            b1.foods();
            b1.drinks();

            // Interface that can use class interface function
            food italian = new Breakfast();
            string meal_type = italian.foods();
            System.Console.WriteLine($"Result of interfaced class method {meal_type}");
            // Can not utilize inface because the type of interface is restricted to type instantiated on
            // string drink_type = italian.drinks();
            // Could correct with [  drink drink_type = meal_type]

        }
    }
}
