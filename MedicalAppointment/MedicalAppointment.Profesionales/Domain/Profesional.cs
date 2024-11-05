

using MedicalAppointment.Shared.Domain;

namespace MedicalAppointment.Profesionales.Domain
{
    public class Profesional : Entity<ProfesionalId>
    {
        public Profesional(ProfesionalId id) : base(id)
        {
        }
    }
}
