using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilites.Results;
using Entities.Concrete.DTOs.UserDto;

namespace Business.Concrete
{
	public class UserManager : IUserService
	{
		public IResult Add(User user)
		{
			throw new NotImplementedException();
		}

		public IDataResult<List<User>> GetAll()
		{
			throw new NotImplementedException();
		}

		public IDataResult<User> GetById(int Id)
		{
			throw new NotImplementedException();
		}

		public List<UserOperationClaim> GetUserClaims()
		{
			throw new NotImplementedException();
		}

		public IResult Remove(User user)
		{
			throw new NotImplementedException();
		}

		public IResult Update(User user)
		{
			throw new NotImplementedException();
		}
	}
}
