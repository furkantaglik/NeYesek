using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilites.Results;

namespace Business.Concrete;

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

	public IDataResult<List<Menu>> GetAll()
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