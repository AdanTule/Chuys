using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChuysWebsite.Models
{
    public class MailListAddRequest
    {
        public string FirstName {get; set;}

        public string LastName { get; set; }

        public bool Unsubscribe { get; set; }

        public string Email { get; set; }
    }
}