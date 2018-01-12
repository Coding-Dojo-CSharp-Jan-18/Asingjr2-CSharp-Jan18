// Dojo Fundamentals...Array, List, Dictionary Practice
using System;
using System.Collections.Generic; //Required for use of Lists

namespace array_list_dict
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("Practice with arrays, lists, and dictionaries!");
            // Three sepearate ways to declare array, declaring default array, std, and create than declare later
            Console.WriteLine("Printing some regular array info");
            int[] first_array = new int[5];   
            int[] second_array = {1,4,6,7,5};
            int[] third_array;
            third_array = new int[] {3,5,6,7,4};
            // Write vs WriteLine...WriteLine adds line after item is printed
            Console.Write(first_array); 
            Console.WriteLine("Second");
            Console.WriteLine(first_array[4]);
            Console.WriteLine(second_array[4]);
            Console.WriteLine(third_array[4]);
            // Can iterate through an array
            Console.WriteLine("Iterating through string array of cars");
            string[] cars = {"Honda", "Mazda", "Ford"}; 
            for (int i=0; i< cars.Length; i++){
                Console.WriteLine($"I have a {cars[i]}");
            }
            // ******************************************************
            // Or like this using foreach which only allows you to see info but not add or change!!!!!!
            foreach ( string car in cars){
                Console.WriteLine("I own a {0}", car);
            }
            //****************************************
            // C# has multi-dimensional arrays that are squared (predifined array list of arrays) or jagges uneven list of array holding arrays
            // Multidimensional array declaration
            // This example contains 3 arrays -- each of these is length 2 -- all initialized to zeroes.
            int[,] array2D = new int[3, 2];
            // This is equivalent to:
            //  int [,] array2D = new int[3,2]  {  { 0,0 }, { 0,0 }, { 0,0 } }; 
            // This example has 2 large rows that each contain 3 arrays -- and each of those arrays is length 4.
            int[,,] array3D = new int[2, 3, 4]
                {
                    {  { 45,1,16,17 }, { 4,47,21,68 }, { 21,28,32,76 }  },
                    {  { 11,0,85,42 }, { 9,10,14,96 }, { 66,99,33,12 }  }
                };
            // Directly accessing a multidimensional array
            Console.WriteLine("Info from multidimensional array");
            Console.WriteLine(array2D[0, 1]);   // prints 0
            Console.WriteLine(array3D[1, 0, 3]); // prints 42
            Console.WriteLine("Info from jagged multidimensional array");
            // Jagged array declaration
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[4];
            jaggedArray[2] = new int[2];
            int[][] jaggedArray2 = new int[][] {
                new int[] {1,3,5,7,9},
                new int[] {0,2},
                new int[] {11,22,33,44}
            };
                        // Short-hand form
                        int[][] jaggedArray3 = {
                new int[] {1,3,5,7,9},
                new int[] {0,2},
                new int[] {11,22,33,44}
            };
            // You can even mix jagged and multi-dimensional arrays
            int[][,] jaggedArray4 = new int[3][,]
            {
            new int[,] { {1,3}, {5,7} },
            new int[,] { {0,2}, {4,6}, {8,10} },
            new int[,] { {11,22}, {99,88}, {0,9} }
            };
            // Working through each array in a jagged array
            foreach (int[] innerArr in jaggedArray)
            {
            Console.WriteLine("Inner array length is {0}", innerArr.Length);
            }
            // Accessing a jagged array
            Console.WriteLine(jaggedArray2[0][1]); // 3
            Console.WriteLine(jaggedArray3[2][3]); // 44
            // ***************************************************
            Console.WriteLine("***********************************************");
            Console.WriteLine("Moving on to LISTS");
            List<string> bikes = new List<string>(); // Just initialized empty list
            bikes.Add("Ford");
            bikes.Add("Kawaski");
            bikes.Add("BMW");
            bikes.Add("Moto Guzzi");
            bikes.Add("Suzuki");
            Console.WriteLine("Bike list item two is {0}", bikes[2]);
            Console.WriteLine($"We have {bikes.Count} manufacturers!!!");
            Console.WriteLine($"bike maker 3 is {bikes[3]}");
            Console.WriteLine("Adding Ducatti to as index 3");
            bikes.Insert(3, "Ducatti");
            // C# Lists have a lot of methods****************************
            // https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.110).aspx
            Console.WriteLine($"bike maker 3 is {bikes[3]}");
            bikes.Reverse();
            Console.WriteLine($"After reversing the list, bike maker 3 is {bikes[3]}");
            bikes.Sort();
            Console.WriteLine($"After sorting the list, bike maker 3 is {bikes[3]}");

            
            // ***************************************************
            Console.WriteLine("***********************************************");
            Console.WriteLine("Moving on to Dictionaries");
            Console.WriteLine("Created dictionary called profile with specific type identification and will iterate through twice");
            Dictionary<string, string> profile = new Dictionary<string, string>();
            profile.Add("Name", "Goku");
            profile.Add("Game", "DBZ");
            profile.Add("Move", "Kamahamaha");
            Console.WriteLine($"Profile name is {profile["Name"]}");
            // Iterating over a dictionary is strange because you must declair type as KeyValuePair<string,string>....if strings.... and access using entry.Key or entry.Value
            foreach (KeyValuePair<string,string> entry in profile)
            {
                Console.WriteLine(entry.Key + " "+entry.Value);
            }
            // Can also use "var" thing instead of KeyValuePair<type,type>
            Console.WriteLine("Iterating through using var");
            foreach (var fighter in profile)
            {
                Console.WriteLine(fighter.Key + " " + fighter.Value);
            }
            }
    }
}
