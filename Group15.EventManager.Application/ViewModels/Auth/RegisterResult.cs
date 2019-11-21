using System;
using System.Collections.Generic;
using System.Text;

namespace Group15.EventManager.Application.ViewModels.Auth
{
    public class RegisterResult
    {
        public bool Successful { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
