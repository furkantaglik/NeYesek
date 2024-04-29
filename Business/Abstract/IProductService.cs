using Core.Entities.Concrete;
using Core.Utilites.Results;
using Entities.Concrete.DTOs.ProductDto;

namespace Business.Abstract;

public interface IProductService
{
	IDataResult<List<Product>> GetAll();
	IDataResult<Product> GetById(int Id);
	IDataResult<List<Product>> GetByRestaurantId(int restaurantId);
	IDataResult<List<Product>> GetByCategoryId(int categoryId);
	IDataResult<List<ProductDetailDto>> GetProductDetails();
	IResult Add(Product product);
	IResult Remove(Product product);
	IResult Update(Product product);
}