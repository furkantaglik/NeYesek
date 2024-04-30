using Core.DataAccess;
using Core.Entities.Concrete;
using Entities.Concrete.DTOs.ProductDto;

namespace DataAccess.Abstract;

public interface IProductDal : IEntityRepository<Product>
{
	List<ProductDetailDto> GetAllProductDetails();
	List<ProductDetailDto> GetProductDetailsByResturant(Restaurant restaurant);
}