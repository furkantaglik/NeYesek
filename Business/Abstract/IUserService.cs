using Core.Entities.Concrete;
using Core.Utilites.Results;
using Entities.Concrete.DTOs.UserDto;

namespace Business.Abstract
{
	public interface IUserService
	{
		IDataResult<List<User>> GetAll();
		List<UserOperationClaim> GetUserClaims();
		IDataResult<User> GetById(int Id);
		IResult Add(User user);
		IResult Remove(User user);
		IResult Update(User user);
	}
}
