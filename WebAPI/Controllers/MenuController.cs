using Business.Abstract;
using Core.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MenuController : ControllerBase
	{
		IMenuService _menuService;
		public MenuController(IMenuService menuService)
		{
			_menuService = menuService;
		}

		[HttpGet("getall")]
		public IActionResult GetAll()
		{
			var result = _menuService.GetAll();
			if (result.Success)
			{
				return Ok(result.Data);
			}
			return BadRequest(result.Message);
		}

		[HttpGet("getmenudetailsbyresturant")]
		public IActionResult GetMenuDetailsByResturant(int restaurantId)
		{
			var result = _menuService.GetMenuDetailsByRestaurant(restaurantId);
			if (result.Success)
			{
				return Ok(result.Data);
			}
			return BadRequest(result.Message);
		}

		[HttpGet("getmenudetail")]
		public IActionResult GetMenuDetail(int menuId)
		{
			var result = _menuService.GetMenuDetail(menuId);
			if (result.Success)
			{
				return Ok(result.Data);
			}
			return BadRequest(result.Message);
		}

		[HttpGet("getallmenudetails")]
		public IActionResult GetAllMenuDetails()
		{
			var result = _menuService.GetAllMenuDetails();
			if (result.Success)
			{
				return Ok(result.Data);
			}
			return BadRequest(result.Message);
		}

		[HttpGet("getbyid")]
		public IActionResult GetById(int Id)
		{
			var result = _menuService.GetById(Id);
			if (result.Success)
			{
				return Ok(result.Data);
			}
			return BadRequest(result.Message);
		}

		[HttpPost("add")]
		public IActionResult Add(Menu menu)
		{
			var result = _menuService.Add(menu);
			if (result.Success)
			{
				return Ok(result.Message);
			}
			return BadRequest(result.Message);
		}

		[HttpPost("update")]
		public IActionResult Update(Menu menu)
		{
			var result = _menuService.Update(menu);
			if (result.Success)
			{
				return Ok(result.Message);
			}
			return BadRequest(result.Message);
		}

		[HttpPost("remove")]
		public IActionResult Remove(Menu menu)
		{
			var result = _menuService.Remove(menu);
			if (result.Success)
			{
				return Ok(result.Message);
			}
			return BadRequest(result.Message);
		}
	}
}
