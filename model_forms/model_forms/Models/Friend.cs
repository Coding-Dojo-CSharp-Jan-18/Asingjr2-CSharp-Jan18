using System;
using System.Collections.Generic;

namespace model_forms.Models
{
    public class Friend
    {
        public string Name {get; set;}
        public string Color {get; set;}
        public string Email { get; set; }
        public static List<Friend> GetFriends()
        {
            return new List<Friend>()
            {
                new Friend()
                {
                    Name = "Joe",
                    Color = "Red",
                    Email = "j1@j.com",
                },
                 new Friend()
                {
                    Name = "Suh",
                    Color = "Black",
                    Email = "j2@j.com",
                },
                 new Friend()
                {
                    Name = "Mary",
                    Color = "Brown",
                    Email = "j3@j.com",
                }
            };
        }
    }
}