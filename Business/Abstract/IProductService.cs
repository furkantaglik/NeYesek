using Core.Utilites.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface IProductService
	{
		IDataResult<List<Product>> GetList();
		IDataResult<Product> GetById(int Id);
		IDataResult<List<Product>> GetByRestaurantId(int restaurantId);
		IDataResult<List<Product>> GetByCategoryId(int categoryId);
		IResult Add(Product product);
		IResult Remove(Product product);
		IResult Update(Product product);
	}
}
