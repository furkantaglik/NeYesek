using Business.Abstract.ImageServices;
using Core.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

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
		public IActionResult GetImageByCategoryId(int categoryId)
		{
			var result = _categoryImageService.GetImageByCategoryId(categoryId);
			if (!result.Success)
			{
				return BadRequest(result);
			}
			return Ok(result);
		}

		[HttpPost("add")]
		public IActionResult Add([FromForm(Name = "Image")] IFormFile file, [FromForm] string categoryImage)
		{
			CategoryImage convertImage = JsonConvert.DeserializeObject<CategoryImage>(categoryImage);
			var result = _categoryImageService.Add(file, convertImage);
			if (!result.Success)
			{
				return BadRequest(result);
			}
			return Ok(result);
		}

		[HttpPost("update")]
		public IActionResult Update([FromForm(Name = "Image")] IFormFile file, [FromForm] string categoryImage)
		{
			CategoryImage convertImage = JsonConvert.DeserializeObject<CategoryImage>(categoryImage);
			var result = _categoryImageService.Update(file, convertImage);
			if (!result.Success)
			{
				return BadRequest(result);
			}
			return Ok(result);
		}

		[HttpPost("remove")]
		public IActionResult Remove([FromForm] string categoryImage)
		{
			CategoryImage convertImage = JsonConvert.DeserializeObject<CategoryImage>(categoryImage);
			var result = _categoryImageService.Remove(convertImage);
			if (!result.Success)
			{
				return BadRequest(result);
			}
			return Ok(result);
		}
	}

}
