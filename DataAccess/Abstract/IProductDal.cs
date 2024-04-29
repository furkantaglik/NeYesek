using Core.DataAccess;
using Core.Entities.Concrete;

namespace DataAccess.Abstract;

public interface IProductDal : IEntityRepository<Product>
{
	//List<ProductDetailDto> GetProductDetails();
}