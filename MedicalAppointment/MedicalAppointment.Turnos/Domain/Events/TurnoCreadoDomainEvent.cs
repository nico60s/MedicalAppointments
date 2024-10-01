

using MedicalAppointment.Shared.Domain;

namespace MedicalAppointment.Turnos.Domain.Events
{
    public class TurnoCreadoDomainEvent : DomainEvent
    {
        public TurnoId TurnoId { get; private set; }
        public TurnoCreadoDomainEvent(TurnoId turnoId)
        {
            TurnoId = turnoId;
        }
    }
}
