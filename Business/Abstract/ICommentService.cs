using Core.Entities.Concrete;
using Core.Utilites.Results;
using Entities.Concrete.DTOs.CommentDto;

namespace Business.Abstract;

internal interface ICommentService
{

	IDataResult<List<CommentDetailDto>> GetAllCommentDetails();
	IDataResult<CommentDetailDto> GetCommentDetail(int commentId);
	IDataResult<List<CommentDetailDto>> GetCommentDetailsByRestaurant(int restaurantId);
	IDataResult<List<CommentDetailDto>> GetCommentDetailsByProduct(int productId);

	IDataResult<List<Comment>> GetAll();
	IDataResult<Comment> GetById(int Id);
	IResult Add(Comment comment);
	IResult Update(Comment comment);
}