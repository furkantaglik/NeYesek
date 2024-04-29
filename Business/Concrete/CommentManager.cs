using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilites.Results;

namespace Business.Concrete;

public class CommentManager : ICommentService
{
	public IResult Add(Comment comment)
	{
		throw new NotImplementedException();
	}

	public IDataResult<Comment> GetById(int Id)
	{
		throw new NotImplementedException();
	}

	public IDataResult<List<Comment>> GetByRestaurantId(int Id)
	{
		throw new NotImplementedException();
	}

	public IDataResult<List<Comment>> GetAll()
	{
		throw new NotImplementedException();
	}

	public IResult Remove(Comment comment)
	{
		throw new NotImplementedException();
	}

	public IResult Update(Comment comment)
	{
		throw new NotImplementedException();
	}
}