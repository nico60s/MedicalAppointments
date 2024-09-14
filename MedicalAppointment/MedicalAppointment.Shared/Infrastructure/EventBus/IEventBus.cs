
namespace MedicalAppointment.Shared.Infrastructure.EventBus
{
    public interface IEventBus
    {
        Task PublishAsync<T>(T @event) where T : IIntegrationEvent;
        void Subscribe<T>(IIntegrationEventHandler<T> handler) where T : IIntegrationEvent;
        void StartConsuming();
    }

}
