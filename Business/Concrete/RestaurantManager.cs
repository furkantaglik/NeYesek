using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilites.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class RestaurantManager : IRestaurantService
	{
		public IResult Add(Restaurant restaurant)
		{
			throw new NotImplementedException();
		}

		public IDataResult<Restaurant> GetById(int Id)
		{
			throw new NotImplementedException();
		}

		public IDataResult<List<Restaurant>> GetList()
		{
			throw new NotImplementedException();
		}

		public IResult Remove(Restaurant restaurant)
		{
			throw new NotImplementedException();
		}

		public IResult Update(Restaurant restaurant)
		{
			throw new NotImplementedException();
		}
	}
}
