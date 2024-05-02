using Business.Abstract;
using Core.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RestaurantsController : ControllerBase
	{
		private IRestaurantService _restaurantService;
		public RestaurantsController(IRestaurantService restaurantService)
		{
			_restaurantService = restaurantService;
		}

		[HttpGet("getall")]
		public IActionResult GetAll()
		{
			var result = _restaurantService.GetAll();
			if (result.Success)
			{
				return Ok(result.Data);
			}
			return BadRequest(result.Message);
		}

		[HttpGet("getallrestaurantdetails")]
		public IActionResult GetAllRestaurantDetails()
		{
			var result = _restaurantService.GetAllRestaurantDetails();
			if (result.Success)
			{
				return Ok(result.Data);
			}
			return BadRequest(result.Message);
		}

		[HttpGet("getrestaurantdetail")]
		public IActionResult GetRestaurantDetail(int restaurantId)
		{
			var result = _restaurantService.GetRestaurantDetail(restaurantId);
			if (result.Success)
			{
				return Ok(result.Data);
			}
			return BadRequest(result.Message);
		}


		[HttpGet("getbyid")]
		public IActionResult GetById(int Id)
		{
			var result = _restaurantService.GetById(Id);
			if (result.Success)
			{
				return Ok(result.Data);
			}
			return BadRequest(result.Message);
		}


		[HttpGet("getbymail")]
		public IActionResult GetByMail(string mail)
		{
			var result = _restaurantService.GetByMail(mail);
			if (result.Success)
			{
				return Ok(result.Data);
			}
			return BadRequest(result.Message);
		}

		[HttpPost("add")]
		public IActionResult Add(Restaurant restaurant)
		{
			var result = _restaurantService.Add(restaurant);
			if (result.Success)
			{
				return Ok(result.Message);
			}
			return BadRequest(result.Message);
		}

		[HttpPost("update")]
		public IActionResult Update(Restaurant restaurant)
		{
			var result = _restaurantService.Update(restaurant);
			if (result.Success)
			{
				return Ok(result.Message);
			}
			return BadRequest(result.Message);
		}

		[HttpPost("remove")]
		public IActionResult Remove(Restaurant restaurant)
		{
			var result = _restaurantService.Remove(restaurant);
			if (result.Success)
			{
				return Ok(result.Message);
			}
			return BadRequest(result.Message);
		}
	}
}
