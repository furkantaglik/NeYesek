using Core.DataAccess;
using Core.Entities.Concrete;
using Entities.Concrete.DTOs.ProductDto;

namespace DataAccess.Abstract;

public interface IProductDal : IEntityRepository<Product>
{
	List<ProductDetailDto> GetAllProductDetails();
	ProductDetailDto GetProductDetail(int productId);
	List<ProductDetailDto> GetProductDetailsByRestaurant(int restaurantId);
}