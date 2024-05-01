using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete.DTOs.CommentDto;

namespace DataAccess.Concrete.EntityFramework;

public class EfCommentDal : EfEntityRepositoryBase<Comment, SqlContext>, ICommentDal
{
	public List<CommentDetailDto> GetAllCommentDetails()
	{
		using var context = new SqlContext();
		var result = from comment in context.Comments
					 select new CommentDetailDto
					 {
						 comment = comment,
						 restaurant = comment.Restaurant,
						 user = comment.User,

					 };

		return result.ToList();
	}

	public CommentDetailDto GetCommentDetail(int commentId)
	{
		using var context = new SqlContext();
		var result = from c in context.Comments
					 where c.Id == commentId
					 select new CommentDetailDto
					 {
						 comment = c,
						 restaurant = c.Restaurant,
						 user = c.User,

					 };

		return result.FirstOrDefault();
	}

	public List<CommentDetailDto> GetCommentDetailsByProduct(int productId)
	{
		using var context = new SqlContext();
		var result = from comment in context.Comments
					 where comment.Product.Id == productId
					 select new CommentDetailDto
					 {
						 comment = comment,
						 restaurant = comment.Restaurant,
						 user = comment.User,

					 };

		return result.ToList();
	}

	public List<CommentDetailDto> GetCommentDetailsByRestaurant(int restaurantId)
	{
		using var context = new SqlContext();
		var result = from comment in context.Comments
					 where comment.Restaurant.Id == restaurantId
					 select new CommentDetailDto
					 {
						 comment = comment,
						 restaurant = comment.Restaurant,
						 user = comment.User,

					 };

		return result.ToList();
	}
}