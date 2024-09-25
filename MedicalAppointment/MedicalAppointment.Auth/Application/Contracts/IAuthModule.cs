
using MedicalAppointment.Shared.Application.Contracts;

namespace MedicalAppointment.Modules.Auth.Application.Contracts
{
    public interface IAuthModule
    {
        Task<TResult> ExecuteCommandAsync<TResult>(ICommand<TResult> command);
        Task<TResult> ExecuteQueryAsync<TResult>(IQuery<TResult> query);
    }
}
