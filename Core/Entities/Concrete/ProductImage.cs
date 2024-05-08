using Core.Entities.Abstract;
namespace Core.Entities.Concrete
{
	public class ProductImage : IEntity
	{
		public int Id { get; set; }
		public string? ImagePath { get; set; }
		public Product Product { get; set; }
	}
}
