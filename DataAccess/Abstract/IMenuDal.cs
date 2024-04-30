using Core.DataAccess;
using Core.Entities.Concrete;
using Entities.Concrete.DTOs.MenuDto;

namespace DataAccess.Abstract;

public interface IMenuDal : IEntityRepository<Menu>
{
	List<MenuDetailDto> GetAllMenuDetails();
	List<MenuDetailDto> GetMenuDetailsByResturant(Restaurant restaurant);
}