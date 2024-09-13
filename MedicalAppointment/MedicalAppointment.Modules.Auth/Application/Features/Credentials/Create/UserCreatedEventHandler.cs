

using MediatR;
using MedicalAppointment.Modules.Auth.Domain.Credentials;
using MedicalAppointment.Modules.Auth.Domain.Users.Events;

namespace MedicalAppointment.Modules.Auth.Application.Features.Credentials.Create
{
    internal class UserCreatedEventHandler : INotificationHandler<UserCreatedDomainEvent>
    {
        private readonly ICredentialRepository _credentialRepository;
        public UserCreatedEventHandler(ICredentialRepository credentialRepository) => _credentialRepository = credentialRepository;
       
        public Task Handle(UserCreatedDomainEvent notification, CancellationToken cancellationToken)
        {
            var credential = Credential.Create(notification.UserId);
            throw new NotImplementedException();
        }
    }
}
