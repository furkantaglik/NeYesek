using Core.Entities.Concrete;
using Core.Utilites.Results;
using Entities.Concrete.DTOs.CategoryDto;

namespace Business.Abstract;

public interface ICategoryService
{
	IDataResult<List<Category>> GetAll();
	IDataResult<Category> GetById(int Id);
	IDataResult<CategoryDetailDto> GetCategoryDetails();
	IResult Add(Category category);
	IResult Remove(Category category);
	IResult Update(Category category);
}