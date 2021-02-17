using System.Net;

using Microsoft.AspNetCore.Mvc;

namespace Todo_App.Controllers
{
    [ApiController]
    public partial class ApiController : Controller
    {
        public override JsonResult Json(object data)
        {
            return base.Json(new { data });
        }

        [NonAction]
        public JsonResult Error(HttpStatusCode statusCode, object data)
        {
            Response.StatusCode = (int)statusCode;
            return base.Json(new { data });
        }
    }
}