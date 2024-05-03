using Business.Abstract;
using Core.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CommentsController : ControllerBase
	{
		ICommentService _commentService;
		public CommentsController(ICommentService commentService)
		{
			_commentService = commentService;
		}

		[HttpGet("getall")]
		public IActionResult GetAll()
		{
			var result = _commentService.GetAll();
			if (result.Success)
			{
				return Ok(result.Data);
			}
			return BadRequest(result.Message);
		}

		[HttpGet("getcommentdetailsbyproduct")]
		public IActionResult GetCommentDetailsByProduct(int productId)
		{
			var result = _commentService.GetCommentDetailsByProduct(productId);
			if (result.Success)
			{
				return Ok(result.Data);
			}
			return BadRequest(result.Message);
		}

		[HttpGet("getcommentdetailsbyresturant")]
		public IActionResult GetCommentDetailsByResturant(int restaurantId)
		{
			var result = _commentService.GetCommentDetailsByRestaurant(restaurantId);
			if (result.Success)
			{
				return Ok(result.Data);
			}
			return BadRequest(result.Message);
		}

		[HttpGet("getcommentdetail")]
		public IActionResult GetCommentDetail(int commentId)
		{
			var result = _commentService.GetCommentDetail(commentId);
			if (result.Success)
			{
				return Ok(result.Data);
			}
			return BadRequest(result.Message);
		}

		[HttpGet("getallcommentdetails")]
		public IActionResult GetAllCommentDetails()
		{
			var result = _commentService.GetAllCommentDetails();
			if (result.Success)
			{
				return Ok(result.Data);
			}
			return BadRequest(result.Message);
		}

		[HttpGet("getbyid")]
		public IActionResult GetById(int Id)
		{
			var result = _commentService.GetById(Id);
			if (result.Success)
			{
				return Ok(result.Data);
			}
			return BadRequest(result.Message);
		}

		[HttpPost("add")]
		public IActionResult Add(Comment comment)
		{
			var result = _commentService.Add(comment);
			if (result.Success)
			{
				return Ok(result.Message);
			}
			return BadRequest(result.Message);
		}

		[HttpPost("update")]
		public IActionResult Update(Comment comment)
		{
			var result = _commentService.Update(comment);
			if (result.Success)
			{
				return Ok(result.Message);
			}
			return BadRequest(result.Message);
		}

		[HttpPost("remove")]
		public IActionResult Remove(Comment comment)
		{
			var result = _commentService.Remove(comment);
			if (result.Success)
			{
				return Ok(result.Message);
			}
			return BadRequest(result.Message);
		}
	}
}
