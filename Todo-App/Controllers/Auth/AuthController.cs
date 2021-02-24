using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Todo_App.Application.Modules.Auth.Commands;

namespace Todo_App.Controllers.Auth
{
    [Route("api/auth")]
    public sealed class AuthController : ApiController
    {
        [HttpGet]
        public string Hello()
        {
            return "Hello World";
        }

        [HttpGet]
        public IActionResult Check()
        {
            return Ok();
        }

        [HttpPost("login")]
        public async Task<IActionResult> LoginAsync([FromServices] IMediator medator)
        {
            var command = new LoginCommand("User", "User");
            LoginCommandResult commandResult = await medator.Send(command);

            var result = commandResult.Result.Match<ActionResult>(
                success =>
                {
                    return Json(new { token = "success" });
                },
                notFound =>
                {
                    return NotFound();
                });

            return result;
        }
    }
}
