

using MediatR;

namespace MedicalAppointment.Modules.Auth.Application.Features.Users.Create
{
    public class CreateUserCommand : IRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
