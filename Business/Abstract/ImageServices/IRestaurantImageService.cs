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
		IResult Add(IFormFile file, RestaurantImage restaurantImage);
		IResult Update(IFormFile file, RestaurantImage restaurantImage);
		IResult Remove(RestaurantImage restaurantImage);
	}
}
