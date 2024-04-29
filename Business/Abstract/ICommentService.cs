using Core.Entities.Concrete;
using Core.Utilites.Results;

namespace Business.Abstract;

internal interface ICommentService
{
	IDataResult<List<Comment>> GetAll();
	IDataResult<List<Comment>> GetByRestaurantId(int Id);
	IDataResult<Comment> GetById(int Id);
	IResult Add(Comment comment);
	IResult Remove(Comment comment);
	IResult Update(Comment comment);
}