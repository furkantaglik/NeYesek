using Core.Entities.Abstract;
using Core.Entities.Concrete;

namespace Entities.Concrete.DTOs.MenuDto
{
	public class MenuDetailDto : IDto
	{
		public List<Product> products { get; set; }
		public Restaurant restaurant { get; set; }
		public Menu menu { get; set; }
	}
}
