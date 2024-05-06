using Business.Abstract;
using Core.Entities.Concrete;
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
				return Ok(result);
			}
			return BadRequest(result);
		}

		[HttpGet("getmenudetailsbyresturant")]
		public IActionResult GetMenuDetailsByResturant(int restaurantId)
		{
			var result = _menuService.GetMenuDetailsByRestaurant(restaurantId);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

		[HttpGet("getmenudetail")]
		public IActionResult GetMenuDetail(int menuId)
		{
			var result = _menuService.GetMenuDetail(menuId);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

		[HttpGet("getallmenudetails")]
		public IActionResult GetAllMenuDetails()
		{
			var result = _menuService.GetAllMenuDetails();
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

		[HttpGet("getbyid")]
		public IActionResult GetById(int Id)
		{
			var result = _menuService.GetById(Id);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

		[HttpPost("add")]
		public IActionResult Add(Menu menu)
		{
			var result = _menuService.Add(menu);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

		[HttpPost("update")]
		public IActionResult Update(Menu menu)
		{
			var result = _menuService.Update(menu);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

		[HttpPost("remove")]
		public IActionResult Remove(Menu menu)
		{
			var result = _menuService.Remove(menu);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
	}
}
