﻿using Group15.EventManager.ApplicationLayer.ViewModels.Address_;
using Group15.EventManager.ApplicationLayer.ViewModels.Tickets;
using System;
using System.Collections.Generic;

namespace Group15.EventManager.ApplicationLayer.ViewModels.Events
{
    public class GetEventWithTicketsViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int CurrentAmountOfCustomers { get; set; }
        public int MaxCustomerLimit { get; set; }
        public IEnumerable<GetTicketForCartViewModel> Tickets { get; set; }
        public GetAddressForEventViewModel Address { get; set; }
    }
}
