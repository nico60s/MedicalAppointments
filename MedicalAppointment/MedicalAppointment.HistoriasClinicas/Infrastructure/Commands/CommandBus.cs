

using MediatR;
using MedicalAppointment.Shared.Infrastructure.Configuration;

namespace MedicalAppointment.HistoriasClinicas.Infrastructure.Commands
{
    public class CommandBus<IApplicationResponse> : CommandBusBase<IApplicationResponse>
    {
        public CommandBus(IMediator mediator) : base(mediator)
        {
        }

        public void Send(IApplicationResponse command)
        {
            base.Send(command);
        }
    }
}
