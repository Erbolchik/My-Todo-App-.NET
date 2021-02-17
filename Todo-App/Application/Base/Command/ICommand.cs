using MediatR;

namespace Todo_App.Application.Base.Command
{
    public interface ICommand<out TCommandResult>
        : IRequest<TCommandResult> where TCommandResult : ICommandResultBase
    {
    }
}
