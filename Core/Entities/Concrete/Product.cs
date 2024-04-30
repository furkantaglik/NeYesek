using Core.Entities.Abstract;

namespace Core.Entities.Concrete
{
	public class Product : IEntity
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public decimal UnitPrice { get; set; }
		public int UnitsInStock { get; set; }
		public List<Category> Categories { get; set; }
		public List<Comment> Comments { get; set; }
		public Restaurant Restaurant { get; set; }
	}
}
