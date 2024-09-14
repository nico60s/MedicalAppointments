

namespace MedicalAppointment.Shared.Infrastructure.EventBus
{
    public interface IEventBus
    {
        Task Publish<T>(T @event)
          where T : IntegrationEvent;

        void Subscribe<T>(IIntegrationEventHandler<T> handler)
            where T : IntegrationEvent;

        void StartConsuming();
    }

}
