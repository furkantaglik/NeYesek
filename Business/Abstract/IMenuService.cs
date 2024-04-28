using Core.Utilites.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface IMenuService
	{
		IDataResult<List<Menu>> GetList();
		IDataResult<Menu> GetById(int Id);
		IDataResult<List<Menu>> GetByRestaurantId(int restaurantId);
		IResult Add(Menu menu);
		IResult Remove(Menu menu);
		IResult Update(Menu menu);
	}
}
