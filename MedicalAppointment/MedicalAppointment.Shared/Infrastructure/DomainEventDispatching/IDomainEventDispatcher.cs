

using MedicalAppointment.Shared.Domain;

namespace MedicalAppointment.Shared.Infrastructure.DomainEventDispatching
{
    public interface IDomainEventDispatcher
    {
        Task DispatchAsync(IEnumerable<DomainEvent> events);
    }
}
