namespace Group15.EventManager.Application.ViewModels.Auth
{
    public class LoginResult
    {
        public string Name { get; set; }
        public bool Successful { get; set; }
        public string Error { get; set; }
        public string Token { get; set; }
    }
}
