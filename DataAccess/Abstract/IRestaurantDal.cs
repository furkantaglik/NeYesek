using Core.DataAccess;
using Core.Entities.Concrete;

namespace DataAccess.Abstract;

public interface IRestaurantDal : IEntityRepository<Restaurant>
{
	//List<OperationClaim> GetRestaurantClaims(Restaurant restaurant);
	//List<RestaurantDetailDto> GetRestaurantDetails();

}