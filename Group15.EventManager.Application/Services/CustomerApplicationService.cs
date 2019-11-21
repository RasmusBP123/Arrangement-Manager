using AutoMapper;
using Group15.EventManager.ApplicationLayer.Interfaces;
using Group15.EventManager.ApplicationLayer.ViewModels.Customers;
using Group15.EventManager.Data.UnitOfWork;
using Group15.EventManager.Domain.Commands.Customers;
using Group15.EventManager.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Group15.EventManager.ApplicationLayer.Services
{
    public class CustomerApplicationService : Service, ICustomerApplicationService
    {
        public CustomerApplicationService(IMapper mapper, IMediator mediator) : base(mapper, mediator)
        {
        }

        public async Task SignCustomerUpForEvent(Guid eventId, SignUpCustomerViewModel customerViewModel)
        {
            var customer = _mapper.Map<Customer>(customerViewModel);
            await _mediator.Send(new SignCustomerUpForEventCommand(eventId, customer));
        }
    }
}
