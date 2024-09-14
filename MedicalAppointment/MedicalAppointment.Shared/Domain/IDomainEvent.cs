using MediatR;

namespace MedicalAppointment.Shared.Domain
{
    public interface IDomainEvent : INotification
    {
        public Guid Id { get; }
        public DateTime OccurredOn { get; }
    }
}
