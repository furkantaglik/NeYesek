using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilites.Results;
using Entities.Concrete.DTOs.RestaurantDto;

namespace Business.Concrete;

public class RestaurantManager : IRestaurantService
{
	public IResult Add(Restaurant restaurant)
	{
		throw new NotImplementedException();
	}

	public IDataResult<List<Restaurant>> GetAll()
	{
		throw new NotImplementedException();
	}

	public IDataResult<Restaurant> GetById(int Id)
	{
		throw new NotImplementedException();
	}

	public List<RestaurantOperationClaim> GetRestaurantClaims()
	{
		throw new NotImplementedException();
	}

	public IDataResult<List<RestaurantDetailDto>> GetRestaurantDetails()
	{
		throw new NotImplementedException();
	}

	public IResult Remove(Restaurant restaurant)
	{
		throw new NotImplementedException();
	}

	public IResult Update(Restaurant restaurant)
	{
		throw new NotImplementedException();
	}
}