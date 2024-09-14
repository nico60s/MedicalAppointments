

using MedicalAppointment.Shared.Domain;

namespace MedicalAppointment.Modules.Auth.Domain.Credentials.Events
{
    public class CredentialCreatedDomainEvent : DomainEvent
    {
        public CredentialId CredentialId { get; }
        public CredentialCreatedDomainEvent(CredentialId id) : base(Guid.NewGuid())
        {
            OccurredOn = DateTime.UtcNow;
        }
    }
}
