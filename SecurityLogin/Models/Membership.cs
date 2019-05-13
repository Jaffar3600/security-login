using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SecurityLogin.Models
{
    public class Membership
    {
        public int Id { get; set; }
        public String Username { get; set; }
        public string Password { get; set; }
    }
}