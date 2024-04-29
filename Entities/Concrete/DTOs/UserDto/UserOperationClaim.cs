using Core.Entities.Abstract;
using Core.Entities.Concrete;

namespace Entities.Concrete.DTOs.UserDto
{
	public class UserOperationClaim : IEntity
	{
		public int Id { get; set; }
		public User user { get; set; }
		public OperationClaim OperationClaim { get; set; }
	}
}
