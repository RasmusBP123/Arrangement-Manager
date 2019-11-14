using Group15.EventManager.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Group15.EventManager.Application.Interfaces
{
    public interface IEventApplicationService
    {
        Task<IEnumerable<GetEventViewModel>> GetAllEvents();
    }
}
