using Group15.EventManager.Application.ViewModels.Auth;
using Group15.EventManager.ApplicationLayer.ViewModels.Events;
using System.Collections.Generic;

namespace Group15.EventManager.ApplicationLayer.ViewModels.Tickets
{
    public class UpdateTicketsViewModel
    {
        public int Amount { get; set; }
        public UserModel User { get; set; }
        public IEnumerable<UpdateEventWithTicketsViewModel> Events { get; set; }
    }
}
