

using MedicalAppointment.Shared.Infrastructure.EventBus;
using MedicalAppointment.Turnos.Domain;
using MedicalAppointment.Turnos.Domain.Events;

namespace MedicalAppointment.Turnos.Integration
{
    public class TurnoCreadoIntegrationEvent : IIntegrationEvent
    {
        private readonly Guid _id = Guid.NewGuid();
        public Guid Id => _id;
        public Guid PacienteId { get; private set; }
        public Guid ProfesionalId   { get; private set; }
        private DateTime _occurredOn => DateTime.Now;
        public TurnoCreadoIntegrationEvent(PacienteId pacienteId,
            ProfesionalId profesionalId)
        {
            PacienteId = pacienteId.Value;
            ProfesionalId = profesionalId.Value;
        }
        public DateTime OccurredOn => _occurredOn;

        public TurnoCreadoIntegrationEvent(TurnoCreadoDomainEvent @event)
        {
            _id = @event.Id;
        }
    }
}
