using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;

namespace linq_tutorial_console.Models
{
    public class Person
    {
        public string first {get; set;}
        public string last { get; set; }
        public int age { get; set; }
        public string job { get; set; }
        
        public Person(string f, string l, int a, string j)
        {
            first = f;
            last = l;
            age = a;
            job = j;

        }
    }

    public class Job
    {
        public string type { get; set; }
        public string difficulty { get; set; }
        public int avgSalary { get; set; } 
     
    }




}