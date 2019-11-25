using Group15.EventManager.ApplicationLayer.ViewModels.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group15.EventManager.ApplicationLayer.ViewModels.Users
{
    public class AddUserToEventViewModel
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public GetSingleEventViewModel Event { get; set; }
    }
}
