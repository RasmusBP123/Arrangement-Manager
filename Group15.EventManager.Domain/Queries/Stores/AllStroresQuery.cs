using Group15.EventManager.Domain.Core.Queries;
using Group15.EventManager.Domain.Models;
using System.Linq;

namespace Group15.EventManager.Domain.Queries.Stores
{
    public class AllStroresQuery : Query<IQueryable<Store>>
    {
    }
}
