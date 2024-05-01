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

	public ProductDetailDto GetProductDetail(int productId)
	{
		using var context = new SqlContext();
		var result = from p in context.Products
					 where p.Id == productId
					 select new ProductDetailDto
					 {
						 Product = p,
						 Categories = p.Categories.ToList(),
						 Restaurant = p.Restaurant,
					 };
		return result.FirstOrDefault();
	}

	public List<ProductDetailDto> GetProductDetailsByRestaurant(int restaurantId)
	{
		using var context = new SqlContext();
		var result = from product in context.Products
					 where product.Restaurant.Id == restaurantId
					 select new ProductDetailDto
					 {
						 Restaurant = product.Restaurant,
						 Product = product,
						 Categories = product.Categories.ToList(),

					 };

		return result.ToList();
	}
}
