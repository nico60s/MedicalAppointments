using MedicalAppointment.Shared.Domain;

namespace MedicalAppointment.HistoriasClinicas.Domain
{
    public class HistoriaClinica: Entity<HistoriaClinicaId>
    {
        private readonly Guid _pacienteId;
        private readonly Guid _doctorId;
        private readonly HistoriaClinicaId _id;
        public Guid PacienteId
        {
            get
            {
                return _pacienteId;
            }
        }
        public Guid DoctorId
        {
            get { return _doctorId; }
        }
        private HistoriaClinica(HistoriaClinicaId id, Guid pacienteId, Guid doctorId) : base(id) 
        {
            _id = id;
            _pacienteId = pacienteId;
            _doctorId = doctorId;
        }
        public static HistoriaClinica Create(HistoriaClinicaId id, Guid pacienteId, Guid doctorId) 
            => new(id, pacienteId, doctorId);
    }
}
