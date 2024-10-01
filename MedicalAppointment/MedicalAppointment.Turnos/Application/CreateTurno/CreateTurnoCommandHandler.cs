

using MedicalAppointment.Shared.Application.Contracts;
using MedicalAppointment.Shared.Infrastructure.EventBus;
using MedicalAppointment.Turnos.Domain;
using MedicalAppointment.Turnos.Domain.Events;
using MedicalAppointment.Turnos.Domain.Repositories;
using MedicalAppointment.Turnos.Integration;

namespace MedicalAppointment.Turnos.Application.CreateTurno
{
    public class CreateTurnoCommandHandler : ICommandHandler<CreateTurnoCommand>
    {

        private readonly ITurnoRepository _turnoRepository;
        private readonly IEventBus _eventBus;
        public CreateTurnoCommandHandler(ITurnoRepository turnoRepository,
            IEventBus eventBus)
        {
            _turnoRepository = turnoRepository;
            _eventBus = eventBus;
        }
        public void Handle(CreateTurnoCommand command)
        {
            var turno = new Turno(
                id: TurnoId.Create(),
                pacienteId: PacienteId.FromGuid(command.PacienteId),
                profesionalId: ProfesionalId.FromGuid(command.ProfesionalId),
                fechaTurno: command.FechaTurno);

            var turnoCreadoEvent = new TurnoCreadoDomainEvent(turno.Id);
            var turnoCreadoIntegrationEvent = new TurnoCreadoIntegrationEvent(turnoCreadoEvent);

            _eventBus.PublishAsync<TurnoCreadoIntegrationEvent>(turnoCreadoIntegrationEvent);
        }

        public Task Handle(CreateTurnoCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
