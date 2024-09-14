
using static MedicalAppointment.Shared.Infrastructure.EventBus.IIntegrationEventHandler;

namespace MedicalAppointment.Shared.Infrastructure.EventBus
{
    public class InMemoryEventBus
    {
        private readonly IDictionary<string, List<object>> _handlersDictionary;

        private InMemoryEventBus()
        {
            _handlersDictionary = new Dictionary<string, List<object>>();
        }
        public static InMemoryEventBus Instance { get; } = new InMemoryEventBus();

        public void Subscribe<T>(IIntegrationEventHandler<T> handler)
            where T : IntegrationEvent
        {
            var eventType = typeof(T).FullName;

            if (eventType != null)
            {
                if (!_handlersDictionary.TryGetValue(eventType, out List<object>? value))
                {
                    value = [];
                    _handlersDictionary[eventType] = value;
                }

                value.Add(handler);
            }
        }

        public async Task Publish<T>(T @event)
            where T : IntegrationEvent
        {
            var eventType = @event.GetType().FullName;

            if (eventType == null || !_handlersDictionary.TryGetValue(eventType, out List<object>? value))
            {
                return;
            }

            var handlers = value;

            foreach (var handler in handlers)
            {
                if (handler is IIntegrationEventHandler<T> integrationEventHandler)
                {
                    try
                    {
                        await integrationEventHandler.Handle(@event);
                    }
                    catch (Exception ex)
                    {
                        
                        throw new Exception($"Error handling event: {ex.Message} in EventBus");
                    }
                }
            }
        }
    }
