using Core.Entities.Abstract;

namespace Entities.DTOs.Restaurant
{
	public class RestaurantForLoginDto : IDto
	{
		public string Email { get; set; }
		public string Password { get; set; }
	}
}
