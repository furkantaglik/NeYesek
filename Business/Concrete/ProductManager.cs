using Business.Abstract;
using Core.Utilites.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
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

		public IDataResult<List<Product>> GetList()
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
	}
}
