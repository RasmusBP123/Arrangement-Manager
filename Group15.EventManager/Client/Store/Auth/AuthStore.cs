using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Group15.EventManager.Client.Store.Auth
{
    public class AuthStore
    {
        public event Action OnLogin;
        public void NotifyLogin() => OnLogin.Invoke();
    }
}
