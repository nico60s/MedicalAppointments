

namespace MedicalAppointment.Turnos.Application.GetTurno
{
    public class GetTurnoResponse
    {
        public Guid PacienteId { get; set; }
        public Guid ProfesionalId { get; set; }
        public DateTime FechaTurno {  get; set; }
    }
}
