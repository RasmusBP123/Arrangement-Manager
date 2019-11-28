using Group15.EventManager.Shared.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Group15.EventManager.Client.Store.Users
{
    public class UserStore
    {
        public IEnumerable<GetUserFromEventViewModel> UsersFromEvent { get; set; } = new List<GetUserFromEventViewModel>();
        public GetUserFromEventViewModel UserFromEvent { get; set; } = new GetUserFromEventViewModel();
    }
}
