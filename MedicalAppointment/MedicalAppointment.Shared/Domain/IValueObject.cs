
namespace MedicalAppointment.Shared.Domain
{
    internal interface IValueObject<T>
    {
        T Value { get; }
    }
}
