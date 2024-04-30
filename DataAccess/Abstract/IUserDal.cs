using Core.DataAccess;
using Core.Entities.Concrete;
using Entities.Concrete.DTOs.UserDto;

namespace DataAccess.Abstract;

public interface IUserDal : IEntityRepository<User>
{
	List<OperationClaim> GetUserClaims(User user);
	UserDetailDto GetUserDetails(User user);
	List<UserDetailDto> GetAllUserDetails();

}