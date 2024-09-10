

namespace MedicalAppointments.Shared.Domain
{
    public interface IBusinessRule
    {
        bool IsBroken { get; }
        string Message { get; }
    }
}
