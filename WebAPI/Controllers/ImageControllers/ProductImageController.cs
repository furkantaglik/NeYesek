using Business.Abstract.ImageServices;
using Core.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.ImageControllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductImageController : ControllerBase
	{
		IProductImageService _productImageService;

		public ProductImageController(IProductImageService productImageService)
		{
			_productImageService = productImageService;
		}

		[HttpGet("getall")]
		public IActionResult GetAll()
		{
			var result = _productImageService.GetAll();
			if (!result.Success)
			{
				return BadRequest(result);
			}
			return Ok(result);
		}

		[HttpGet("getbyimageid")]
		public IActionResult GetByImageId(int id)
		{
			var result = _productImageService.GetByImageId(id);
			if (!result.Success)
			{
				return BadRequest(result);
			}
			return Ok(result);
		}

		[HttpGet("getimagebyproductid")]
		public IActionResult GetImageByProductId(int productId)
		{
			var result = _productImageService.GetImageByProductId(productId);
			if (!result.Success)
			{
				return BadRequest(result);
			}
			return Ok(result);
		}

		[HttpPost("add")]
		public IActionResult Add([FromForm(Name = "Image")] IFormFile file, [FromForm] ProductImage productImage)
		{
			var result = _productImageService.Add(file, productImage);
			if (!result.Success)
			{
				return BadRequest(result);
			}
			return Ok(result);
		}

		[HttpPost("update")]
		public IActionResult Update([FromForm(Name = "Image")] IFormFile file, [FromForm] ProductImage productImage)
		{
			var result = _productImageService.Update(file, productImage);
			if (!result.Success)
			{
				return BadRequest(result);
			}
			return Ok(result);
		}

		[HttpPost("remove")]
		public IActionResult Remove([FromForm] ProductImage productImage)
		{
			var result = _productImageService.Remove(productImage);
			if (!result.Success)
			{
				return BadRequest(result);
			}
			return Ok(result);
		}
	}
}
