using Group15.EventManager.Shared.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group15.EventManager.Shared.Attendances
{
    public class CreateAttendanceViewModel
    {
        public int Invited { get; set; }
        public int Registered { get; set; }
        public int NotRegistred { get; set; }
        public SimpleEventViewModel Event { get; set; }
    }
}
