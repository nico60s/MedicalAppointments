

using MediatR;
using MedicalAppointment.Modules.Auth.Domain.Credentials;

namespace MedicalAppointment.Modules.Auth.Application.Features.Credentials.Create
{
    public class CreateCredentialCommandHandler : IRequestHandler<CreateCredentialCommand>
    {
        private readonly ICredentialRepository _credentialRepository;
        public Task Handle(CreateCredentialCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
