// Collections Practice
// Program to practice using arrays, lists, and dictionarys
using System;
using System.Collections.Generic;

namespace collections_prac {
    class Program {
        static void Main (string[] args) {

            // Three Basic Arrays****************************
            Console.WriteLine ("Three Basic Arrays");
            int[] first = new int[10];
            for (int a = 0; a < 10; a++) {
                first[a] = a;
                Console.WriteLine (first[a]);
            };
            string[] second_names = { "Tim", "Martin", "Nikki", "Sara" };
            Console.WriteLine (second_names[2]);
            bool[] third = { true, false, true, false, true, false, true, false, true, false, };
            Console.WriteLine (third[1]);

            // Multiplication Table*************************
            int[, ] table1 = new int[10, 10];
            for (int i = 0; i < 10; i++) {
                for (int j = 0; j < 10; j++) {
                    table1[i, j] = (i + 1) * (j + 1);
                }
            }
            Console.WriteLine (table1[0, 2]);
            Console.WriteLine (table1[4, 8]);
            // My try at print out in table
            foreach (int list1 in table1) {
                Console.WriteLine ("[ " + list1 + " ]");
            }

            // Solution Print Out
            for (int x = 0; x < 10; x++) {
                // New bracket before each list
                string display = "[ ";
                for (int y = 0; y < 10; y++) {
                    //Add an extra space for single digit values
                    display += table1[x, y] + ", ";
                    if (table1[x, y] < 10) {
                        display += " ";
                    }
                }
                display += "]";
                Console.WriteLine (display);
            }

            // List of Flavors*****************************
            Console.WriteLine ("Creating list of ice cream flavors");
            List<string> flavors = new List<string> ();
            flavors.Add ("Vanilla");
            flavors.Add ("Choc");
            flavors.Add ("Rocky Road");
            flavors.Add ("Neo");
            flavors.Add ("Mint");
            Console.WriteLine (flavors.Count);
            Random rand = new Random ();
            Console.WriteLine (flavors[rand.Next (flavors.Count)]);
            flavors.RemoveAt (2);
            Console.WriteLine (flavors.Count);

            // User Info Dictionary**************************
            Dictionary<string, string> stuff = new Dictionary<string, string> ();
            // Used names to add to dictionary....must practice******
            foreach (string name in second_names) {
                stuff[name] = flavors[rand.Next(flavors.Count)];
            }
            Console.WriteLine (stuff["Tim"]);
            Console.WriteLine (stuff["Sara"]);
        }
    }
}

/*
for int i, i<10, i++
for int j, j<10, j++
table[i,j] = (i+i) * (j+1) 

Major Concepts to check out
Object initializer
List<string> words = new List<string>();
words.Add("words 1");
words.Add("words 2");

List<string> ohter_words = new List<string>(){
    "words1", "words2"
}
or can create immediately

*can hit f12 on thing to see stuff*
preferences,,,,keywords sortcuts.....go to definition...

optimization comes down to speed vs time
*/