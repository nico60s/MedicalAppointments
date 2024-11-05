
using MedicalAppointment.Shared.Domain;

namespace MedicalAppointment.Profesionales.Domain
{
    public class ProfesionalId : ValueObject
    {
        public Guid Value { get; private set; }
        private ProfesionalId(Guid value) : base(value) { }
        internal static ProfesionalId Create() => new(Guid.NewGuid());
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
