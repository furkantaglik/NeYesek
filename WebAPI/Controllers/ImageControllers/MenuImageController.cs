using AutoMapper;
using Business.Abstract.ImageServices;
using Core.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace WebAPI.Controllers.ImageControllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MenuImageController : ControllerBase
	{
		IMenuImageService _menuImageService;
		private readonly IMapper _mapper;

		public MenuImageController(IMenuImageService menuImageService)
		{
			_menuImageService = menuImageService;
		}

		[HttpGet("getall")]
		public IActionResult GetAll()
		{
			var result = _menuImageService.GetAll();
			if (!result.Success)
			{
				return BadRequest(result);
			}
			return Ok(result);
		}

		[HttpGet("getbyimageid")]
		public IActionResult GetByImageId(int id)
		{
			var result = _menuImageService.GetByImageId(id);
			if (!result.Success)
			{
				return BadRequest(result);
			}
			return Ok(result);
		}

		[HttpGet("getimagebymenuid")]
		public IActionResult GetImageByMenuId(int menuId)
		{
			var result = _menuImageService.GetImageByMenuId(menuId);
			if (!result.Success)
			{
				return BadRequest(result);
			}
			return Ok(result);
		}

		[HttpPost("add")]
		public IActionResult Add([FromForm(Name = "Image")] IFormFile file, [FromForm] string menuImage)
		{
			MenuImage convertImage = JsonConvert.DeserializeObject<MenuImage>(menuImage);
			var result = _menuImageService.Add(file, convertImage);
			if (!result.Success)
			{
				return BadRequest(result);
			}
			return Ok(result);
		}

		[HttpPost("update")]
		public IActionResult Update([FromForm(Name = "Image")] IFormFile file, [FromForm] string menuImage)
		{
			MenuImage convertImage = JsonConvert.DeserializeObject<MenuImage>(menuImage);
			var result = _menuImageService.Update(file, convertImage);
			if (!result.Success)
			{
				return BadRequest(result);
			}
			return Ok(result);
		}

		[HttpPost("remove")]
		public IActionResult Remove([FromForm] string menuImage)
		{
			MenuImage convertImage = JsonConvert.DeserializeObject<MenuImage>(menuImage);
			var result = _menuImageService.Remove(convertImage);
			if (!result.Success)
			{
				return BadRequest(result);
			}
			return Ok(result);
		}
	}
}
