using Business.Abstract.ImageServices;
using Core.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.ImageControllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RestaurantImageController : ControllerBase
	{
		IRestaurantImageService _restaurantImageService;

		public RestaurantImageController(IRestaurantImageService restaurantImageService)
		{
			_restaurantImageService = restaurantImageService;
		}

		[HttpGet("getall")]
		public IActionResult GetAll()
		{
			var result = _restaurantImageService.GetAll();
			if (!result.Success)
			{
				return BadRequest(result);
			}
			return Ok(result);
		}

		[HttpGet("getbyimageid")]
		public IActionResult GetByImageId(int id)
		{
			var result = _restaurantImageService.GetByImageId(id);
			if (!result.Success)
			{
				return BadRequest(result);
			}
			return Ok(result);
		}

		[HttpGet("getimagebyrestaurantid")]
		public IActionResult GetImageByRestaurantId(int restaurantId)
		{
			var result = _restaurantImageService.GetImageByRestaurantId(restaurantId);
			if (!result.Success)
			{
				return BadRequest(result);
			}
			return Ok(result);
		}

		[HttpPost("add")]
		public IActionResult Add([FromForm(Name = "Image")] IFormFile file, [FromForm] RestaurantImage restaurantImage)
		{
			var result = _restaurantImageService.Add(file, restaurantImage);
			if (!result.Success)
			{
				return BadRequest(result);
			}
			return Ok(result);
		}

		[HttpPost("update")]
		public IActionResult Update([FromForm(Name = "Image")] IFormFile file, [FromForm] RestaurantImage restaurantImage)
		{
			var result = _restaurantImageService.Update(file, restaurantImage);
			if (!result.Success)
			{
				return BadRequest(result);
			}
			return Ok(result);
		}

		[HttpPost("remove")]
		public IActionResult Remove([FromForm] RestaurantImage restaurantImage)
		{
			var result = _restaurantImageService.Remove(restaurantImage);
			if (!result.Success)
			{
				return BadRequest(result);
			}
			return Ok(result);
		}
	}
}
