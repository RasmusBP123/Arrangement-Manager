﻿using Group15.EventManager.Shared.Events;
using System;

namespace Group15.EventManager.Shared.Attendances
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
