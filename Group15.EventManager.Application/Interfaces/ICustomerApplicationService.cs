using Group15.EventManager.ApplicationLayer.ViewModels.Customers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Group15.EventManager.ApplicationLayer.Interfaces
{
    public interface ICustomerApplicationService
    {
        Task SignCustomerUpForEvent(Guid eventId, SignUpCustomerViewModel customerViewModel);
    }
}
