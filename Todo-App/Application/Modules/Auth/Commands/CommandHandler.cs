using OneOf.Types;
using OneOf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Todo_App.Application.Modules.Auth.Commands
{
    internal sealed class CommandHandler : IRequestHandler<LoginCommand, LoginCommandResult>
    {
        public CommandHandler()
        {

        }

        public async Task<LoginCommandResult> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            OneOf<Success<string>, NotFound> result;

            result = new Success<string>();

            return new LoginCommandResult(result);
        }
    }
}
