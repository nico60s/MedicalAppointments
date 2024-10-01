
using MedicalAppointment.Shared.Domain;

namespace MedicalAppointment.Turnos.Domain
{
    public class TurnoId : ValueId
    {
        private TurnoId(Guid value) : base(value)
        {
        }
        public static TurnoId Create() => new(Guid.NewGuid());
        public static TurnoId FromGuid(Guid value) => new(value)
    }
}
