using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilites.Results;
using DataAccess.Abstract;
using Entities.Concrete.DTOs.RestaurantDto;

namespace Business.Concrete;

public class RestaurantManager : IRestaurantService
{
	IRestaurantDal _restaurantDal;
	public RestaurantManager(IRestaurantDal restaurantDal)
	{
		_restaurantDal = restaurantDal;
	}

	public IResult Add(Restaurant restaurant)
	{
		_restaurantDal.Add(restaurant);
		return new SuccessResult("Restoran eklendi");
	}

	public IDataResult<List<Restaurant>> GetAll()
	{
		var data = _restaurantDal.GetAll();
		return new SuccessDataResult<List<Restaurant>>();
	}

	public IDataResult<List<RestaurantDetailDto>> GetAllRestaurantDetails()
	{
		var data = _restaurantDal.GetAllRestaurantDetails();
		return new SuccessDataResult<List<RestaurantDetailDto>>(data);
	}

	public IDataResult<Restaurant> GetById(int Id)
	{
		var data = _restaurantDal.Get(r => r.Id == Id);
		return new SuccessDataResult<Restaurant>(data);
	}

	public IDataResult<Restaurant> GetByMail(string Email)
	{
		var data = _restaurantDal.Get(r => r.Email == Email);
		return new SuccessDataResult<Restaurant>(data);
	}

	public List<OperationClaim> GetRestaurantClaims(Restaurant restaurant)
	{
		return _restaurantDal.GetRestaurantClaims(restaurant);
	}

	public IDataResult<RestaurantDetailDto> GetRestaurantDetail(int restaurantId)
	{
		var data = _restaurantDal.GetRestaurantDetail(restaurantId);
		return new SuccessDataResult<RestaurantDetailDto>(data);
	}

	public IResult Remove(Restaurant restaurant)
	{
		_restaurantDal.Delete(restaurant);
		return new SuccessResult("Restoran silindi");
	}

	public IResult Update(Restaurant restaurant)
	{
		_restaurantDal.Update(restaurant);
		return new SuccessResult("Restoran güncellendi");
	}
}