using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todo_App.Application.Base.Command;

namespace Todo_App.Application.Modules.Auth.Commands
{
    public class LoginCommand : ICommand<LoginCommandResult>
    {
        public string Login { get; }
        public string Password { get; }

        public LoginCommand(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}
