using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete.DTOs.RestaurantDto;

namespace DataAccess.Concrete.EntityFramework;

public class EfRestaurantDal : EfEntityRepositoryBase<Restaurant, SqlContext>, IRestaurantDal
{
	public List<OperationClaim> GetRestaurantClaims(Restaurant restaurant)
	{
		using var context = new SqlContext();
		var result = from OperationClaim in context.OperationClaims
					 join RestaurantOperationClaim in context.RestaurantOperationClaims
					 on OperationClaim.Id equals RestaurantOperationClaim.Id
					 where RestaurantOperationClaim.Restaurant.Id == restaurant.Id
					 select new OperationClaim { Id = OperationClaim.Id, Name = OperationClaim.Name, };
		return result.ToList();
	}

	public List<RestaurantDetailDto> GetAllRestaurantDetails()
	{
		using var context = new SqlContext();
		var result = from restaurant in context.Restaurants
					 select new RestaurantDetailDto
					 {

						 Restaurant = restaurant,
						 Products = restaurant.Products.ToList(),
						 Menus = restaurant.Menus.ToList(),
						 Comments = restaurant.Comments.ToList(),
						 Categories = restaurant.Categories.ToList(),
						 RestaurantImage = restaurant.RestaurantImage
					 };
		return result.ToList();
	}

	public RestaurantDetailDto GetRestaurantDetail(int restaurantId)
	{
		using var context = new SqlContext();
		var result = from r in context.Restaurants
					 where r.Id == restaurantId
					 select new RestaurantDetailDto
					 {
						 Restaurant = r,
						 Products = r.Products.ToList(),
						 Menus = r.Menus.ToList(),
						 Comments = r.Comments.ToList(),
						 Categories = r.Categories.ToList(),
						 RestaurantImage = r.RestaurantImage
					 };
		return result.FirstOrDefault();
	}
}