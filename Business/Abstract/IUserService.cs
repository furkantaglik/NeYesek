using Core.Entities.Concrete;
using Core.Utilites.Results;
using Entities.Concrete.DTOs.UserDto;

namespace Business.Abstract
{
	public interface IUserService
	{
		List<OperationClaim> GetUserClaims(User user);
		IDataResult<UserDetailDto> GetUserDetail(int userId);
		IDataResult<List<UserDetailDto>> GetAllUserDetails();

		IDataResult<List<User>> GetAll();
		IDataResult<User> GetByMail(string Email);
		IDataResult<User> GetById(int Id);
		IResult Add(User user);
		IResult Remove(User user);
		IResult Update(User user);
	}
}
