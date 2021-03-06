﻿using Group15.EventManager.Shared.Enums;
using Group15.EventManager.Shared.Tickets;
using System;
using System.Collections.Generic;

namespace Group15.EventManager.Shared.Users
{
    public class GetUserFromEventViewModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public UserStatus Status { get; set; }
        public IEnumerable<GetTicketForCartViewModel> Tickets { get; set; }
    }
}
