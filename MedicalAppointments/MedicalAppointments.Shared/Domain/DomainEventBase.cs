

namespace MedicalAppointments.Shared.Domain
{
    public abstract class DomainEventBase : IDomainEvent
    {
        private readonly Guid _id;
        private readonly DateTime _ocurredOn;
        protected DomainEventBase(Guid id)
        {
            _id = id;
            _ocurredOn = DateTime.UtcNow;
        }
        public Guid Id => _id;

        public DateTime OccurredOn => _ocurredOn;
    }
}
