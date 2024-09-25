

using MediatR;
using MedicalAppointment.Modules.Auth.Domain;
using MedicalAppointment.Modules.Auth.Domain.Users;

namespace MedicalAppointment.Modules.Auth.Application.Features.Users.Register
{
    internal class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand>
    {
        private readonly IUserRepository _userRepository;
        public RegisterUserCommandHandler(IUserService userService, IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            var userIdExist = _userRepository.GetByEmail(request.Email); 
            throw new NotImplementedException();
        }
    }
}
