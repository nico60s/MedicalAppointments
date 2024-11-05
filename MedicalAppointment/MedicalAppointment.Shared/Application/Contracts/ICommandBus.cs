

namespace MedicalAppointment.Shared.Application.Contracts
{
    public interface ICommandBus<T> 
    {
        void Send(T command);
    }
}
