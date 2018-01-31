using System;
using Microsoft.AspNetCore.Http;

namespace session
{
    public class Hero
    {
        public string name {get; set;}
        public string power {get; set;}
        public int age { get; set;}
        public Hero(string nm, string pw, int a)
        {
            name = nm;
            power = pw;
            age = a;
        }
        public Hero Info()
        {
            System.Console.WriteLine($"name, power, age {this.name}, {this.power}, {this.age}.");
            return this;
        }
    }
}