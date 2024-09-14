

using MediatR;
using MedicalAppointment.Modules.Auth.Domain.Credentials;
using MedicalAppointment.Modules.Auth.Domain.Users.Events;

namespace MedicalAppointment.Modules.Auth.Application.Features.Users.Register
{
    internal class UserRegisteredEventHandler : INotificationHandler<UserCreatedDomainEvent>
    {
        private readonly ICredentialRepository _credentialRepository;
        public UserRegisteredEventHandler(ICredentialRepository credentialRepository)
            => _credentialRepository = credentialRepository;

        public Task Handle(UserCreatedDomainEvent notification, CancellationToken cancellationToken)
        {
            var credential = Credential.Create(notification.UserId);
            var credentialId = _credentialRepository.Add(credential);

            throw new NotImplementedException();
        }
    }
}
