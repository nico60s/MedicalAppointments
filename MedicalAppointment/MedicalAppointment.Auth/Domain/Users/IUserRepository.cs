

using MedicalAppointment.Auth.Domain.Users.Rules;

namespace MedicalAppointment.Auth.Domain.Users;

public interface IUserRepository
{
    Task<User?> Exist(UserId userId);
    Task<User> GetByEmail(string email);
}
