using Core.Entities.Concrete;
using Core.Utilites.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	internal interface IRestaurantService
	{
		IDataResult<List<Restaurant>> GetList();
		IDataResult<Restaurant> GetById(int Id);
		IResult Add(Restaurant restaurant);
		IResult Remove(Restaurant restaurant);
		IResult Update(Restaurant restaurant);
	}
}
