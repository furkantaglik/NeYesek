using Core.Entities.Concrete;
using Core.Utilites.Results;

namespace Business.Abstract;

public interface ICategoryService
{
	IDataResult<List<Category>> GetAll();
	IDataResult<Category> GetById(int Id);
	IResult Add(Category category);
	IResult Remove(Category category);
	IResult Update(Category category);
}