using Core.DataAccess;
using Core.Entities.Concrete;
using Entities.Concrete.DTOs.RestaurantDto;

namespace DataAccess.Abstract;

public interface IRestaurantDal : IEntityRepository<Restaurant>
{
	List<OperationClaim> GetRestaurantClaims(Restaurant restaurant);
	List<RestaurantDetailDto> GetAllRestaurantDetails();
	RestaurantDetailDto GetRestaurantDetail(int restaurantId);

}