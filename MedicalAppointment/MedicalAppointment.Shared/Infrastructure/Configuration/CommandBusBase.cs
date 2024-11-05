

using MediatR;
using MedicalAppointment.Shared.Application.Contracts;

namespace MedicalAppointment.Shared.Infrastructure.Configuration
{
    public class CommandBusBase<T> : ICommandBus<T>
    {
        private IMediator _mediator;
        public CommandBusBase(IMediator mediator) => _mediator = mediator;

        public void Send(T command)
        {
            SendAsync(command);
        }

        protected async void SendAsync(T command)
        {
            await _mediator.Send(command);
        }
    }
}
