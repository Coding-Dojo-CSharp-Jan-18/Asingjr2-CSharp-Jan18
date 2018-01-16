// Program to practive a few basic concepts before moving forward
// Created TossCoin and TossMulipleCoin function
using System;
using System.Collections.Generic;
using System.Threading;

namespace puzzles
{
    class Program
    {
        //Random function generating random array, min, max, and sum
        public static int[] arr1(){
            int[] new_arr = new int[10];
            Random rand = new Random();
            int max1 = 0;
            int min1 = 0;
            int sum1 = 0;
            for (int item = 0; item< new_arr.Length; item++){
                new_arr[item] = rand.Next(5,26);
                System.Console.WriteLine(new_arr[item]);
            }
            for (int item2 = 0; item2 < new_arr.Length; item2++)
            {
                if(new_arr[item2] > max1){ max1 = new_arr[item2]; }
                if(new_arr[item2] < new_arr[0]) { min1 = new_arr[item2];}
                sum1 += new_arr[item2];
                System.Console.WriteLine(new_arr[item2]);
            }
            System.Console.WriteLine($"Min is {min1} and max is {max1}");
            return new_arr;
        }
        public static string TossCoin(){
            System.Console.WriteLine("Tossing a Coin");
            Thread.Sleep(2000);
            Random rand = new Random();
            int toss = rand.Next(0,2);
            System.Console.WriteLine(rand.Next(0,2));
            if (toss == 0){
            System.Console.WriteLine("Heads");
            }
            if (toss ==1)
            {
                System.Console.WriteLine("Tails");
            }
            return toss.ToString();
        }
        public static double TossMultipleCoin(int nums)
        {
            int heads = 0;
            int tails = 0;
            for (int i=0; i<nums; i++){
            System.Console.WriteLine("Tossing Coin");
            Thread.Sleep(1000);
            Random rand = new Random();
            int toss = rand.Next(0, 2);
            System.Console.WriteLine(rand.Next(0, 2));
            if (toss == 0)
            {
                heads++;
            }
            if (toss == 1)
            {
                tails++;
            }
            }
            System.Console.WriteLine($"There were {heads} heads and {tails} tails.");
            double ratio = heads / nums;
            System.Console.WriteLine(ratio);
            return ratio;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            arr1();
            arr1();
            TossCoin();
            TossCoin();
            TossMultipleCoin(5);
            TossMultipleCoin(7);
            TossMultipleCoin(3);
        }
    }
}
