using Group15.EventManager.Data.Interfaces;
using Group15.EventManager.Data.UnitOfWork;
using Group15.EventManager.Domain.Commands.Attendances;
using Group15.EventManager.Domain.Handlers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Group15.EventManager.Domain.CommandHandlers
{
    public class AttendanceCommandHandler : Handler, IRequestHandler<AttendanceForEventCommand, bool>
    {
        private readonly IAttendanceRepository _attendanceRepository;

        public AttendanceCommandHandler(IUnitOfWork unitOfWork, IAttendanceRepository attendanceRepository) : base(unitOfWork)
        {
            _attendanceRepository = attendanceRepository;
        }

        public Task<bool> Handle(AttendanceForEventCommand request, CancellationToken cancellationToken)
        {
            _attendanceRepository.SubmitAttendanceAfterEvent(request.Event, request.Attendance);
            _unitOfWork.Commit();
            return Task.FromResult(true);
        }
    }
}
