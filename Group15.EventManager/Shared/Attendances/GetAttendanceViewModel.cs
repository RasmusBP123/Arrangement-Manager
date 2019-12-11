using System;
using System.Collections.Generic;
using System.Text;

namespace Group15.EventManager.Shared.Attendances
{
    public class GetAttendanceViewModel
    {
        public Guid Id { get; set; }
        public int Invited { get; set; }
        public int Registered { get; set; }
        public int NotRegistred { get; set; }
        public bool Finished { get; set; }
    }
}
