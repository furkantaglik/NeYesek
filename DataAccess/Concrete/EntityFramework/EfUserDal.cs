using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete.DTOs.UserDto;

namespace DataAccess.Concrete.EntityFramework;

public class EfUserDal : EfEntityRepositoryBase<User, SqlContext>, IUserDal
{
	public List<OperationClaim> GetUserClaims(User user)
	{
		using var context = new SqlContext();
		var result = from OperationClaim in context.OperationClaims
					 join UserOperationClaim in context.UserOperationClaims
					 on OperationClaim.Id equals UserOperationClaim.Id
					 where UserOperationClaim.user.Id == user.Id
					 select new OperationClaim { Id = OperationClaim.Id, Name = OperationClaim.Name, };
		return result.ToList();
	}

	public List<UserDetailDto> GetAllUserDetails()
	{
		using var context = new SqlContext();
		var result = from user in context.Users
					 select new UserDetailDto
					 {
						 Comments = user.Comments.ToList(),
						 User = user,

					 };

		return result.ToList();
	}

	public UserDetailDto GetUserDetails(User user)
	{
		using var context = new SqlContext();
		var result = from u in context.Users
					 where u.Id == user.Id
					 select new UserDetailDto
					 {
						 Comments = u.Comments.ToList(),
						 User = u,
					 };
		return result.FirstOrDefault();
	}
}