using Group15.EventManager.Shared.Events;

namespace Group15.EventManager.Shared.Attendances
{
    public class CreateAttendanceViewModel
    {
        public int Invited { get; set; }
        public int Registered { get; set; }
        public int NotRegistred { get; set; }
        public bool Finished { get; set; }
        public SimpleEventViewModel Event { get; set; }
    }
}
