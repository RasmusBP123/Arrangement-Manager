using Group15.EventManager.Shared.Users;
using System.Collections.Generic;

namespace Group15.EventManager.Client.Store.Users
{
    public class UserStore
    {
        public IEnumerable<GetUserFromEventViewModel> UsersFromEvent { get; set; } = new List<GetUserFromEventViewModel>();
        public GetUserFromEventViewModel UserFromEvent { get; set; } = new GetUserFromEventViewModel();
    }
}
