using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Group15.EventManager.Client.Store.Actions.Events
{
    public class GetActiveEventsFailedAction
    {
        public string errorMessage { get; set; }

        public GetActiveEventsFailedAction(string errorMessage)
        {
            this.errorMessage = errorMessage;
        }
    }
}
