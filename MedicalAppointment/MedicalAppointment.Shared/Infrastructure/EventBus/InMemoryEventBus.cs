


namespace MedicalAppointment.Shared.Infrastructure.EventBus
{
    public class InMemoryEventBus : IEventBus
    {
        private readonly Dictionary<string, List<IIntegrationEventHandler>> _handlers;

        public InMemoryEventBus()
        {
            _handlers = [];
        }
        public async Task Publish<T>(T @event) where T : IntegrationEvent
        {
            var eventType  = @event.GetType().FullName;
            if (eventType is null) return;
            
            var integrationEventHandlers = _handlers[eventType]; //Muchas handlers suscriptos a un evento

            foreach(var integrationEventHandler in integrationEventHandlers)
            {
                if(integrationEventHandler is IIntegrationEventHandler<T> handler)
                {
                    await handler.Handle(@event);
                }
            }
        }

        public void StartConsuming()
        {
            throw new NotImplementedException();
        }

        public void Subscribe<T>(IIntegrationEventHandler.IIntegrationEventHandler<T> handler) where T : IntegrationEvent
        {
            throw new NotImplementedException();
        }
    }
}
