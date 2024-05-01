using Core.Entities.Abstract;

namespace Core.Entities.Concrete
{
	public class Menu : IEntity
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal TotalPrice { get; set; }
		public Restaurant Restaurant { get; set; }
		public List<Product>? Products { get; set; }
		public virtual List<ProductMenu> ProductMenu { get; set; }
	}
}
