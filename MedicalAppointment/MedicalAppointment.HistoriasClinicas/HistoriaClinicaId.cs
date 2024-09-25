

using MedicalAppointment.Shared.Domain;

namespace MedicalAppointment.HistoriasClinicas
{
    public class HistoriaClinicaId : ValueObject
    {
        public Guid Id { get; }
        private HistoriaClinicaId(Guid id) => Id = id;
        public static HistoriaClinicaId Create()=> new(Guid.NewGuid());
        public static HistoriaClinicaId FromGuid(Guid id) => new(id);   
        protected override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }
    }
}
