using Group15.EventManager.Data.Interfaces;
using Group15.EventManager.Domain.Models;
using System.Linq;
using Group15.EventManager.Data.Context;

namespace Group15.EventManager.Data.Repositories
{
    public class AttendanceRepository : Repository<Attendance>, IAttendanceRepository
    {
        public AttendanceRepository(SqlContext context) : base(context)
        {
        }

        public void SubmitAttendanceAfterEvent(Event _event, Attendance attendance)
        {
            Db.Set<Event>().Attach(_event);
            _event.Attendance = attendance;
        }
    }
}
