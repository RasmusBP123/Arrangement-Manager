using Group15.EventManager.Domain.Core.Commands;
using Group15.EventManager.Domain.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Group15.EventManager.Domain.Commands.Attendances
{
    public class AttendanceForEventCommand : Command
    {
        public Event Event { get; }
        public Attendance Attendance { get; }

        public AttendanceForEventCommand(Event _event, Attendance attendance)
        {
            Event = _event;
            Attendance = attendance;
        }

    }
}
