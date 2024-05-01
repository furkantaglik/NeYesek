using Core.Entities.Concrete;
using Core.Utilites.Results;
using Entities.Concrete.DTOs.RestaurantDto;

namespace Business.Abstract;

public interface IRestaurantService
{

	List<OperationClaim> GetRestaurantClaims(Restaurant restaurant);
	IDataResult<List<RestaurantDetailDto>> GetAllRestaurantDetails();
	IDataResult<RestaurantDetailDto> GetRestaurantDetail(int restaurantId);

	IDataResult<List<Restaurant>> GetAll();
	IDataResult<Restaurant> GetByMail(string Email);
	IDataResult<Restaurant> GetById(int Id);
	IResult Add(Restaurant restaurant);
	IResult Remove(Restaurant restaurant);
	IResult Update(Restaurant restaurant);
}