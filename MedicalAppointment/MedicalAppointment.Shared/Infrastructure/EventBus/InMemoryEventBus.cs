﻿
using static MedicalAppointment.Shared.Infrastructure.EventBus.IIntegrationEventHandler;

namespace MedicalAppointment.Shared.Infrastructure.EventBus
{
    public class InMemoryEventBus : IEventBus
    {
        private readonly IDictionary<Type, List<object>> _handlersDictionary = new Dictionary<Type, List<object>>();

        public void Subscribe<T>(IIntegrationEventHandler<T> handler) where T : IIntegrationEvent
        {
            var eventType = typeof(T);

            if (!_handlersDictionary.ContainsKey(eventType))
            {
                _handlersDictionary[eventType] = [];
            }

            _handlersDictionary[eventType].Add(handler);
        }

        public async Task PublishAsync<T>(T @event) where T : IIntegrationEvent
        {
            var eventType = typeof(T);

            if (!_handlersDictionary.ContainsKey(eventType))
            {
                return;
            }

            var handlers = _handlersDictionary[eventType];
            foreach (var handler in handlers)
            {
                if (handler is IIntegrationEventHandler<T> integrationEventHandler)
                {
                    await integrationEventHandler.Handle(@event, CancellationToken.None);
                }
            }
        }

        public void StartConsuming()
        {
            // Implementar la lógica para iniciar el consumo de eventos, si es necesario
        }
    }
}
