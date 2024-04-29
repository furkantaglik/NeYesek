using Core.Entities.Abstract;

namespace Core.Entities.Concrete;

public class Restaurant : IEntity
{
	public int Id { get; set; }
	public string Name { get; set; }
	public string Email { get; set; }
	public string Adress { get; set; }
	public string TelNo { get; set; }
	public byte[] PasswordSalt { get; set; }
	public byte[] PasswordHash { get; set; }
	public bool Status { get; set; }
	public List<Comment> Comments { get; set; }
	public List<Category> Categories { get; set; }
	public List<Product> Products { get; set; }

}