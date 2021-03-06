﻿using AutoMapper;
using Group15.EventManager.ApplicationLayer.Interfaces;
using Group15.EventManager.ApplicationLayer.ViewModels.Users;
using Group15.EventManager.Domain.Commands.Users;
using Group15.EventManager.Domain.Queries.Users;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Group15.EventManager.ApplicationLayer.Services
{
    public class UserApplicationService : Service, IUserApplicationService
    {
        public UserApplicationService(IMapper mapper, IMediator mediator) : base(mapper, mediator)
        {
        }

        public async Task AddUserToEvent(AddUserToEventViewModel userEvent)
        {
            await _mediator.Send(new AddUserToEventCommand(userEvent.UserId, userEvent.EventId, userEvent.TicketAmount));
        }

        public async Task<IEnumerable<GetUserFromEventViewModel>> GetUsersFromEvent(Guid eventId)
        {
            var users = await _mediator.Send(new AllUsersFromEventQuery(eventId));
            var userViewModels = _mapper.Map<IEnumerable<GetUserFromEventViewModel>>(users);
            return userViewModels;
        }

        public async Task CancelEventFromUser(Guid userId, Guid eventId)
        {
            await _mediator.Send(new CancelEventForUserCommand(userId, eventId));
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
