using Group15.EventManager.ApplicationLayer.ViewModels.Tickets;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Group15.EventManager.ApplicationLayer.Interfaces
{
    public interface ITicketApplicationService : IDisposable
    {
        Task<IEnumerable<GetTicketForCartViewModel>> GetTicketsForCart(Guid userId);
        Task DeleteTicket(Guid ticketId);
    }
}
