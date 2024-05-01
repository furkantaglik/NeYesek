using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilites.Results;
using DataAccess.Abstract;
using Entities.Concrete.DTOs.CommentDto;

namespace Business.Concrete;

public class CommentManager : ICommentService
{
	ICommentDal _commentDal;
	public CommentManager(ICommentDal commentDal)
	{
		_commentDal = commentDal;
	}
	public IResult Add(Comment comment)
	{
		_commentDal.Add(comment);
		return new SuccessResult("Yorum Eklendi");
	}

	public IDataResult<List<Comment>> GetAll()
	{
		var data = _commentDal.GetAll();
		return new SuccessDataResult<List<Comment>>(data);
	}

	public IDataResult<List<CommentDetailDto>> GetAllCommentDetails()
	{
		var data = _commentDal.GetAllCommentDetails();
		return new SuccessDataResult<List<CommentDetailDto>>(data);
	}

	public IDataResult<Comment> GetById(int Id)
	{
		var data = _commentDal.Get(c => c.Id == Id);
		return new SuccessDataResult<Comment>(data);
	}

	public IDataResult<CommentDetailDto> GetCommentDetail(int commentId)
	{
		var data = _commentDal.GetCommentDetail(commentId);
		return new SuccessDataResult<CommentDetailDto>(data);
	}

	public IDataResult<List<CommentDetailDto>> GetCommentDetailsByProduct(int productId)
	{
		var data = _commentDal.GetCommentDetailsByProduct(productId);
		return new SuccessDataResult<List<CommentDetailDto>>(data);
	}

	public IDataResult<List<CommentDetailDto>> GetCommentDetailsByRestaurant(int restaurantId)
	{
		var data = _commentDal.GetCommentDetailsByRestaurant(restaurantId);
		return new SuccessDataResult<List<CommentDetailDto>>(data);
	}

	public IResult Remove(Comment comment)
	{
		_commentDal.Delete(comment);
		return new SuccessResult("Yorum silindi");
	}

	public IResult Update(Comment comment)
	{
		_commentDal.Update(comment);
		return new SuccessResult("Yorum Güncellendi");
	}
}