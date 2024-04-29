using Core.Entities.Abstract;

namespace Entities.Concrete.DTOs.UserDto
{
	public class UserForRegisterDto : IDto
	{
		public string Email { get; set; }
		public string Password { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Adress { get; set; }
		public string TelNo { get; set; }
	}
}
