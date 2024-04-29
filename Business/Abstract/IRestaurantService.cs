using Core.Entities.Concrete;
using Core.Utilites.Results;
using Entities.Concrete.DTOs.RestaurantDto;

namespace Business.Abstract;

internal interface IRestaurantService
{
	IDataResult<List<Restaurant>> GetAll();
	IDataResult<Restaurant> GetById(int Id);
	List<RestaurantOperationClaim> GetRestaurantClaims();
	IDataResult<List<RestaurantDetailDto>> GetRestaurantDetails();
	IResult Add(Restaurant restaurant);
	IResult Remove(Restaurant restaurant);
	IResult Update(Restaurant restaurant);
}