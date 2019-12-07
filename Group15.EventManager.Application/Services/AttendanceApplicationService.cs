using AutoMapper;
using Group15.EventManager.ApplicationLayer.Interfaces;
using Group15.EventManager.ApplicationLayer.ViewModels.Attendances;
using Group15.EventManager.Domain.Commands.Attendances;
using Group15.EventManager.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Group15.EventManager.ApplicationLayer.Services
{
    public class AttendanceApplicationService : Service, IAttendanceApplicationService
    {
        public AttendanceApplicationService(IMapper mapper, IMediator mediator) : base(mapper, mediator)
        {
        }

        public async Task SubmitAttendanceAfterEvent(CreateAttendanceViewModel attendanceViewModel)
        {
            var _event = _mapper.Map<Event>(attendanceViewModel.Event);
            var attendance = _mapper.Map<Attendance>(attendanceViewModel);
            await _mediator.Send(new AttendanceForEventCommand(_event, attendance));
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
