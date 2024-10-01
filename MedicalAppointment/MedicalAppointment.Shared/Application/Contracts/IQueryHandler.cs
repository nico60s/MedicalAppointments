

using MediatR;

namespace MedicalAppointment.Shared.Application.Contracts
{
    public interface IQueryHandler<TQuery, TResult> : IRequestHandler<TQuery,TResult>
        where TQuery : IQuery<TResult>
    {
    }
}
