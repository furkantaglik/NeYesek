using Core.Entities.Concrete;
using Core.Utilites.Results;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract.ImageServices
{
	public interface IRestaurantImageService
	{
		IDataResult<List<RestaurantImage>> GetAll();
		IDataResult<RestaurantImage> GetByImageId(int id);
		IDataResult<RestaurantImage> GetImageByRestaurantId(int restaurantId);
		IDataResult<RestaurantImage> Add(IFormFile file, RestaurantImage restaurantImage);
		IDataResult<RestaurantImage> Update(IFormFile file, RestaurantImage restaurantImage);
		IResult Remove(RestaurantImage restaurantImage);
	}
}
