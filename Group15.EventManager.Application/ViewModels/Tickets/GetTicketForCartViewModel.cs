using Group15.EventManager.ApplicationLayer.ViewModels.Events;
using System;

namespace Group15.EventManager.ApplicationLayer.ViewModels.Tickets
{
    public class GetTicketForCartViewModel
    {
        public Guid Id { get; set; }
        public GetSingleEventViewModel Event { get; set; }
    }
}
