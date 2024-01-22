using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Search.Api.Controllers
{
    public class Auth : Controller
    {
        [HttpGet]
        [Authorize]
        public IActionResult Get()
        {
            var principal = HttpContext.Items["Principal"] as ClaimsPrincipal;
            var userName = principal?.Identity?.Name;

            return Ok($"Hello, {userName}!");
        }
    }
}
