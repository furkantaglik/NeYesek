using Core.Entities.Concrete;
using Core.Utilites.Results;

namespace Business.Abstract;

public interface IMenuService
{
	IDataResult<List<Menu>> GetAll();
	IDataResult<Menu> GetById(int Id);
	IDataResult<List<Menu>> GetByRestaurantId(int restaurantId);
	IResult Add(Menu menu);
	IResult Remove(Menu menu);
	IResult Update(Menu menu);
}