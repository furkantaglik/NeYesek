using Core.Entities.Abstract;
using Core.Entities.Concrete;

namespace Entities.Concrete.DTOs.UserDto
{
	public class UserDetailDto : IDto
	{
		public User User { get; set; }
		public List<Comment> Comments { get; set; }
	}
}
