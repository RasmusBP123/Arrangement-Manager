using System;
using System.Collections.Generic;
using System.Text;

namespace Group15.EventManager.ApplicationLayer.ViewModels.Auth
{
    public class UpdateAccountPasswordModel
    {
        public Guid Id { get; set; }
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }
    }
}
