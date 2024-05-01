using Core.DataAccess;
using Core.Entities.Concrete;
using Entities.Concrete.DTOs.MenuDto;

namespace DataAccess.Abstract;

public interface IMenuDal : IEntityRepository<Menu>
{
	List<MenuDetailDto> GetAllMenuDetails();
	MenuDetailDto GetMenuDetail(int menuId);
	List<MenuDetailDto> GetMenuDetailsByRestaurant(int restaurantId);
}