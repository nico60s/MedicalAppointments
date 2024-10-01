
using MedicalAppointment.Shared.Application.Contracts;

namespace MedicalAppointment.Turnos.Application.GetTurno
{
    public class GetTurnoQuery : IQuery<GetTurnoResponse>
    {
        public Guid TurnoId { get; set; }
    }
}
