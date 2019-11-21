﻿using Group15.EventManager.Domain.Core.Repositories;
using Group15.EventManager.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group15.EventManager.Data.Interfaces
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        void SignCustomerUpForEvent(Guid eventId, Customer customer);
    }
}