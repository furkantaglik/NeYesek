using Core.Entities.Concrete;
using Core.Utilites.Results;
using Entities.Concrete.DTOs.MenuDto;

namespace Business.Abstract;

public interface IMenuService
{

	IDataResult<List<MenuDetailDto>> GetAllMenuDetails();
	IDataResult<MenuDetailDto> GetMenuDetail(int menuId);
	IDataResult<List<MenuDetailDto>> GetMenuDetailsByRestaurant(int restaurantId);

	IDataResult<List<Menu>> GetAll();
	IDataResult<Menu> GetById(int Id);
	IResult Add(Menu menu);
	IResult Remove(Menu menu);
	IResult Update(Menu menu);
}