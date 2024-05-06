using Business.Abstract;
using Core.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserController : ControllerBase
	{
		IUserService _userService;
		public UserController(IUserService userService)
		{
			_userService = userService;
		}

		[HttpGet("getall")]
		public IActionResult GetAll()
		{
			var result = _userService.GetAll();
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

		[HttpGet("getuserdetail")]
		public IActionResult GetUserDetail(int userId)
		{
			var result = _userService.GetUserDetail(userId);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

		[HttpGet("getalluserdetails")]
		public IActionResult GetAllUserDetails()
		{
			var result = _userService.GetAllUserDetails();
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

		[HttpGet("getbyid")]
		public IActionResult GetById(int Id)
		{
			var result = _userService.GetById(Id);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

		[HttpGet("getbymail")]
		public IActionResult GetByMail(string email)
		{
			var result = _userService.GetByMail(email);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

		[HttpPost("add")]
		public IActionResult Add(User user)
		{
			var result = _userService.Add(user);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

		[HttpPost("update")]
		public IActionResult Update(User user)
		{
			var result = _userService.Update(user);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

		[HttpPost("remove")]
		public IActionResult Remove(User user)
		{
			var result = _userService.Remove(user);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
	}
}
