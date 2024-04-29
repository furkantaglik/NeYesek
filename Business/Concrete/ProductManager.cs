using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilites.Results;
using Entities.Concrete.DTOs.ProductDto;

namespace Business.Concrete;

public class ProductManager : IProductService
{
	public IResult Add(Product product)
	{
		throw new NotImplementedException();
	}

	public IDataResult<List<Product>> GetByCategoryId(int categoryId)
	{
		throw new NotImplementedException();
	}

	public IDataResult<Product> GetById(int Id)
	{
		throw new NotImplementedException();
	}

	public IDataResult<List<Product>> GetByRestaurantId(int restaurantId)
	{
		throw new NotImplementedException();
	}

	public IDataResult<List<Product>> GetAll()
	{
		throw new NotImplementedException();
	}

	public IResult Remove(Product product)
	{
		throw new NotImplementedException();
	}

	public IResult Update(Product product)
	{
		throw new NotImplementedException();
	}

	public IDataResult<List<ProductDetailDto>> GetProductDetails()
	{
		throw new NotImplementedException();
	}
}