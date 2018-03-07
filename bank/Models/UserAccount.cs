using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace bank.Models
{
    public abstract class BaseEntity { }
    public class UserAccount : BaseEntity
    {
        public int useraccountID { get; set; }
        public int userID { get; set; }
        public int accountID { get; set; }
    }
}