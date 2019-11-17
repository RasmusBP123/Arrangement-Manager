using Blazor.Fluxor;

namespace Group15.EventManager.Client.Store.Events
{
    public class GetActiveEventsFeature : Feature<GetActiveEventsState>
    {
        public override string GetName()
        {
            return "GetActiveEvents";
        }

        protected override GetActiveEventsState GetInitialState()
        {
            return new GetActiveEventsState(isLoading : false,
                                            errorMessage : null, 
                                            events : null);
        }
    }
}
