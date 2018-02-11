using System;
using System.Collections.Generic;
using model_forms.Models;

namespace model_forms.Models
{
    public class IndexViewModel
    {
        public Friend MyFriend {get; set;}
        public List<Friend> Friends {get;set;}
        public string Message {get; set;}
    }
}

// Creating play model to experiment with View function in controller