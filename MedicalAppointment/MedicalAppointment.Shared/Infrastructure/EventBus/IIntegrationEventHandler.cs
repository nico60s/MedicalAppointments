

using MediatR;

namespace MedicalAppointment.Shared.Infrastructure.EventBus
{
    public interface IIntegrationEventHandler<in TIntegrationEvent> : INotificationHandler<TIntegrationEvent>
      where TIntegrationEvent : IIntegrationEvent
    {

    }
}
