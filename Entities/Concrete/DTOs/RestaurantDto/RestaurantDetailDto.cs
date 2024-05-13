using Core.Entities.Abstract;
using Core.Entities.Concrete;

namespace Entities.Concrete.DTOs.RestaurantDto
{
	public class RestaurantDetailDto : IDto
	{
		public Restaurant Restaurant { get; set; }
		public List<Comment> Comments { get; set; }
		public List<Menu> Menus { get; set; }
		public List<Product> Products { get; set; }
		public List<Category> Categories { get; set; }
		public RestaurantImage RestaurantImage { get; set; }

	}
}
