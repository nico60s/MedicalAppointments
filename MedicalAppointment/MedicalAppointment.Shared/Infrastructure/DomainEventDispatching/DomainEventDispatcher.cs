

using MediatR;
using MedicalAppointment.Shared.Domain;

namespace MedicalAppointment.Shared.Infrastructure.DomainEventDispatching
{
    public class DomainEventDispatcher : IDomainEventDispatcher
    {
        private readonly IMediator _mediator;
        public DomainEventDispatcher(IMediator mediator) => _mediator = mediator;
        
        public async Task DispatchAsync(IEnumerable<DomainEvent> events)
        {
            foreach (var @event in events) 
            {
                await _mediator.Publish(@event);
            }
        }
    }
}
