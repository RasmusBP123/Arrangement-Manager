using System.Collections.Generic;

namespace Group15.EventManager.Shared.Auth
{
    public class RegisterResult
    {
        public bool Successful { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
