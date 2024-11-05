

namespace MedicalAppointment.Shared.Presentation
{
    public interface IPresenter<TResponse>
    {
        TResponse Present();
    }
}
