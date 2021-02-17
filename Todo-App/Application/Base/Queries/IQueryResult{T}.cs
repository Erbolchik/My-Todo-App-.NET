using OneOf;

namespace Todo_App.Application.Base.Queries
{
    public interface IQueryResult<T> : IQueryResultBase where T : IOneOf
    {
        T Result { get; }
    }
}
