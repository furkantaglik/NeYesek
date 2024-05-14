using Core.Entities.Concrete;
using Core.Utilites.Results;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract.ImageServices
{
	public interface ICategoryImageService
	{
		IDataResult<List<CategoryImage>> GetAll();
		IDataResult<CategoryImage> GetByImageId(int id);
		IDataResult<CategoryImage> GetImageByCategoryId(int categoryId);
		IDataResult<CategoryImage> Add(IFormFile file, CategoryImage categoryImage);
		IDataResult<CategoryImage> Update(IFormFile file, CategoryImage categoryImage);
		IResult Remove(CategoryImage categoryImage);

	}
}
