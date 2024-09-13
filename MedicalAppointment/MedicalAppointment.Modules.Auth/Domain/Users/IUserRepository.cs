

using MedicalAppointment.Modules.Auth.Domain.Users.Rules;

namespace MedicalAppointment.Modules.Auth.Domain.Users
{
    public interface IUserRepository
    {
        Task<User?> Exist(UserId userId);
        User GetByEmail(string email);
    }
}
