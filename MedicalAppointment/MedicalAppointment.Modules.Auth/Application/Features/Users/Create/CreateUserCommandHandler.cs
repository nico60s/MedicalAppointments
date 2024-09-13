

using MediatR;
using MedicalAppointment.Modules.Auth.Domain.Users;

namespace MedicalAppointment.Modules.Auth.Application.Features.Users.Create
{
    internal class CreateUserCommandHandler : IRequestHandler<CreateUserCommand>
    {
        private readonly IUserRepository _userRepository;
        public CreateUserCommandHandler(IUserRepository userRepository) => _userRepository = userRepository;
        public Task Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
