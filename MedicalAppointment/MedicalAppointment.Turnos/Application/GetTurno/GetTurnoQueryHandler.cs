
using MedicalAppointment.Shared.Application.Contracts;

namespace MedicalAppointment.Turnos.Application.GetTurno
{
    internal class GetTurnoQueryHandler : IQueryHandler<GetTurnoQuery, GetTurnoResponse>
    {
        public Task<GetTurnoResponse> Handle(GetTurnoQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
