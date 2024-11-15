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

		[HttpGet("Ping")]
		public IActionResult Ping()
		{
			//return current date and time UTC
			return Ok(DateTime.UtcNow);
		}

		//Add HttpGet methode to return error on purpose
		[HttpGet("Error")]
		public IActionResult Error()
		{
			return BadRequest("This is a bad request");
		}

		//Add HttpGet methode to return Warning on purpose
		[HttpGet("Warning")]
		public IActionResult Warning()
		{
			return BadRequest("This is a warning message");
		}
	}
}
