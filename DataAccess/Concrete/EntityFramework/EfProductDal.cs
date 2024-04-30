using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete.DTOs.ProductDto;

namespace DataAccess.Concrete.EntityFramework;

public class EfProductDal : EfEntityRepositoryBase<Product, SqlContext>, IProductDal
{
	public List<ProductDetailDto> GetAllProductDetails()
	{
		using var context = new SqlContext();
		var result = from product in context.Products
					 select new ProductDetailDto
					 {
						 Restaurant = product.Restaurant,
						 Product = product,
						 Categories = product.Categories.ToList(),

					 };

		return result.ToList();

	}

	public List<ProductDetailDto> GetProductDetailsByResturant(Restaurant restaurant)
	{
		using var context = new SqlContext();
		var result = from product in context.Products
					 where product.Restaurant.Id == restaurant.Id
					 select new ProductDetailDto
					 {
						 Restaurant = product.Restaurant,
						 Product = product,
						 Categories = product.Categories.ToList(),

					 };

		return result.ToList();
	}
}
