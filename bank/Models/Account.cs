using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace bank.Models
{
    public class Account : BaseEntity
    {
        public int userID { get; set; }
        public int balance { get; set; }
        public int usersID { get; set; }
    }
}