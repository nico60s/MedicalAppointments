

using MediatR;

namespace MedicalAppointment.Shared.Application.Contracts
{
    public interface ICommand : IRequest
    {
    }
    public interface ICommand<out T> : IRequest<T> 
    { 

    }
    
}
