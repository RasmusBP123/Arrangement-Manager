using Blazor.Fluxor;
using Group15.EventManager.Client.Store.Actions.Events;

namespace Group15.EventManager.Client.Store.Events
{
    public class GetActiveEventsSuccessReducer : Reducer<GetActiveEventsState, GetActiveEventsSuccessAction>
    {
        public override GetActiveEventsState Reduce(GetActiveEventsState state, GetActiveEventsSuccessAction action)
        {
            return new GetActiveEventsState(isLoading: false,
                                            errorMessage: null,
                                            events: action._events);
        }
    }
}
