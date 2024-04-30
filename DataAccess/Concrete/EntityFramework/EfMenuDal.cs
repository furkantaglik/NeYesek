using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete.DTOs.CommentDto;
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

					 };

		return result.ToList();
	}

	public List<MenuDetailDto> GetMenuDetailsByResturant(Restaurant restaurant)
	{
		using var context = new SqlContext();
		var result = from menu in context.Menus
					 where menu.Restaurant.Id == restaurant.Id
					 select new MenuDetailDto
					 {
						 products = menu.Products,
						 restaurant = menu.Restaurant,
						 menu = menu,

					 };

		return result.ToList();
	}
}