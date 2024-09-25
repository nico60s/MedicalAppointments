using MedicalAppointment.Shared.Domain;

namespace MedicalAppointment.Auth.Domain.Users
{
    public class UserId : ValueObject
    {
        public Guid Id { get; } = Guid.NewGuid();
        private UserId(Guid id)
        {
            Id = id;
        }
        public static UserId Create() => new UserId(Guid.NewGuid());
        public static UserId FromGuid(Guid id) => new(id);
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Id;
        }
    }
}
