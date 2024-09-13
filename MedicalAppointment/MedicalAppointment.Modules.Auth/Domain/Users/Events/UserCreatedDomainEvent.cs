using MedicalAppointment.Shared.Domain;

namespace MedicalAppointment.Modules.Auth.Domain.Users.Events
{
    public class UserCreatedDomainEvent : IDomainEvent
    {
        public Guid Id { get; } = Guid.NewGuid();
        internal UserId UserId { get; }
        public DateTime OccurredOn { get; }

        internal UserCreatedDomainEvent(UserId userId)
        {
            UserId = userId;
            OccurredOn = DateTime.UtcNow;
        }
    }
}
