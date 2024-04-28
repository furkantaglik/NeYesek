using Core.Entities.Concrete;
using Core.Utilites.Results;
using Core.Utilites.Security.Jwt;
using Entities.DTOs.Restaurant;
using Entities.DTOs.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface IAuthService
	{

		//User
		IDataResult<User> UserRegister(UserForRegisterDto userForRegisterDto, string password);
		IDataResult<User> UserLogin(UserForLoginDto userForLoginDto);
		IResult UserExists(string email);
		IDataResult<AccessToken> CreateAccessTokenForUser(User user);

		//Restaurant
		IDataResult<Restaurant> RestaurantRegister(RestaurantForRegisterDto restaurantForRegisterDto, string password);
		IDataResult<Restaurant> RestaurantLogin(RestaurantForLoginDto restaurantForLoginDto);
		IResult RestaurantExists(string email);
		IDataResult<AccessToken> CreateAccessTokenForRestaurant(Restaurant restaurant);


	}
}
