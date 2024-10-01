

using MedicalAppointment.Turnos.Domain.Repositories;

namespace MedicalAppointment.Turnos.Application.Services
{
    public class TurnoService
    {
        private readonly ITurnoRepository _turnoRepository;
        public TurnoService(ITurnoRepository turnoRepository) 
            => _turnoRepository = turnoRepository;

    }
}
