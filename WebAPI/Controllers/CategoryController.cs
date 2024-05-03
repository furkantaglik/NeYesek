using Business.Abstract;
using Core.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoryController : ControllerBase
	{
		ICategoryService _categoryService;
		public CategoryController(ICategoryService categoryService)
		{
			_categoryService = categoryService;
		}

		[HttpGet("getall")]
		public IActionResult GetAll()
		{
			var result= _categoryService.GetAll();
			if(result.Success)
			{
				return Ok(result.Data);
			}
			return BadRequest(result.Message);
		}

		[HttpGet("getcategorydetailsbyproduct")]
		public IActionResult GetCategoryDetailsByProduct(int productId)
		{
			var result = _categoryService.GetCategoryDetailsByProduct(productId);
			if (result.Success)
			{
				return Ok(result.Data);
			}
			return BadRequest(result.Message);
		}

		[HttpGet("getcategorydetailsbyresturant")]
		public IActionResult GetCategoryDetailsByResturant(int restaurantId)
		{
			var result = _categoryService.GetCategoryDetailsByResturant(restaurantId);
			if (result.Success)
			{
				return Ok(result.Data);
			}
			return BadRequest(result.Message);
		}

		[HttpGet("getcategorydetail")]
		public IActionResult GetCategoryDetail(int categoryId)
		{
			var result = _categoryService.GetCategoryDetail(categoryId);
			if (result.Success)
			{
				return Ok(result.Data);
			}
			return BadRequest(result.Message);
		}

		[HttpGet("getallcategorydetails")]
		public IActionResult GetAllCategoryDetails()
		{
			var result = _categoryService.GetAllCategoryDetails();
			if (result.Success)
			{
				return Ok(result.Data);
			}
			return BadRequest(result.Message);
		}

		[HttpGet("getbyid")]
		public IActionResult GetById(int Id)
		{
			var result = _categoryService.GetById(Id);
			if (result.Success)
			{
				return Ok(result.Data);
			}
			return BadRequest(result.Message);
		}

		[HttpPost("add")]
		public IActionResult Add(Category category)
		{
			var result = _categoryService.Add(category);
			if (result.Success)
			{
				return Ok(result.Message);
			}
			return BadRequest(result.Message);
		}

		[HttpPost("update")]
		public IActionResult Update(Category category)
		{
			var result = _categoryService.Update(category);
			if (result.Success)
			{
				return Ok(result.Message);
			}
			return BadRequest(result.Message);
		}

		[HttpPost("remove")]
		public IActionResult Remove(Category category)
		{
			var result = _categoryService.Remove(category);
			if (result.Success)
			{
				return Ok(result.Message);
			}
			return BadRequest(result.Message);
		}
	}
}
