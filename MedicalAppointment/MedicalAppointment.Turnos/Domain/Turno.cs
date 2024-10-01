
using MedicalAppointment.Shared.Domain;

namespace MedicalAppointment.Turnos.Domain
{
    public class Turno : Entity<TurnoId>
    {
        public PacienteId PacienteId { get; private set; }
        public ProfesionalId ProfesionalId { get; private set; }
        public DateTime FechaTurno { get; private set; }

        public Turno(TurnoId id, PacienteId pacienteId, 
            ProfesionalId profesionalId, DateTime fechaTurno ) : base(id)
        {
            PacienteId = pacienteId;
            ProfesionalId = profesionalId;
            FechaTurno = fechaTurno;
        }
    }
}
