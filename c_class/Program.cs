// Program to practice creating classes
// Functions are written outside of main program and then used within.
// Creating instances of classes 
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

            // Chaining methods is same as python and must return type of that class object
            myCar.Move(100.2);
            myCar.Honk();
            myCar.Honk().Move(500).Honk();
            System.Console.WriteLine(myCar.distance);

            // Creating instance of Person
            Person man = new Person("Randy", "NY", "1/5/17", 486214);
            System.Console.WriteLine(man.birthdayReadOnly);
            System.Console.WriteLine(Person.ClassName);
            System.Console.WriteLine(Car.NumCars);
            Car kia = new Car("Kia", 70.1);
            System.Console.WriteLine(kia.speed);

            // Checking count of cars
            System.Console.WriteLine($" Number of cars is {Car.NumCars}");

            // Creating instance with three defined attr
            IceTruck ram = new IceTruck("Green",80, 800);

            // Creating instance with two attr leaving default
            IceTruck ford = new IceTruck("Blue",9);

            // Creating instance with 1 attr
            IceTruck2 chevy = new IceTruck2("red");

            // Checking to see if Cars count increments up
            System.Console.WriteLine($" Number of cars is {Car.NumCars}");

            // Checking instance specific attribute infomration
            System.Console.WriteLine($"The color and icecreams are {ram.color} and {ram.NumIceCreams}");
            System.Console.WriteLine(ram.NumIceCreams);
            System.Console.WriteLine(ford.NumIceCreams);
            System.Console.WriteLine($"The color and icecreams are {ford.color} and {ford.NumIceCreams}");
            System.Console.WriteLine($"The color, speed, and icecreams are {ford.color}, {chevy.speed} and {ford.NumIceCreams}");
        }
    }
}
