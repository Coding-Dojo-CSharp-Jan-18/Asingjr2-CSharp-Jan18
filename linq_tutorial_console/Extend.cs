using System;
using System.Collections.Generic;
using linq_tutorial_console.Models;

namespace linq_tutorial_console.Extensions
{
    static class Extend
    {
        public static void Print<T>(this IEnumerable<T> items)
        {
            foreach(var item in items)
                System.Console.WriteLine(item);
        }

    }
}

// NEED TO PRACTICE ABOVE.  MY VERSION DOES NOT WORK LIKE ONE IN VIDEO