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
	public class MenuManager : IMenuService
	{
		public IResult Add(Menu menu)
		{
			throw new NotImplementedException();
		}

		public IDataResult<Menu> GetById(int Id)
		{
			throw new NotImplementedException();
		}

		public IDataResult<List<Menu>> GetByRestaurantId(int restaurantId)
		{
			throw new NotImplementedException();
		}

		public IDataResult<List<Menu>> GetList()
		{
			throw new NotImplementedException();
		}

		public IResult Remove(Menu menu)
		{
			throw new NotImplementedException();
		}

		public IResult Update(Menu menu)
		{
			throw new NotImplementedException();
		}
	}
}
