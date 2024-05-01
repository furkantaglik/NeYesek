using Core.DataAccess;
using Core.Entities.Concrete;
using Entities.Concrete.DTOs.CommentDto;

namespace DataAccess.Abstract;

public interface ICommentDal : IEntityRepository<Comment>
{
	List<CommentDetailDto> GetAllCommentDetails();
	CommentDetailDto GetCommentDetail(int commentId);
	List<CommentDetailDto> GetCommentDetailsByRestaurant(int restaurantId);
	List<CommentDetailDto> GetCommentDetailsByProduct(int productId);
}