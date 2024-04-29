using Core.Entities.Abstract;
using Core.Entities.Concrete;

namespace Entities.Concrete.DTOs.ProductDto
{
	public class ProductDetailDto : IDto
	{
		public List<Category> Categories { get; set; }
		public Restaurant Restaurant { get; set; }
		public Product Product { get; set; }
	}
}
