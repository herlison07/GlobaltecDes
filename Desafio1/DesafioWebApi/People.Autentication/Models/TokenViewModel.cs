using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace People.Autentication.Models
{
    public class TokenViewModel
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public int expire_in { get; set; }
    }
}