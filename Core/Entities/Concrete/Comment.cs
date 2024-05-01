using Core.Entities.Abstract;

namespace Core.Entities.Concrete
{
	public class Comment : IEntity
	{
		public int Id { get; set; }
		public string Content { get; set; }
		public Restaurant? Restaurant { get; set; }
		public Product? Product { get; set; }
		public User User { get; set; }
	}
}
