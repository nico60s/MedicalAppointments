namespace MedicalAppointment.Modules.Auth.Domain
{
    public interface IAuthenticationService
    {
        Task<bool> AuthenticateAsync();

    }
}
