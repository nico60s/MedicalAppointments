

using MedicalAppointment.Modules.Auth.Domain.Users;
using MedicalAppointment.Modules.Auth.Domain.Users.Rules;

namespace MedicalAppointment.Auth.Domain
{
    public interface IUserService
    {
        UserId CreateUserId(Guid id);
        User Register(string email, string password); 

    }
}
