

using MediatR;

namespace MedicalAppointment.Shared.Application.Contracts
{
    public interface ICommandHandler<T> : IRequestHandler<T>
        where T: ICommand
    {
        void Handle(T command);
    }
}
