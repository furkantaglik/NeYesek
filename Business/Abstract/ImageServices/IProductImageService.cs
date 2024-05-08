using Core.Entities.Concrete;
using Core.Utilites.Results;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract.ImageServices
{
	public interface IProductImageService
	{
		IDataResult<List<ProductImage>> GetAll();
		IDataResult<ProductImage> GetByImageId(int id);
		IDataResult<ProductImage> GetImageByProductId(int productId);
		IResult Add(IFormFile file, ProductImage productImage);
		IResult Update(IFormFile file, ProductImage productImage);
		IResult Remove(ProductImage productImage);
	}
}
