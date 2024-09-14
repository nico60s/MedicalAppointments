

using MediatR;

namespace MedicalAppointment.Shared.Domain
{
    public abstract class DomainEvent(Guid id) : IDomainEvent, INotification
    {
        private readonly Guid _id = id;
        public DateTime OccurredOn { get;  }
        public Guid Id => _id;

    }
}
