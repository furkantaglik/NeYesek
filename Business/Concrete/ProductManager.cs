using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilites.Results;
using DataAccess.Abstract;
using Entities.Concrete.DTOs.ProductDto;

namespace Business.Concrete;

public class ProductManager : IProductService
{
	IProductDal _productDal;

	public ProductManager(IProductDal productDal)
	{
		_productDal = productDal;
	}

	public IResult Add(Product product)
	{
		_productDal.Add(product);
		return new SuccessResult("Ürün eklendi");
	}

	public IDataResult<List<Product>> GetAll()
	{
		var data = _productDal.GetAll();
		return new SuccessDataResult<List<Product>>(data);
	}

	public IDataResult<List<ProductDetailDto>> GetAllProductDetails()
	{
		var data = _productDal.GetAllProductDetails();
		return new SuccessDataResult<List<ProductDetailDto>>(data);
	}

	public IDataResult<List<Product>> GetByCategoryId(int categoryId)
	{
		var data = _productDal.GetAll(p => p.Categories.Any(c => c.Id == categoryId));
		return new SuccessDataResult<List<Product>>(data);
	}

	public IDataResult<Product> GetById(int Id)
	{
		var data = _productDal.Get(p => p.Id == Id);
		return new SuccessDataResult<Product>(data);
	}

	public IDataResult<List<Product>> GetByRestaurantId(int restaurantId)
	{
		var data = _productDal.GetAll(p => p.Restaurant.Id == restaurantId);
		return new SuccessDataResult<List<Product>>(data);
	}

	public IDataResult<ProductDetailDto> GetProductDetail(int productId)
	{
		var data = _productDal.GetProductDetail(productId);
		return new SuccessDataResult<ProductDetailDto>(data);
	}

	public IDataResult<List<ProductDetailDto>> GetProductDetailsByRestaurant(int restaurantId)
	{
		var data = _productDal.GetProductDetailsByRestaurant(restaurantId);
		return new SuccessDataResult<List<ProductDetailDto>>(data);
	}

	public IResult Remove(Product product)
	{
		_productDal.Delete(product);
		return new SuccessResult("Ürün silindi");
	}

	public IResult Update(Product product)
	{
		_productDal.Update(product);
		return new SuccessResult("Ürün güncellendi");
	}
}