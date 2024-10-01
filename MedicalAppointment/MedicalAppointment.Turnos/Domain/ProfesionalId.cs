using MedicalAppointment.Shared.Domain;

namespace MedicalAppointment.Turnos.Domain
{
    public class ProfesionalId : ValueId
    {
        private ProfesionalId(Guid value) : base(value)
        {
        }
        public static ProfesionalId FromGuid(Guid value) => new(value);
    }
}
