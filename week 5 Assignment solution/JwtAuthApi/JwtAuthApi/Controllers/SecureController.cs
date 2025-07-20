using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize] // 🔒 All endpoints in this controller require a valid JWT
    public class SecureController : ControllerBase
    {
        [HttpGet("secret")]
        public IActionResult Secret()
        {
            return Ok("✅ This is a protected endpoint. You are authorized.");
        }
    }
}
