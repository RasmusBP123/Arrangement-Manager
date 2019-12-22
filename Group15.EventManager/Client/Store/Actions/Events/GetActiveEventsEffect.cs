using Blazor.Fluxor;
using Group15.EventManager.Client.Store.Actions.Events;
using Group15.EventManager.Shared.Events;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Group15.EventManager.Client.Store.Events
{
    public class GetActiveEventsEffect : Effect<GetActiveEventsAction>
    {
        public readonly HttpClient _client;
        public GetActiveEventsEffect(HttpClient client)
        {
            _client = client;
        }


        protected override async Task HandleAsync(GetActiveEventsAction action, IDispatcher dispatcher)
        {
            try
            {
                var events = await _client.GetJsonAsync<IEnumerable<GetEventListViewModel>>("api/events/active");
                foreach (var e in events)
                {
                    Console.WriteLine(e.Name);
                }
                dispatcher.Dispatch(new GetActiveEventsSuccessAction(events));
            }
            catch (Exception e)
            {
                dispatcher.Dispatch(new GetActiveEventsFailedAction(errorMessage: e.Message));
            }
        }
    }
}
