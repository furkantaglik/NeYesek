using Core.Entities.Abstract;

namespace Core.Entities.Concrete
{
	public class RestaurantImage : IEntity
	{
		public int Id { get; set; }
		public string? ImagePath { get; set; }
		public int? RestaurantId { get; set; }
		public Restaurant? Restaurant { get; set; }
	}
}
