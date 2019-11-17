using Group15.EventManager.Domain.Core.Queries;
using Group15.EventManager.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group15.EventManager.Domain.Queries.Events
{
    public class AllEventsQuery : Query<IQueryable<Event>>
    {
    }
}
