

namespace MedicalAppointment.Modules.Auth.Domain.Credentials
{
    public interface ICredentialRepository
    {
        Task<CredentialId> Add(Credential credential);
    }
}
