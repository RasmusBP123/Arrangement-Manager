using Group15.EventManager.ApplicationLayer.ViewModels.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group15.EventManager.ApplicationLayer.ViewModels.Users
{
    public class AddUserToEventViewModel
    {
        public Guid UserId { get; set; }
        public Guid EventId { get; set; }
    }
}
