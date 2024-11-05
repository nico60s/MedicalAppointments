

namespace MedicalAppointment.Shared.Presentation
{
    public interface IToStringPresenter<IApplicationResponse> : IPresenter<IApplicationResponse>
    {
        string ToString(IApplicationResponse obj);
    }
}
