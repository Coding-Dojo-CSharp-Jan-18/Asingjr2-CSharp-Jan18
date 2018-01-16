// Program to practice creating classes
// Functions are written outside of main program and then used within.
using System;

namespace c_class
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Vehicle myCar = new Vehicle(11);
            Vehicle myBike= new Vehicle(4);
            System.Console.WriteLine(myBike.passengers);
            System.Console.WriteLine(myCar.passengers);
            System.Console.WriteLine(myBike.distance);
            System.Console.WriteLine(myCar.distance);
            myCar.Move(100.2);
            System.Console.WriteLine(myCar.distance);
        }
    }
}
