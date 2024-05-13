using Core.Entities.Abstract;

namespace Core.Entities.Concrete
{
	public class MenuImage : IEntity
	{
		public int Id { get; set; }
		public string? ImagePath { get; set; }
		public int? MenuId { get; set; }
		public Menu? Menu { get; set; }
	}
}
