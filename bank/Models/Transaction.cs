
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace bank.Models
{
    public class Transaction 
    {
        public int transactionID { get; set; }
        public string type { get; set; }
        public int amount { get; set; }
        public int accountsID { get; set; }
    }
}