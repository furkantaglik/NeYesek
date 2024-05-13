using Business.Abstract;
using Business.Abstract.ImageServices;
using Core.Entities.Concrete;
using Core.Utilites.Results;
using DataAccess.Abstract;
using Entities.Concrete.DTOs.MenuDto;

namespace Business.Concrete;

public class MenuManager : IMenuService
{
	IMenuDal _menuDal;
	IMenuImageDal _menuImageDal;
	public MenuManager(IMenuDal menuDal, IMenuImageDal menuImageDal)
	{
		_menuDal = menuDal;
		_menuImageDal = menuImageDal;
	}

	public IResult Add(Menu menu)
	{
		_menuDal.Add(menu);
		if (menu.MenuImage != null)
		{
			menu.MenuImage.MenuId = menu.Id;
			menu.MenuImage.Menu = menu;
			_menuImageDal.Add(menu.MenuImage);
		}
		return new SuccessResult("Menü eklendi");
	}


	public IDataResult<List<Menu>> GetAll()
	{
		var data = _menuDal.GetAll();
		return new SuccessDataResult<List<Menu>>(data);
	}

	public IDataResult<List<MenuDetailDto>> GetAllMenuDetails()
	{
		var data = _menuDal.GetAllMenuDetails();
		return new SuccessDataResult<List<MenuDetailDto>>(data);
	}

	public IDataResult<Menu> GetById(int Id)
	{
		var data = _menuDal.Get(m => m.Id == Id);
		return new SuccessDataResult<Menu>(data);
	}

	public IDataResult<MenuDetailDto> GetMenuDetail(int menuId)
	{
		var data = _menuDal.GetMenuDetail(menuId);
		return new SuccessDataResult<MenuDetailDto>(data);
	}

	public IDataResult<List<MenuDetailDto>> GetMenuDetailsByRestaurant(int restaurantId)
	{
		var data = _menuDal.GetMenuDetailsByRestaurant(restaurantId);
		return new SuccessDataResult<List<MenuDetailDto>>(data);
	}

	public IResult Remove(Menu menu)
	{
		_menuDal.Delete(menu);
		return new SuccessResult("Menü silindi");
	}

	public IResult Update(Menu menu)
	{
		_menuDal.Update(menu);
		if (menu.MenuImage != null)
		{
			menu.MenuImage.MenuId = menu.Id;
			menu.MenuImage.Menu = menu;
			_menuImageDal.Add(menu.MenuImage);
		}
		return new SuccessResult("Menü Güncellendi");
	}
}