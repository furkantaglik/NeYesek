using Core.Entities.Abstract;
using Core.Entities.Concrete;

namespace Entities.Concrete.DTOs.CategoryDto
{
	public class CategoryDetailDto : IDto
	{
		public List<Product> Products { get; set; }
		public List<Restaurant> Restaurants { get; set; }
	}
}
