using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;

namespace DataAccess.Concrete.EntityFramework;

public class EfUserDal : EfEntityRepositoryBase<User, SqlContext>, IUserDal
{
	//public List<OperationClaim> GetUserClaims(User user)
	//{
	//	using (var context = new SqlContext())
	//	{
	//		var result = from OperationClaim in context.OperationClaims
	//					 join UserOperationClaim in context.UserOperationClaims
	//					 on OperationClaim.Id equals UserOperationClaim.Id
	//					 where UserOperationClaim.UserId == user.Id
	//					 select new OperationClaim { Id = OperationClaim.Id, Name = OperationClaim.Name, };
	//		return result.ToList();
	//	}
	//}
}