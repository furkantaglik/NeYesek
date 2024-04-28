using Business.Abstract;
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

namespace Business.Concrete
{
	public class AuthManager : IAuthService
	{
		public IDataResult<AccessToken> CreateAccessTokenForRestaurant(Restaurant restaurant)
		{
			throw new NotImplementedException();
		}

		public IDataResult<AccessToken> CreateAccessTokenForUser(User user)
		{
			throw new NotImplementedException();
		}

		public IResult RestaurantExists(string email)
		{
			throw new NotImplementedException();
		}

		public IDataResult<Restaurant> RestaurantLogin(RestaurantForLoginDto restaurantForLoginDto)
		{
			throw new NotImplementedException();
		}

		public IDataResult<Restaurant> RestaurantRegister(RestaurantForRegisterDto restaurantForRegisterDto, string password)
		{
			throw new NotImplementedException();
		}

		public IResult UserExists(string email)
		{
			throw new NotImplementedException();
		}

		public IDataResult<User> UserLogin(UserForLoginDto userForLoginDto)
		{
			throw new NotImplementedException();
		}

		public IDataResult<User> UserRegister(UserForRegisterDto userForRegisterDto, string password)
		{
			throw new NotImplementedException();
		}
	}
}
