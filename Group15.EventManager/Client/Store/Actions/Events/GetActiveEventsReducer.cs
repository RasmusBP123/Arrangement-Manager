using Blazor.Fluxor;
using Group15.EventManager.Client.Store.Actions.Events;

namespace Group15.EventManager.Client.Store.Events
{
    public class GetActiveEventsReducer : Reducer<GetActiveEventsState, GetActiveEventsAction>
    {
        public override GetActiveEventsState Reduce(GetActiveEventsState state, GetActiveEventsAction action)
        {
            return new GetActiveEventsState(isLoading: true, errorMessage: null, events: null);
        }
    }
}
