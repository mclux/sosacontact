using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SosaContact.Api.Models
{
    public class LoginVM
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class LoginResponseVM
    {
        public int UserID { get; set; }
        public string AuthToken { get; set; }
    }
}