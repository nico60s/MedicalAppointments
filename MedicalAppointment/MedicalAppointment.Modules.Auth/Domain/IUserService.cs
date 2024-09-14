

using MedicalAppointment.Modules.Auth.Domain.Users;
using MedicalAppointment.Modules.Auth.Domain.Users.Rules;

namespace MedicalAppointment.Modules.Auth.Domain
{
    public interface IUserService
    {
        UserId CreateUserId(Guid id);
        User Register(string email, string password); 

    }
}
