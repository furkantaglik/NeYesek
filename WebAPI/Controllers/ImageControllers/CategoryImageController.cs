using Business.Abstract.ImageServices;
using Core.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.ImageControllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoryImageController : ControllerBase
	{
		ICategoryImageService _categoryImageService;

		public CategoryImageController(ICategoryImageService categoryImageService)
		{
			_categoryImageService = categoryImageService;
		}

		[HttpGet("getall")]
		public IActionResult GetAll()
		{
			var result = _categoryImageService.GetAll();
			if (!result.Success)
			{
				return BadRequest(result);
			}
			return Ok(result);
		}

		[HttpGet("getbyimageid")]
		public IActionResult GetByImageId(int id)
		{
			var result = _categoryImageService.GetByImageId(id);
			if (!result.Success)
			{
				return BadRequest(result);
			}
			return Ok(result);
		}

		[HttpGet("getimagebycategoryid")]
		public IActionResult GetImageByCategoryId(int categoryİd)
		{
			var result = _categoryImageService.GetImageByCategoryId(categoryİd);
			if (!result.Success)
			{
				return BadRequest(result);
			}
			return Ok(result);
		}

		[HttpPost("add")]
		public IActionResult Add([FromForm(Name = "Image")] IFormFile file, [FromForm] CategoryImage categoryImage)
		{
			var result = _categoryImageService.Add(file, categoryImage);
			if (!result.Success)
			{
				return BadRequest(result);
			}
			return Ok(result);
		}

		[HttpPost("update")]
		public IActionResult Update([FromForm(Name = "Image")] IFormFile file, [FromForm] CategoryImage categoryImage)
		{
			var result = _categoryImageService.Update(file, categoryImage);
			if (!result.Success)
			{
				return BadRequest(result);
			}
			return Ok(result);
		}

		[HttpPost("remove")]
		public IActionResult Remove([FromForm] CategoryImage categoryImage)
		{
			var result = _categoryImageService.Remove(categoryImage);
			if (!result.Success)
			{
				return BadRequest(result);
			}
			return Ok(result);
		}
	}

}
