

using MedicalAppointment.Shared.Domain;

namespace MedicalAppointment.HistoriasClinicas
{
    public class HistoriaClinicaId : ValueObject
    {
        public Guid Value { get; }
        private HistoriaClinicaId(Guid id) => Value = id;
        public static HistoriaClinicaId Create()=> new(Guid.NewGuid());
        public static HistoriaClinicaId FromGuid(Guid id) => new(id);   
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
