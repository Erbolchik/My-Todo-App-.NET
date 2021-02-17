using MediatR;

namespace Todo_App.Application.Base.Queries
{
    public interface IQuery<out TQueryResult>
     : IRequest<TQueryResult> where TQueryResult : IQueryResultBase
    {

    }
}
