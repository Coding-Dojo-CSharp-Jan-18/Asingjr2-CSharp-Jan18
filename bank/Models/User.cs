using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace bank.Models
{
    public class User : BaseEntity
    {
        public int userID {get;set;}
        public string userFirst { get; set; }
        public string userLast { get; set; }    
        public string userEmail { get; set; }   
        public string userPassword { get; set; }    
    }
}