using Core.Entities.Abstract;

namespace Entities.Concrete.DTOs.RestaurantDto
{
	public class RestaurantForRegisterDto : IDto
	{
		public string Name { get; set; }
		public string Email { get; set; }
		public string Adress { get; set; }
		public string TelNo { get; set; }
		public string Password { get; set; }
	}
}
