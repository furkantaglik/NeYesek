using Core.Entities.Abstract;

namespace Entities.Concrete.DTOs.UserDto
{
	public class UserForLoginDto : IDto
	{
		public string Email { get; set; }
		public string Password { get; set; }
	}
}
