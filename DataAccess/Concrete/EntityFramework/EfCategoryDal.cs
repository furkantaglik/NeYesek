using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete.DTOs.CategoryDto;

namespace DataAccess.Concrete.EntityFramework;

public class EfCategoryDal : EfEntityRepositoryBase<Category, SqlContext>, ICategoryDal
{
	public List<CategoryDetailDto> GetAllCategoryDetails()
	{
		using var context = new SqlContext();
		var result = from categories in context.Categories
					 select new CategoryDetailDto
					 {
						 Restaurants = categories.Restaurants.ToList(),
						 Products = categories.Products.ToList(),
						 Category = categories,

					 };

		return result.ToList();
	}

	public CategoryDetailDto GetCategoryDetail(int categoryId)
	{
		using var context = new SqlContext();
		var result = from c in context.Categories
					 where c.Id == categoryId
					 select new CategoryDetailDto
					 {
						 Restaurants = c.Restaurants.ToList(),
						 Products = c.Products.ToList(),
						 Category = c,

					 };

		return result.FirstOrDefault();
	}

	public List<CategoryDetailDto> GetCategoryDetailsByProduct(int productId)
	{
		using var context = new SqlContext();
		var result = from category in context.Categories
					 where category.Products.Any(p => p.Id == productId)
					 select new CategoryDetailDto
					 {
						 Restaurants = category.Restaurants.ToList(),
						 Products = category.Products.ToList(),
						 Category = category
					 };

		return result.ToList();
	}

	public List<CategoryDetailDto> GetCategoryDetailsByRestaurant(int restaurantId)
	{
		using var context = new SqlContext();
		var result = from category in context.Categories
					 where category.Products.Any(p => p.Id == restaurantId)
					 select new CategoryDetailDto
					 {
						 Restaurants = category.Restaurants.ToList(),
						 Products = category.Products.ToList(),
						 Category = category
					 };

		return result.ToList();
	}
}