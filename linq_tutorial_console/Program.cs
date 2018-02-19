using System;
using System.Collections.Generic;
using System.Linq;
using linq_tutorial_console.Models;
using linq_tutorial_console.Extensions;

namespace linq_tutorial_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // list of Person objects to run queries on
            List<Person> output = new List<Person>();
            output.Add(new Person("Joe", "Smith", 42, "Carpenter"));
            output.Add(new Person("Mable", "Jones", 61, "Nurse"));
            output.Add(new Person("Carie", "Rodegers", 23, "Dentist"));
            output.Add(new Person("Wayne", "Joseph", 31, "Astronaut"));
            output.Add(new Person("Art", "Barnes", 31, "Carpenter"));
            output.Add(new Person("Art", "Gi", 41, "Carpenter"));
            output.Add(new Person("Art", "Kilmonger", 10, "Carpenter"));
            output.Add(new Person("Miriam", "Smith", 42, "Carpenter"));
            output.Add(new Person("Mike", "Jones", 61, "Nurse"));
            output.Add(new Person("Leroy", "Rod", 90, "Plumber"));
            output.Add(new Person("Sarah", "Santa", 18, "Physicist"));
            output.Add(new Person("Katherine", "Guh", 50, "Teacher"));

            // Changing order...query return ienumberable that must be converted
            output = output.OrderBy(p => p.first).ToList();
            System.Console.WriteLine("Simple order by first name");
            foreach (var p in output)
            {
                System.Console.WriteLine($"First = {p.first} Age = {p.age}");
            }
            // Performing to sorts using ThenBy and second Lambda expression
            System.Console.WriteLine("***********Performing additional using sort using ThenBy and second Lambda expression");
            output = output.OrderBy(p => p.first).ThenBy(p => p.age).ToList();
            foreach (var p in output)
            {
                System.Console.WriteLine($"First = {p.first} Age = {p.age}");
            }
            // Query using where for age
            var output2 = output.Where(p => p.age > 40).Take(2);
            System.Console.WriteLine("***********Performing sort using where with age > 40 TAKING FIRST 2");
            foreach (var p in output2)
            {
                System.Console.WriteLine($"First = {p.first} Age = {p.age}");
            }
            var output2Reverse = output.Where(p => p.age > 40).Reverse();
            System.Console.WriteLine("***********Performing sort using where with age > 40  THEN REVERSE");
            foreach (var p in output2Reverse)
            {
                System.Console.WriteLine($"First = {p.first} Age = {p.age}");
            }
            var output3 = output.Where(p => p.age > 40 && p.job == "Plumber");
            System.Console.WriteLine("***********Performing sort using where with age > 40 and job == nurse");
            foreach (var p in output3)
            {
                System.Console.WriteLine($"First = {p.first} Age = {p.age}");
            }
            // Creating variable aggregates
            int totalAge = output.Sum(p => p.age);
            System.Console.WriteLine($"Created variable for total years based on list ages for people");
            // Built in Linq methods
            System.Console.WriteLine("***********BUILT IN METHODS FIRST, REPEAT, DISTINCT, ETC*********");
            Person firstOutput = output.First();
            System.Console.WriteLine($"*********************First item in list returned as object is {firstOutput.first}");
            Person firstOutput2 = output.First(p => p.job == "Nurse");
            System.Console.WriteLine($"*******************First item in list with job as nurse using FIRST and arguement is {firstOutput2.first}");
            Person firstOutput3 = output.Where(p => p.job == "Nurse").First();
            System.Console.WriteLine($"*******************First item in list with job as nurse using WHERE THEN FIRST is {firstOutput3.first}");
            Person firstOutput3Skip = output.Where(p => p.job == "Nurse").Skip(1).First();
            System.Console.WriteLine($"*******************First item in list with job as nurse using WHERE THEN FIRST THEN SKIP is {firstOutput3Skip.first}");
            // Repeat method
            System.Console.WriteLine($"*******************First item in list with job as nurse THEN REPEAT WHERE THEN FIRST THEN SKIP is {firstOutput3Skip.first}");
            // Repeat called on an enumerable (argment 1 = thing to repeat, arg = times)
            var firstOutput2Repeat = Enumerable.Repeat(firstOutput2, 3);
            foreach(var thing in firstOutput2Repeat){ System.Console.WriteLine(thing.job);}
            System.Console.WriteLine("******************TRYING STATIC PRINT METHOD");
            // Using ANY job
            bool outputAny= output.Any(p => p.job == "Astronaut");
            System.Console.WriteLine($"Any check as bool for jobs that are astronaut shows {outputAny}");
            // Trying out Let in QUERIES
            var outputLet = from user in output 
            let bestAge = 42
            where user.age == bestAge
            select user;
            foreach( var p in outputLet)
            {
                System.Console.WriteLine($"first name of search results using LET and VAR which is DYNAMIC and bypasses compile stage is {p.first}.");
            }
            System.Console.WriteLine("ABOVE RESULTS WORK BECAUSE VAR item is being determined as type object PERSON after bypassing regular COMPILE.  WICKED!!!! *****************");
            // Trying Contains
            System.Console.WriteLine("****************SELECTING users with new age adjustment of +10 years");
            var outputNewAge = from a in output
                                let age = a.age + 10
                                where age > 60
                                select new {a.age, a.first};
            foreach(var u in outputNewAge)
            {
                System.Console.WriteLine($"First name of users with new age is {u.first}");
            }
            // List of Job ovjects to use for queries
            System.Console.WriteLine("**************Added Jobs List");
            List<Job> jobs = new List<Job>
            {
                new Job(){type = "Plunber", difficulty = "Medium", avgSalary = 70},
                new Job(){type = "Nurse", difficulty = "Hard", avgSalary = 90},
                new Job(){type = "Carpenter", difficulty = "Easy", avgSalary = 40},
                new Job(){type = "Teacher", difficulty = "Medium", avgSalary = 60},
                new Job(){type = "HR", difficulty = "Outrageous", avgSalary = 70},
                new Job(){type = "Teacher", difficulty = "Outrageous", avgSalary = 100},
                new Job(){type = "Teacher", difficulty = "Outrageous", avgSalary = 30},
            };
            System.Console.WriteLine("*************************************Printing grouping of jobs with inner query for average salary********************");
            var userJob = from item in jobs
                        group item by item.type;
            // Key is price!!!
            foreach (var item in userJob)
            {
                System.Console.WriteLine($"Result of grouping of jobs by type {item.Key}");
                foreach(var element in item)
                {
                    System.Console.WriteLine($"AvgSalary is {element.avgSalary}");
                }
            }
            //  Creating type using INTO
            System.Console.WriteLine("***********Result of grouping of jobs by type, ordering alphabetically, and then displaying salary ");
            var userJobVar = from t in jobs
                          group t by t.type into groupType
                          orderby groupType.Key
                          select groupType;
            foreach (var item in userJobVar)
            {
                System.Console.WriteLine($"Result of grouping of jobs by type {item.Key}");
                foreach (var element in item)
                {
                    System.Console.WriteLine($"AvgSalary is {element.avgSalary}");
                }
            }
            // Trying Join!!!!!
            System.Console.WriteLine("********************JOIN where user job is same as jobs type*******");
            var userJob2 = from a in output
                            join b in jobs
                            on a.job equals b.type
                            select a;
            // Katherine will show up three time because there are three teachers
            foreach(var user in userJob2)
            {
                System.Console.WriteLine($"Join query result showing {user.first} for categories showing up in jobs list");
            }
            // Join trying one to many 
            System.Console.WriteLine("*************************************** User join results allowing you to reformat User elements");
            var userJob3 = from a in output
                           join b in jobs
                           on a.job equals b.type into matchedJobs
                           select new
                           { 
                               Name = $" First:{a.first} and Last:{a.last}",
                               tt = a.job,
                               JobMatches = matchedJobs
                           };
            foreach(var user in userJob3)
            {
                System.Console.WriteLine($"Name of user is {user.Name} and job is {user.tt}");
            }
            System.Console.WriteLine("***************************************Jobs join results allowing you to reformat jobs elements");
            var userJob4 = from b in jobs
                           join a in output
                           on b.type equals a.job into matchedJobs
                           select new
                           {
                               JobName = $" {b.type} /{b.avgSalary}",
                               diff = b.difficulty,
                           };
            foreach (var job in userJob4)
            {
                System.Console.WriteLine($"Type/salary of job is {job.JobName} and job difficulty is:{job.diff}");
            }
    }
}
}