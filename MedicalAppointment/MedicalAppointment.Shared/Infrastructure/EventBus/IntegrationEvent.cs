

using MediatR;

namespace MedicalAppointment.Shared.Infrastructure.EventBus
{
    public abstract class IntegrationEvent : IIntegrationEvent
    {
        public Guid Id { get; }

        public DateTime OccurredOn { get; }

        protected IntegrationEvent(Guid id, DateTime occurredOn)
        {
            this.Id = id;
            this.OccurredOn = occurredOn;
        }
    }
}
