using System;
using System.Collections.Generic;
using DbConnection;

namespace c_db_prac
{
    class Program
    {
        static void Main(string[] args)
        {
            // Up();
            Del();
            System.Console.WriteLine("Please enter your first name");
            string first = Console.ReadLine();
            System.Console.WriteLine(first.GetType());
            System.Console.WriteLine($"Your name is {first}");
            System.Console.WriteLine("Please enter your last name");
            string last = Console.ReadLine();
            System.Console.WriteLine("Please enter your favorite number");
            string fav_num = Console.ReadLine();
            string query = $"INSERT INTO users(FirstName, LastName, FavoriteNum, Created_At, Updated_At)              VALUES('{first}', '{last}', '{fav_num}', now(), now())";
            DbConnector.Execute(query);
            List<Dictionary<string, object>> thing = DbConnector.Query("SELECT * FROM Users");
            foreach (var result in thing)
            {
                System.Console.WriteLine(result["FirstName"]);
            }
            
        }
        static void Up()
        {
            // Need to tweak to make work
            System.Console.WriteLine("What name would you like to update? ");
            string uname = Console.ReadLine();
            System.Console.WriteLine("Please confirm correct first name: ");
            string fn = Console.ReadLine();
            System.Console.WriteLine("Please confirm correct last name: ");
            string ln = Console.ReadLine();
            System.Console.WriteLine("Please confirm correct favorite num: ");
            string favn = Console.ReadLine();
            string update_query = $"UPDATE SET Users FirstName = '{fn}', LastName = '{ln}', FavoriteNum = '{favn}'";
            DbConnector.Execute(update_query);
            List<Dictionary<string, object>>  update_result= DbConnector.Query($"SELECT * WHERE FirstName = '{uname}'");
        }
        static void Del()
        {
            System.Console.WriteLine("What name would you like to delete");
            string dell = Console.ReadLine();
            string del_query = $"DELETE FROM Users WHERE FirstName = '{dell}'";
            DbConnector.Execute(del_query);
        }
    }
}
