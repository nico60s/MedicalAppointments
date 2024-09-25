namespace MedicalAppointment.Modules.Auth.Application.Contracts
{
    public interface IJwtTokenGenerator
    {
        Task<string> GenerateJwtToken(Guid userId, string username, string email, string role);
    }
}
