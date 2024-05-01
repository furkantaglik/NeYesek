using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilites.Results;
using Core.Utilites.Security.Hashing;
using Core.Utilites.Security.Jwt;
using Entities.Concrete.DTOs.RestaurantDto;
using Entities.Concrete.DTOs.UserDto;

namespace Business.Concrete;

public class AuthManager : IAuthService
{
	private IUserService _userService;
	private IRestaurantService _restaurantService;
	private ITokenHelper _tokenHelper;
	public AuthManager(IUserService userService, IRestaurantService restaurantService, ITokenHelper tokenHelper)
	{
		_userService = userService;
		_restaurantService = restaurantService;
		_tokenHelper = tokenHelper;
	}

	public IDataResult<AccessToken> CreateAccessTokenForRestaurant(Restaurant restaurant)
	{
		var claims = _restaurantService.GetRestaurantClaims(restaurant);
		var accessToken = _tokenHelper.CreateToken(restaurant, claims);
		return new SuccessDataResult<AccessToken>(accessToken, "Token oluşturuldu");
	}

	public IDataResult<AccessToken> CreateAccessTokenForUser(User user)
	{
		var claims = _userService.GetUserClaims(user);
		var accessToken = _tokenHelper.CreateToken(user, claims);
		return new SuccessDataResult<AccessToken>(accessToken, "Token oluşturuldu");
	}

	public IResult RestaurantExists(string email)
	{
		if (_restaurantService.GetByMail(email) != null)
		{
			return new ErrorDataResult<Restaurant>("Restorant zaten mevcut");
		}
		return new SuccessResult();
	}

	public IDataResult<Restaurant> RestaurantLogin(RestaurantForLoginDto restaurantForLoginDto)
	{
		var restaurantToCheck = _restaurantService.GetByMail(restaurantForLoginDto.Email);

		if (restaurantToCheck == null)
		{
			return new ErrorDataResult<Restaurant>("Restorant Bulunamadı");
		}
		if (!HashingHelper.VerifyPasswordHash(restaurantForLoginDto.Password, restaurantToCheck.Data.PasswordHash, restaurantToCheck.Data.PasswordSalt))
		{
			return new ErrorDataResult<Restaurant>("Parola Yanlış");
		}
		return new SuccessDataResult<Restaurant>(restaurantToCheck.Data, "Giriş Başarılı");
	}

	public IDataResult<Restaurant> RestaurantRegister(RestaurantForRegisterDto restaurantForRegisterDto,
		string password)
	{
		byte[] passwordHash, passwordSalt;
		HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
		var restaurant = new Restaurant
		{
			Email = restaurantForRegisterDto.Email,
			Name = restaurantForRegisterDto.Name,
			TelNo = restaurantForRegisterDto.TelNo,
			Adress = restaurantForRegisterDto.Adress,
			PasswordHash = passwordHash,
			PasswordSalt = passwordSalt,
			Status = true

		};
		_restaurantService.Add(restaurant);
		return new SuccessDataResult<Restaurant>(restaurant, "Kayıt olundu");
	}

	public IResult UserExists(string email)
	{
		if (_userService.GetByMail(email) != null)
		{
			return new ErrorDataResult<User>("Kullanıcı zaten mevcut");
		}
		return new SuccessResult();
	}

	public IDataResult<User> UserLogin(UserForLoginDto userForLoginDto)
	{
		var userToCheck = _userService.GetByMail(userForLoginDto.Email);

		if (userToCheck == null)
		{
			return new ErrorDataResult<User>("Kullanıcı Bulunamadı");
		}
		if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.Data.PasswordHash, userToCheck.Data.PasswordSalt))
		{
			return new ErrorDataResult<User>("Parola Yanlış");
		}
		return new SuccessDataResult<User>(userToCheck.Data, "Giriş Başarılı");
	}

	public IDataResult<User> UserRegister(UserForRegisterDto userForRegisterDto, string password)
	{
		byte[] passwordHash, passwordSalt;
		HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
		var user = new User
		{
			Email = userForRegisterDto.Email,
			FirstName = userForRegisterDto.FirstName,
			LastName = userForRegisterDto.LastName,
			TelNo = userForRegisterDto.TelNo,
			Adress = userForRegisterDto.Adress,
			PasswordHash = passwordHash,
			PasswordSalt = passwordSalt,
			Status = true

		};
		_userService.Add(user);
		return new SuccessDataResult<User>(user, "Kayıt olundu");
	}
}