

using MediatR;

namespace MedicalAppointment.Shared.Infrastructure.EventBus
{
    public interface IIntegrationEvent : INotification
    {
        Guid Id { get; }
        DateTime OccurredOn { get; }
    }
}
