using Core.Entities.Abstract;
using Core.Entities.Concrete;

namespace Entities.Concrete.DTOs.MenuDto
{
	public class MenuDetailDto : IDto
	{
		public List<Product> products { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal TotalPrice { get; set; }
	}
}
