using Blazor.Fluxor;
using Group15.EventManager.Client.Store.Actions.Events;

namespace Group15.EventManager.Client.Store.Events
{
    public class GetActiveEventsFailureReducer : Reducer<GetActiveEventsState, GetActiveEventsFailedAction>
    {
        public override GetActiveEventsState Reduce(GetActiveEventsState state, GetActiveEventsFailedAction action)
        {
            return new GetActiveEventsState(isLoading: false,
                                            errorMessage: action.errorMessage,
                                            events: null);
        }
    }
}
