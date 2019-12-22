using Group15.EventManager.Domain.Core.Repositories;
using Group15.EventManager.Domain.Models;

namespace Group15.EventManager.Data.Interfaces
{
    public interface IAttendanceRepository : IRepository<Attendance>
    {
        void SubmitAttendanceAfterEvent(Event _event, Attendance attendance);
    }
}
