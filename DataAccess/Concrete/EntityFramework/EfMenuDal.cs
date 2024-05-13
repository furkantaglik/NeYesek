using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete.DTOs.MenuDto;

namespace DataAccess.Concrete.EntityFramework;

public class EfMenuDal : EfEntityRepositoryBase<Menu, SqlContext>, IMenuDal
{
	public List<MenuDetailDto> GetAllMenuDetails()
	{
		using var context = new SqlContext();
		var result = from Menu in context.Menus
					 select new MenuDetailDto
					 {
						 menu = Menu,
						 restaurant = Menu.Restaurant,
						 products = Menu.Products.ToList(),
						 MenuImage = Menu.MenuImage

					 };

		return result.ToList();
	}

	public MenuDetailDto GetMenuDetail(int menuId)
	{
		using var context = new SqlContext();
		var result = from m in context.Menus
					 where menuId == m.Id
					 select new MenuDetailDto
					 {
						 products = m.Products.ToList(),
						 restaurant = m.Restaurant,
						 MenuImage = m.MenuImage,
						 menu = m

					 };

		return result.FirstOrDefault();
	}

	public List<MenuDetailDto> GetMenuDetailsByRestaurant(int restaurantId)
	{
		using var context = new SqlContext();
		var result = from menu in context.Menus
					 where menu.Restaurant.Id == restaurantId
					 select new MenuDetailDto
					 {
						 products = menu.Products,
						 restaurant = menu.Restaurant,
						 MenuImage = menu.MenuImage,
						 menu = menu,

					 };

		return result.ToList();
	}
}