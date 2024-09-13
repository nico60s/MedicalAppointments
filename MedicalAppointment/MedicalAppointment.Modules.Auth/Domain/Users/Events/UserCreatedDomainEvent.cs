using MedicalAppointment.Shared.Domain;

namespace MedicalAppointment.Modules.Auth.Domain.Users.Events
{
    public class UserCreatedDomainEvent : DomainEvent
    {
        internal UserId UserId { get; }
        public DateTime OccurredOn { get; }

        internal UserCreatedDomainEvent(UserId userId) : base(Guid.NewGuid())
        {
            UserId = userId;
            OccurredOn = DateTime.UtcNow;
        }
    }
}
