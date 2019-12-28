using Group15.EventManager.Shared.Users;
using System;

namespace Group15.EventManager.Client.Store.Auth
{
    public class AuthStore
    {
        public UserModel User = new UserModel();
        public event Action OnLogin;
        public event Action OnChangedPassword;
        public void NotifyUserAccount() => OnChangedPassword.Invoke();
        public void NotifyLogin() => OnLogin.Invoke();
    }
}
