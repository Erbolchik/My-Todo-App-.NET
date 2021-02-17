using OneOf;
using OneOf.Types;

using Todo_App.Application.Base.Command;

namespace Todo_App.Application.Modules.Auth.Commands
{
    public sealed class LoginCommandResult : ICommandResult<OneOf<Success<string>, NotFound>>
    {
        public OneOf<Success<string>, NotFound> Result { get; }
        public LoginCommandResult(OneOf<Success<string>, NotFound> result)
        {
            Result = result;
        }
    }
}
