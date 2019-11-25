using AutoMapper;
using Group15.EventManager.ApplicationLayer.Interfaces;
using Group15.EventManager.ApplicationLayer.ViewModels.Events;
using Group15.EventManager.ApplicationLayer.ViewModels.Users;
using Group15.EventManager.Domain.Commands.Users;
using Group15.EventManager.Domain.Models;
using Group15.EventManager.Domain.Models.Auth;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Group15.EventManager.ApplicationLayer.Services
{
    public class UserApplicationService : Service, IUserApplicationService
    {
        public UserApplicationService(IMapper mapper, IMediator mediator) : base(mapper, mediator)
        {
        }

        public async Task AddUserToEvent(AddUserToEventViewModel userViewModel)
        {
            var user = _mapper.Map<ApplicationUser>(userViewModel);
            var _event = _mapper.Map<Event>(userViewModel.Event);

            await _mediator.Send(new AddUserToEventCommand(user, _event));
        }
    }
}
