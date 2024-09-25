namespace MedicalAppointment.Modules.Auth.Application.Contracts
{
    public interface IAuthenticationService
    {
        Task<bool> AuthenticateAsync();

    }
}
