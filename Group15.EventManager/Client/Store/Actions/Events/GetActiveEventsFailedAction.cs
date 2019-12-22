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
