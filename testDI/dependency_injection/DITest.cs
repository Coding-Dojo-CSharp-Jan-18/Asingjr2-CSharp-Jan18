using System;
using Microsoft.AspNetCore.Http;

namespace dependency_injection
{
    public class Test
    {
        public string Name;
        public string Location;
        public Test()
        {
            Name = "Julio";
            Location = "Atlanta";
        }
    }
}
