using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete.DTOs.CategoryDto;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework;

public class EfCategoryDal : EfEntityRepositoryBase<Category, SqlContext>, ICategoryDal
{
	public Category AddCategoryToRestaurant(int categoryId, int restaurantId)
	{
		using (var context = new SqlContext())
		{
			var category = context.Categories.Include(c => c.Restaurants).FirstOrDefault(c => c.Id == categoryId);
			var restaurant = context.Restaurants.FirstOrDefault(r => r.Id == restaurantId);
			if (category.Restaurants.Any(r => r.Id == restaurantId))
			{
				category.Restaurants.Remove(restaurant);
			}
			else
			{
				category.Restaurants.Add(restaurant);
			}
			context.SaveChanges();
			return category;
		}
	}



	public List<CategoryDetailDto> GetAllCategoryDetails()
	{
		using var context = new SqlContext();
		var result = from categories in context.Categories
					 select new CategoryDetailDto
					 {
						 Restaurants = categories.Restaurants.ToList(),
						 Products = categories.Products.ToList(),
						 Category = categories,
						 CategoryImage = categories.CategoryImage

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
						 CategoryImage = c.CategoryImage,
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
						 CategoryImage = category.CategoryImage,
						 Category = category
					 };

		return result.ToList();
	}

	public List<CategoryDetailDto> GetCategoryDetailsByRestaurant(int restaurantId)
	{
		using var context = new SqlContext();
		var result = from category in context.Categories
					 where category.Restaurants.Any(r => r.Id == restaurantId)
					 select new CategoryDetailDto
					 {
						 Restaurants = category.Restaurants.ToList(),
						 Products = category.Products.ToList(),
						 CategoryImage = category.CategoryImage,
						 Category = category
					 };

		return result.ToList();
	}
}