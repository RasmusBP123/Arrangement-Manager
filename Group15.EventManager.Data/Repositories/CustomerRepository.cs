using Group15.EventManager.Data.Context;
using Group15.EventManager.Data.Interfaces;
using Group15.EventManager.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group15.EventManager.Data.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(SqlContext sqlContext) : base(sqlContext)
        {
        }

        public void SignCustomerUpForEvent(Guid eventId, Customer customer)
        {
            var _event = Db.Set<Event>().FirstOrDefault(e => e.Id == eventId);
            _event.Customers.Add(customer);
        }
    }
}
