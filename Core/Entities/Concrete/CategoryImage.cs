using Core.Entities.Abstract;

namespace Core.Entities.Concrete
{
	public class CategoryImage : IEntity
	{
		public int Id { get; set; }
		public string? ImagePath { get; set; }
		public Category Category { get; set; }
	}
}
