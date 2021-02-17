using OneOf;

namespace Todo_App.Application.Base.Command
{
    public interface ICommandResult<T> : ICommandResultBase where T : IOneOf
    {
        T Result { get; }
    }
}
