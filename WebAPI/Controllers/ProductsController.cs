using Business.Abstract;
using Core.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductsController : ControllerBase
	{
		private IProductService _productService;

		public ProductsController(IProductService productService)
		{
			_productService = productService;
		}

		[HttpGet("getall")]
		public IActionResult GetAll()
		{
			var result = _productService.GetAll();
			if (result.Success)
			{
				return Ok(result.Data);
			}
			return BadRequest(result.Message);
		}

		[HttpGet("getallproductdetails")]
		public IActionResult GetAllProductDetails()
		{
			var result = _productService.GetAllProductDetails();
			if (result.Success)
			{
				return Ok(result.Data);
			}
			return BadRequest(result.Message);
		}

		[HttpGet("getbyid")]
		public IActionResult GetById(int Id)
		{
			var result = _productService.GetById(Id);
			if (result.Success)
			{
				return Ok(result.Data);
			}
			return BadRequest(result.Message);
		}

		[HttpGet("getproductdetailsbyrestaurant")]
		public IActionResult GetProductDetailsByRestaurant(int restaurantId)
		{
			var result = _productService.GetProductDetailsByRestaurant(restaurantId);
			if (result.Success)
			{
				return Ok(result.Data);
			}
			return BadRequest(result.Message);
		}

		[HttpGet("getproductdetail")]
		public IActionResult GetProductDetail(int productId)
		{
			var result = _productService.GetProductDetail(productId);
			if (result.Success)
			{
				return Ok(result.Data);
			}
			return BadRequest(result.Message);
		}

		[HttpGet("getbyrestaurantid")]
		public IActionResult GetByRestaurantId(int restaurantId)
		{
			var result = _productService.GetByRestaurantId(restaurantId);
			if (result.Success)
			{
				return Ok(result.Data);
			}
			return BadRequest(result.Message);
		}

		[HttpGet("getbycategoryid")]
		public IActionResult GetByCategoryId(int categoryId)
		{
			var result = _productService.GetByCategoryId(categoryId);
			if (result.Success)
			{
				return Ok(result.Data);
			}
			return BadRequest(result.Message);
		}

		[HttpPost("add")]
		public IActionResult Add(Product product)
		{
			var result = _productService.Add(product);
			if (result.Success)
			{
				return Ok(result.Message);
			}
			return BadRequest(result.Message);
		}

		[HttpPost("update")]
		public IActionResult Update(Product product)
		{
			var result = _productService.Update(product);
			if (result.Success)
			{
				return Ok(result.Message);
			}
			return BadRequest(result.Message);
		}

		[HttpPost("remove")]
		public IActionResult Remove(Product product)
		{
			var result = _productService.Remove(product);
			if (result.Success)
			{
				return Ok(result.Message);
			}
			return BadRequest(result.Message);
		}
	}
}
