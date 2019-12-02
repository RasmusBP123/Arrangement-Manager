using System;
using System.Collections.Generic;
using System.Text;

namespace Group15.EventManager.Shared.Users
{
    public class GetUserFromEventViewModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
    }
}
