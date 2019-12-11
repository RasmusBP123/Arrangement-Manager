using System;

namespace Group15.EventManager.ApplicationLayer.ViewModels.Attendances
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
