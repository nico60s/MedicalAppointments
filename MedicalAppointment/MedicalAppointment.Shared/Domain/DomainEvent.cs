

using MediatR;

namespace MedicalAppointment.Shared.Domain
{
    public abstract class DomainEvent : IDomainEvent, INotification
    {
        private readonly Guid _id;
        public DateTime OccurredOn { get;  }
        public Guid Id => _id;
        protected DomainEvent(Guid id)
        {
            _id = id;
            OccurredOn = DateTime.Now;  
        }

    }
}
