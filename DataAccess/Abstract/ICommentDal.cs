using Core.DataAccess;
using Core.Entities.Concrete;
using Entities.Concrete.DTOs.CommentDto;

namespace DataAccess.Abstract;

public interface ICommentDal : IEntityRepository<Comment>
{
	List<CommentDetailDto> GetAllCommentDetails();
	List<CommentDetailDto> GetCommentDetailsByResturant(Restaurant restaurant);
	List<CommentDetailDto> GetCommentDetailsByProduct(Product product);
}