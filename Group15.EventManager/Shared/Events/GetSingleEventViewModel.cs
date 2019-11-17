﻿using Group15.EventManager.Shared.Customers;
using Group15.EventManager.Shared.Food;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group15.EventManager.Shared.Events
{
    public class GetSingleEventViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public byte[] Image { get; set; }
        public DateTime EventDate { get; set; }
        public IEnumerable<GetCustomerViewModel> Customers { get; set; }
        public GetFoodViewModel Food { get; set; }
    }
}
