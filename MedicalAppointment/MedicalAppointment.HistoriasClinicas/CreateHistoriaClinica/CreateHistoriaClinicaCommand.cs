using MedicalAppointment.Shared.Application.Contracts;

namespace MedicalAppointment.HistoriasClinicas.CreateHistoriaClinica
{
    public class CreateHistoriaClinicaCommand : ICommand
    {
        public Guid PacienteId { get; set; }
        public Guid DoctorId { get; set; }
    }
}
