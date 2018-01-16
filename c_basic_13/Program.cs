// Program to perform Basic 13 in C#
using System;
using System.Collections.Generic;

namespace c_basic_13
{
    class Program
    {
        // public static int maxx(int[] arr)
        // {
        //     int max_num = 0;
        //     foreach (int a in arr){
        //         if (a > max_num){
        //             max_num = a;
        //         }
        //     }
        //     return max_num;
        // }
        // public static string greater_y(int[] arr, int y=3){
        //     int counter=0;
        //     foreach (int i in arr )
        //     {
        //         if (i > y) {
        //             counter++;
        //         }
        //         return $"Number of items greater than y is {counter}";
        //     }
        // }
        static void Main(string[] args)
        {
            // Console.WriteLine("Below information address basic 13 algorithms in C#");
            // Print numbers 1-255
            // int a = 0;
            // while(a<256){
            // System.Console.WriteLine(a);
            // a++;
            // }

            // Print odd 1-255
            // int b = 0;
            // while(b<256){
            // if (b %2==0) {
            // System.Console.WriteLine(b);
            // } 
            // b++;
            // }

            // Print Num and Sum
            // int c = 1;
            // int c_sum = 0;
            // while (c<256){
            // System.Console.WriteLine("Current sum is {0} and new number is {1}", c_sum, c);
            // c_sum+= c;
            // c++;
            // }

            // Iterating thru Array
        //     int[] num_arr = new int[]
        //     { 1,2,4,10 };
        //     foreach (int i in num_arr){
        //         System.Console.WriteLine(i);
        //     }
        // }

        // Find Max
        // int[] ran = {2,3,8,80,1,30 };
        // int new_max = maxx(ran);
        // System.Console.WriteLine(new_max);

        // Get Average
        // int[] arr1 = {2,5,7,6};
        // int total = 0;
        // foreach (int i in arr1){
        //     total += i;
        // }
        // int avg1 = total/arr1.Length;
        // System.Console.WriteLine($"The avg of arr1 is {avg1}");

        // Array with odd numbers
        // Mine does not work
        // int[] oddy = {256/2};
        // for (int a = 0; a<256/2; a++){
        //     for (int i =1; i<256; i++){
        //         if (i%2!= 0)
        //         {
        //             oddy[a]=i;
        //             i++;
        //             break;

        //         }
        //     }

        // Greater than Y
        // Mine Does not work
        // int[] rand = {3,6,7,2,7,-2,4,78,8};
        // greater_y(rand,3);

        // Square the values
        // int[] nums = {1,4,6,7};
        // int i = 0;
        // while (i < nums.Length){
        //     nums[i] = i * i;
        // }
        // System.Console.WriteLine(nums[2]);

        // Elminate Negative Numbers
        // int[] nums={1,4,6,-6, 8,-10, -3};
        // for (int thing = 0; thing< nums.Length; thing++){
        //     if (nums[thing] < 0){
        //         nums[thing] = 0;
        //     }
        // }
        // foreach (int m in nums){
        //     System.Console.WriteLine(m);
        // }

        // Min, Max, and Average
        // int[] arr1 = {1,4,6,20,64,2,-7};
        // int min1 = 0;
        // int max1 = 0; 
        // int avg1= 0;
        // int tot1= 0;
        // int i = 0;
        // while (i < arr1.Length){
        //     tot1 += arr1[i];
        //     if (arr1[i] < min1) {
        //         min1 = arr1[i];}
        //     if (arr1[i] > max1) { 
        //         max1 = arr1[i];}
        //     i++;
        // }
        // avg1 = tot1/ arr1.Length;
        // System.Console.WriteLine(min1);
        // System.Console.WriteLine(max1);
        // System.Console.WriteLine(avg1);

        //Shifting values in an array
        // int[] arr2 = {2,4,6,3};
        // for (int b = 0; b< arr2.Length-1;b++){
        //     System.Console.WriteLine(arr2[b]);
        //     arr2[b] = arr2[b+1];
        //     arr2[arr2.Length-1]=0;
        // }

        // Change values to 0
        // object[] arr5 = new object[4];
        // for (int idx = 0; idx < arr5.Length; idx++)
        // {
        //     if ((int)arr5[idx] == 0)
        //     {
        //         arr5[idx] = "Dojo";
        //     }
        // }
        }
    }
}
