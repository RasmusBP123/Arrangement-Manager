using Group15.EventManager.Shared.Events;
using Group15.EventManager.Shared.Users;
using System.Collections.Generic;

namespace Group15.EventManager.Shared.Tickets
{
    public class UpdateTicketsViewModel
    {
        public UserModel User { get; set; }
        public IEnumerable<GetEventWithTicketsViewModel> Events { get; set; }
    }
}
