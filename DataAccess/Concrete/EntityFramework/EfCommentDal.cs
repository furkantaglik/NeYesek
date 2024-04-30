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

	public List<CommentDetailDto> GetCommentDetailsByProduct(Product product)
	{
		using var context = new SqlContext();
		var result = from comment in context.Comments
					 where comment.Product.Id == product.Id
					 select new CommentDetailDto
					 {
						 comment = comment,
						 restaurant = comment.Restaurant,
						 user = comment.User,

					 };

		return result.ToList();
	}

	public List<CommentDetailDto> GetCommentDetailsByResturant(Restaurant restaurant)
	{
		using var context = new SqlContext();
		var result = from comment in context.Comments
					 where comment.Restaurant.Id == restaurant.Id
					 select new CommentDetailDto
					 {
						 comment = comment,
						 restaurant = comment.Restaurant,
						 user = comment.User,

					 };

		return result.ToList();
	}
}