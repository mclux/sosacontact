using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SosaContact.Api.Models
{
    public class SosaContactResponse
    {
        public string ResponseType { get; set; }
        public string Message { get; set; }
        public dynamic Response { get; set; }
    }
}