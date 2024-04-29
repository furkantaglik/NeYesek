using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;

namespace DataAccess.Concrete.EntityFramework;

public class EfProductDal : EfEntityRepositoryBase<Product, SqlContext>, IProductDal
{
	//public List<ProductDetailDto> GetProductDetails()
	//{
	//	using (SqlContext context = new SqlContext()) 
	//	{
	//		var result = from p in context.Products
	//					 join c in context.Categories
	//					 on p equals c.Id
	//					 select new ProductDetailDto
	//					 {
	//						 ProductId = p.Id,
	//						 ProductName = p.Name,
	//						 CategoryName = c.Name,
	//						 UnitsInStock = p.UnitsInStock
	//					 };
	//		return result.ToList();
	//		}
	//	}
}
