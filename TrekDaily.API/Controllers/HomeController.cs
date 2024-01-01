using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TrekDaily.API1.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class HomeController : ControllerBase
	{
		[HttpGet]
		public IActionResult Get()
		{
			return Ok("Hello from the API!");
		}
	}
}
