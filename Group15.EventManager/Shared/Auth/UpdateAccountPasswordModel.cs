using System;
using System.Collections.Generic;
using System.Text;

namespace Group15.EventManager.Shared.Auth
{
    public class UpdateAccountPasswordModel
    {
        public Guid Id { get; set; }
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }
    }
}
