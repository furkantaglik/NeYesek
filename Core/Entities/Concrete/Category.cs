using Core.Entities.Abstract;
using System.Text.Json.Serialization;

namespace Core.Entities.Concrete
{
	public class Category : IEntity
	{
		public int Id { get; set; }
		public string Name { get; set; }	
		public List<Restaurant>? Restaurants { get; set; }
		public List<Product>? Products { get; set; }
		[JsonIgnore]
		public CategoryImage? CategoryImage { get; set; }

	}
}
