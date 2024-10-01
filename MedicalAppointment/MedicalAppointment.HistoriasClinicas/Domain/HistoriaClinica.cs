using MedicalAppointment.Shared.Domain;

namespace MedicalAppointment.HistoriasClinicas.Domain
{
    public class HistoriaClinica: Entity<HistoriaClinicaId>
    {
        private HistoriaClinica(HistoriaClinicaId id) : base(id) { }
        public static HistoriaClinica Create() => new(HistoriaClinicaId.Create());
        public static HistoriaClinica Create(HistoriaClinicaId id) => new(id);
    }
}
