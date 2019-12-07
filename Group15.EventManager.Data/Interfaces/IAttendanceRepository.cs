using Group15.EventManager.Data.Migrations;
using Group15.EventManager.Domain.Core.Repositories;
using Group15.EventManager.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group15.EventManager.Data.Interfaces
{
    public interface IAttendanceRepository : IRepository<Attendance>
    {
        void SubmitAttendanceAfterEvent(Event _event, Attendance attendance);
    }
}
