using Core.Entities.Concrete;
using Core.Utilites.Results;
using Entities.Concrete.DTOs.ProductDto;

namespace Business.Abstract;

public interface IProductService
{

	IDataResult<List<ProductDetailDto>> GetAllProductDetails();
	IDataResult<ProductDetailDto> GetProductDetail(int productId);
	IDataResult<List<ProductDetailDto>> GetProductDetailsByRestaurant(int restaurantId);

	IDataResult<List<Product>> GetAll();
	IDataResult<Product> GetById(int Id);
	IDataResult<List<Product>> GetByRestaurantId(int restaurantId);
	IDataResult<List<Product>> GetByCategoryId(int categoryId);
	IResult Add(Product product);
	IResult Remove(Product product);
	IResult Update(Product product);
}