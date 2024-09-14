using MediatR;

namespace MedicalAppointment.Shared.Application.Contracts
{
    public interface IQuery<out TResponse> : IRequest<TResponse> { }

}
