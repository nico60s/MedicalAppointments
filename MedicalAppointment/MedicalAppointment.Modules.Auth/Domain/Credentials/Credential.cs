using MedicalAppointment.Modules.Auth.Domain.Users;
using MedicalAppointment.Shared.Domain;

namespace MedicalAppointment.Modules.Auth.Domain.Credentials
{
    public class Credential : Entity<CredentialId>
    {
        private const string CREDENTIAL_HASH = "credentialHash";
        public CredentialId Id { get; }

        public override IReadOnlyCollection<IDomainEvent> Events => throw new NotImplementedException();

        private Credential(CredentialId id) : base(id)
        {
            Id = id;
        }
        public static Credential Create(UserId userId)
        {
            var hash = new Guid(CREDENTIAL_HASH + userId.ToString());
            var credentialId = CredentialId.Create(hash);
            return new(credentialId);
        }

    }
}
