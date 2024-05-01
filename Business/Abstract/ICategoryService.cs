using Core.Entities.Concrete;
using Core.Utilites.Results;
using Entities.Concrete.DTOs.CategoryDto;

namespace Business.Abstract;

public interface ICategoryService
{
	IDataResult<List<CategoryDetailDto>> GetAllCategoryDetails();
	IDataResult<CategoryDetailDto> GetCategoryDetail(int categoryId);
	IDataResult<List<CategoryDetailDto>> GetCategoryDetailsByResturant(int restaurantId);
	IDataResult<List<CategoryDetailDto>> GetCategoryDetailsByProduct(int productId);

	IDataResult<List<Category>> GetAll();
	IDataResult<Category> GetById(int Id);
	IResult Add(Category category);
	IResult Remove(Category category);
	IResult Update(Category category);
}