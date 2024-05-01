using Core.Entities.Abstract;

namespace Core.Entities.Concrete
{
	public class ProductMenu : IEntity
	{
		public int MenuId { get; set; }
		public int ProductId { get; set; }
		public Menu Menu { get; set; }
		public Product Product { get; set; }
	}
}
