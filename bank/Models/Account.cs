using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace bank.Models
{
    public class Account : BaseEntity
    {
        public int accountID { get; set; }
        public int balance { get; set; }
        public int usersID { get; set; }
        // Adding list to access users list
        public List<UserAccount> accountInfo {get;set;}
    }
}