

using MedicalAppointment.Shared.Domain;

namespace MedicalAppointment.Turnos.Domain
{
    public class PacienteId : ValueId
    {
        private PacienteId(Guid value) : base(value)
        {
        }
        public static PacienteId CreateUnique() => new(Guid.NewGuid());
        public static PacienteId FromGuid(Guid value) => new(value);
    }
}

