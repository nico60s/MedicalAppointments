
using MedicalAppointment.Modules.Auth.Domain.Users.Events;
using MedicalAppointment.Shared.Domain;

namespace MedicalAppointment.Modules.Auth.Domain.Users.Rules
{
    public class User : Entity<UserId>
    {
        private readonly List<IDomainEvent> _events;
        public string Email { get; set; } 
        public string Password { get; set; }
        
        public override IReadOnlyCollection<IDomainEvent> Events => _events;

        private User(UserId id, string email, string password) : base(id) 
        {
            CheckRule(new MustNotBeNullOrEmptyBusinessRule(email));
            CheckRule(new MustHaveEmailFormatBusinessRule(email));
            CheckRule(new MustNotBeNullOrEmptyBusinessRule(password));

            Email = email;
            Password = password;
            _events = [new UserCreatedDomainEvent(id)];

        }
        public static User CreateNew(string email, string password) {

            return new(UserId.Create(), email, password);
        }

    }
}
