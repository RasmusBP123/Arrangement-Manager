using Group15.EventManager.ApplicationLayer.ViewModels.Events;
using System;

namespace Group15.EventManager.ApplicationLayer.ViewModels.Attendances
{
    public class CreateAttendanceViewModel
    {
        public Guid Id { get; set; }
        public int Invited { get; set; }
        public int Registered { get; set; }
        public int NotRegistred { get; set; }
        public bool Finished { get; set; }
        public SimpleEventViewModel Event { get; set; }
    }
}
