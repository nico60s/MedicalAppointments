

using MedicalAppointment.Shared.Application.Contracts;

namespace MedicalAppointment.Turnos.Application.CreateTurno
{
    public class CreateTurnoCommand : ICommand
    {
        public Guid PacienteId { get; set; }
        public Guid ProfesionalId { get; set; }
        public DateTime FechaTurno {  get; set; }
    }
}
