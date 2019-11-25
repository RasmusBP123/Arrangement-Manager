using Group15.EventManager.Domain.Core.Commands;
using Group15.EventManager.Domain.Models;
using Group15.EventManager.Domain.Models.Auth;

namespace Group15.EventManager.Domain.Commands.Users
{
    public class AddUserToEventCommand : Command
    {
        public ApplicationUser User { get; }
        public Event Event { get; }

        public AddUserToEventCommand(ApplicationUser user, Event _event)
        {
            User = user;
            Event = _event;
        }
    }
}
