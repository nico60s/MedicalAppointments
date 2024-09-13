

using MedicalAppointment.Modules.Auth.Domain.Users;

namespace MedicalAppointment.Modules.Auth.Domain
{
    public interface IUserService
    {
        Task<User> Register(string email, string password); 

    }
}
