

using MedicalAppointment.Shared.Application.Contracts;
using MedicalAppointment.Shared.Infrastructure.EventBus;
using MedicalAppointment.Turnos.Domain;
using MedicalAppointment.Turnos.Domain.Events;
using MedicalAppointment.Turnos.Domain.Repositories;
using MedicalAppointment.Turnos.Integration;

namespace MedicalAppointment.Turnos.Application.CreateTurno
{
    internal class CreateTurnoCommandHandler : ICommandHandler<CreateTurnoCommand>
    {

        private readonly ITurnoRepository _turnoRepository;
        private readonly IEventBus _eventBus;
        public CreateTurnoCommandHandler(ITurnoRepository turnoRepository,
            IEventBus eventBus)
        {
            _turnoRepository = turnoRepository;
            _eventBus = eventBus;
        }
        public async Task Handle(CreateTurnoCommand request, CancellationToken cancellationToken)
        {
            var turno = new Turno(
               id: TurnoId.Create(),
               pacienteId: PacienteId.FromGuid(request.PacienteId),
               profesionalId: ProfesionalId.FromGuid(request.ProfesionalId),
               fechaTurno: request.FechaTurno);

            var turnoCreadoIntegrationEvent =
                new TurnoCreadoIntegrationEvent(new TurnoCreadoDomainEvent(turno.Id));

            await _eventBus.PublishAsync<TurnoCreadoIntegrationEvent>(turnoCreadoIntegrationEvent);
        }
    }
}
