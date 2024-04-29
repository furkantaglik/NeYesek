using Core.Entities.Abstract;

namespace Core.Entities.Concrete
{
	public class Category : IEntity
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public List<Restaurant> Restaurants { get; set; }
		public List<Product> Products { get; set; }

	}
}
