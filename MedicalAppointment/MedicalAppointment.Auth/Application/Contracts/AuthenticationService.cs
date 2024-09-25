using MedicalAppointment.Modules.Auth.Application.Configuration;
using MedicalAppointment.Modules.Auth.Domain.Users;

namespace MedicalAppointment.Modules.Auth.Application.Contracts
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IUserRepository _userRepository;

        public AuthenticationService(IUserRepository userRepository) => _userRepository = userRepository;
    
        public Task<bool> AuthenticateAsync()
        {
            throw new NotImplementedException();
        }
        public Task<AuthenticationResult> Register(string username, string password) 
        {
            //Check if user alredy exist
            //Create user (generate an unique Id)
            //Create JWT

            return Task.FromResult(new AuthenticationResult());
        }
    }
}
