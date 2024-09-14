using MediatR;

namespace MedicalAppointment.Shared.Domain
{
    public interface IIntegrationEvent : INotification
    {
        public Guid Id { get; }
        public DateTime OccurredOn { get; }
    }
}
