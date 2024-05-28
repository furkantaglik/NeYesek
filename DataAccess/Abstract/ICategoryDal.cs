using Core.DataAccess;
using Core.Entities.Concrete;
using Entities.Concrete.DTOs.CategoryDto;

namespace DataAccess.Abstract;

public interface ICategoryDal : IEntityRepository<Category>
{
	List<CategoryDetailDto> GetAllCategoryDetails();
	CategoryDetailDto GetCategoryDetail(int categoryId);
	List<CategoryDetailDto> GetCategoryDetailsByRestaurant(int restaurantId);
	List<CategoryDetailDto> GetCategoryDetailsByProduct(int productId);
	Category AddCategoryToRestaurant(int categoryId,int restaurantId);
}