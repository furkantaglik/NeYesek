using Core.Entities.Abstract;
using Core.Entities.Concrete;

namespace Entities.Concrete.DTOs.RestaurantDto
{
	public class RestaurantUpdateDto : IDto
	{
		public int Id { get; set; }
		public string name { get; set; }
		public string email { get; set; }
		public string Adress { get; set; }
		public string telNo { get; set; }
		public RestaurantImage RestaurantImage { get; set; }
	}
}
