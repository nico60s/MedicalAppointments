
using MedicalAppointment.Shared.Application.Contracts;

namespace MedicalAppointment.Modules.Auth.Application.Features.Users.Register
{
    public class RegisterUserCommand : ICommand
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
