

using MediatR;
using MedicalAppointment.Shared.Domain;

namespace MedicalAppointment.Shared.Infrastructure.DomainEventDispatching
{
    public interface IDomainEventDispatcher : INotificationHandler<IDomainEvent>
    {
    }
}
