

using MediatR;
using MedicalAppointment.Modules.Auth.Domain.Users;

namespace MedicalAppointment.Modules.Auth.Application.Features.Credentials.Create
{
    public class CreateCredentialCommand : IRequest
    {
        public UserId User {  get; private set; }

    }
}
