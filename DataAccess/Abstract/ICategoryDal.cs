using Core.DataAccess;
using Core.Entities.Concrete;
using Entities.Concrete.DTOs.CategoryDto;

namespace DataAccess.Abstract;

public interface ICategoryDal : IEntityRepository<Category>
{
	List<CategoryDetailDto> GetAllCategoryDetails();
	List<CategoryDetailDto> GetCategoryDetailsByResturant(Restaurant restaurant);
	List<CategoryDetailDto> GetCategoryDetailsByProduct(Product product);
}