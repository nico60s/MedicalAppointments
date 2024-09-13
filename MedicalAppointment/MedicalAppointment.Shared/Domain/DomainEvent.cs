

namespace MedicalAppointment.Shared.Domain
{
    public abstract class DomainEvent(Guid id) : IDomainEvent
    {
        private readonly Guid _id = id;
        public DateTime OccurredOn { get; private set; }
        public Guid Id => _id;
    }
}
