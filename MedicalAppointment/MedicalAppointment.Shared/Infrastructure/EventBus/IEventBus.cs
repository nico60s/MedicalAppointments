

using MediatR;
using MedicalAppointment.Shared.Domain;
using Microsoft.Extensions.DependencyInjection;

namespace MedicalAppointment.Shared.Infrastructure.EventBus
{
    public interface IEventBus
    {
        Task PublishAsync<TEvent>(TEvent @event) where TEvent : IDomainEvent;
    }

    public class EventBus : IEventBus
    {
        private readonly IServiceProvider _serviceProvider;

        public EventBus(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task PublishAsync<TEvent>(TEvent @event) where TEvent : IDomainEvent
        {
            var handlers = _serviceProvider.GetServices<INotificationHandler<TEvent>>();
            foreach (var handler in handlers)
            {
                await handler.Handle(@event, CancellationToken.None);
            }
        }
    }

}
