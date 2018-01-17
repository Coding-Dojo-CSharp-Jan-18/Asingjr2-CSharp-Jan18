/* 
Program to practice the creation of classes with interfaces
They can only contain function declarations
Implemented variations must return same type
Class can have more than one
*/


namespace c_interfaces
{
    interface food
    {
        string foods();
        // Interfaces can only contain function declarations
    }
    interface drink
    {
        string drinks();
    }
    class Dinner : food
    {
        public string foods()
        {
            return "Cake";
        }
    }
    class Breakfast : food, drink
    {
        public string foods()
        {
            return "Eggs";
        }
        public string drinks()
        {
            System.Console.WriteLine("I like water");
            return "WATER";
        }
    }
    }

