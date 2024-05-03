using Business.Abstract;
using Core.Entities.Concrete;
using Microsoft.AspNetCore.Http;
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
				return Ok(result.Data);
			}
			return BadRequest(result.Message);
		}

		[HttpGet("getuserdetail")]
		public IActionResult GetUserDetail(int userId)
		{
			var result = _userService.GetUserDetail(userId);
			if (result.Success)
			{
				return Ok(result.Data);
			}
			return BadRequest(result.Message);
		}

		[HttpGet("getalluserdetails")]
		public IActionResult GetAllUserDetails()
		{
			var result = _userService.GetAllUserDetails();
			if (result.Success)
			{
				return Ok(result.Data);
			}
			return BadRequest(result.Message);
		}

		[HttpGet("getbyid")]
		public IActionResult GetById(int Id)
		{
			var result = _userService.GetById(Id);
			if (result.Success)
			{
				return Ok(result.Data);
			}
			return BadRequest(result.Message);
		}

		[HttpGet("getbymail")]
		public IActionResult GetByMail(string email)
		{
			var result = _userService.GetByMail(email);
			if (result.Success)
			{
				return Ok(result.Data);
			}
			return BadRequest(result.Message);
		}

		[HttpPost("add")]
		public IActionResult Add(User user)
		{
			var result = _userService.Add(user);
			if (result.Success)
			{
				return Ok(result.Message);
			}
			return BadRequest(result.Message);
		}

		[HttpPost("update")]
		public IActionResult Update(User user)
		{
			var result = _userService.Update(user);
			if (result.Success)
			{
				return Ok(result.Message);
			}
			return BadRequest(result.Message);
		}

		[HttpPost("remove")]
		public IActionResult Remove(User user)
		{
			var result = _userService.Remove(user);
			if (result.Success)
			{
				return Ok(result.Message);
			}
			return BadRequest(result.Message);
		}
	}
}
