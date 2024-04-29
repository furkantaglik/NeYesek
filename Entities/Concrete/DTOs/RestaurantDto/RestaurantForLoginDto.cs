using Core.Entities.Abstract;

namespace Entities.Concrete.DTOs.RestaurantDto
{
	public class RestaurantForLoginDto : IDto
	{
		public string Email { get; set; }
		public string Password { get; set; }
	}
}
