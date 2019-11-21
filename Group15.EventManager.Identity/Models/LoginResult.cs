using System;
using System.Collections.Generic;
using System.Text;

namespace Group15.EventManager.Identity.Models
{
    public class LoginResult
    {
        public string Name { get; set; }
        public bool Successful { get; set; }
        public string Error { get; set; }
        public string Token { get; set; }
    }
}
