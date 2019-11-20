using Group15.EventManager.Data.Interfaces;
using Group15.EventManager.Data.UnitOfWork;
using Group15.EventManager.Domain.Commands.Customers;
using Group15.EventManager.Domain.Handlers;
using Group15.EventManager.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Group15.EventManager.Domain.CommandHandlers
{
    public class CustomerCommandHandler : Handler, IRequestHandler<SignCustomerUpForEventCommand, bool>
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerCommandHandler(IMediator mediator, IUnitOfWork unitOfWork, ICustomerRepository customerRepository) : base(mediator, unitOfWork)
        {
            _customerRepository = customerRepository;
        }

        public async Task<bool> Handle(SignCustomerUpForEventCommand request, CancellationToken cancellationToken)
        {
            _customerRepository.SignCustomerUpForEvent(request.EventId, request.Customer);

            if (!_unitOfWork.Commit())
            {
                await Task.FromCanceled(cancellationToken);
            }

            return true;
        }
    }
}
