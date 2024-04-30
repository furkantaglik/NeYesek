using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete.DTOs.CategoryDto;
using Microsoft.EntityFrameworkCore;

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

	public List<CategoryDetailDto> GetCategoryDetailsByProduct(Product product)
	{
		using var context = new SqlContext();
		var result = from category in context.Categories
					 where category.Products.Any(p => p.Id == product.Id)
					 select new CategoryDetailDto
					 {
						 Restaurants = category.Restaurants.ToList(),
						 Products = category.Products.ToList(),
						 Category = category
					 };

		return result.ToList();
	}

	public List<CategoryDetailDto> GetCategoryDetailsByResturant(Restaurant restaurant)
	{
		using var context = new SqlContext();
		var result = from category in context.Categories
					 where category.Products.Any(p => p.Id == restaurant.Id)
					 select new CategoryDetailDto
					 {
						 Restaurants = category.Restaurants.ToList(),
						 Products = category.Products.ToList(),
						 Category = category
					 };

		return result.ToList();
	}
}