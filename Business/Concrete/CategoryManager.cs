using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilites.Results;

namespace Business.Concrete;

public class CategoryManager : ICategoryService
{
	public IResult Add(Category category)
	{
		throw new NotImplementedException();
	}

	public IDataResult<Category> GetById(int Id)
	{
		throw new NotImplementedException();
	}

	public IDataResult<List<Category>> GetAll()
	{
		throw new NotImplementedException();
	}

	public IResult Remove(Category category)
	{
		throw new NotImplementedException();
	}

	public IResult Update(Category category)
	{
		throw new NotImplementedException();
	}
}