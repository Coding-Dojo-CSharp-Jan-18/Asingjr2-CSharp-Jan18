/* ************************************************************** */
// Program to practice Linq

using System;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Collections to work with
            List<Artist> Artists = JsonToFile<Artist>.ReadJson();
            List<Group> Groups = JsonToFile<Group>.ReadJson();

            //========================================================
            //Solve all of the prompts below using various LINQ queries
            //========================================================
            System.Console.WriteLine("***************Basic Linq examples");
            // Artists over 60
            var over40 = Artists.Where(old => old.Age > 60).ToList();
            System.Console.WriteLine("****************Artists over 60");
            System.Console.WriteLine(over40);
            
            // All artists sorted by age
            var allartists = Artists.OrderBy(old => old.Age).ToArray().Count();
            System.Console.WriteLine($"********All artists sorted by age {allartists}");

            // Artists over 55 sorted
            var agesort = Artists.OrderBy(old => old.Age > 55).ToList();
            System.Console.WriteLine("**********Artists over 55 sorted asc");
            foreach (var aged in agesort)
            {
                System.Console.WriteLine(aged.ArtistName);
            }

            // Artists over 55 sorted desc
            var agesorted = Artists.OrderByDescending(old => old.Age > 55).ToList();
            System.Console.WriteLine("**************Artists over 55 sorted desc");
            foreach (var aged in agesorted)
            {
                System.Console.WriteLine(aged.ArtistName);
            }

            //There is only one artist in this collection from Mount Vernon, what is their name and age?
            string vernon = Artists.Select(hm => hm.Hometown == "Mount Vernon").ToString();
            // could also do Artists.Where(artist => artist.Hometown == "Mount Vernon").Single();
            
            //Who is the youngest artist in our collection of artists?
            string young = Artists.OrderBy(art => art.Age).First().ToString();

            //Display all artists with 'William' somewhere in their real name
            List<Artist> willie = Artists.Where( willy => willy.RealName.Contains("William")).ToList();

            //Display the 3 oldest artist from Atlanta
            List<Artist> oldest_three = Artists.Where(art => art.Hometown == "Atlanta").OrderByDescending(art => art.Age).Take(3).ToList();


            //(Optional) Display the Group Name of all groups that have members that are not from New York City
            List<string> NonNewYorkGroups = Artists
                               .Join(Groups, artist => artist.GroupId, group => group.Id, (artist, group) => { artist.Group = group; return artist; })
                               .Where(artist => (artist.Hometown != "New York City" && artist.Group != null))
                               .Select(artist => artist.Group.GroupName)
                               .Distinct()
                               .ToList();
            Console.WriteLine("All groups with members not from New York City:");
            foreach (var group in NonNewYorkGroups)
            {
                Console.WriteLine(group);
            }

            //(Optional) Display the artist names of all members of the group 'Wu-Tang Clan'
        }
    }
}
