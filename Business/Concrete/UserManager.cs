using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilites.Results;
using DataAccess.Abstract;
using Entities.Concrete.DTOs.UserDto;

namespace Business.Concrete
{
	public class UserManager : IUserService
	{
		IUserDal _userDal;
		public UserManager(IUserDal userDal)
		{
			_userDal = userDal;
		}

		public IResult Add(User user)
		{
			_userDal.Add(user);
			return new SuccessResult("Kullanıcı eklendi");
		}

		public IDataResult<List<User>> GetAll()
		{
			var data = _userDal.GetAll();
			return new SuccessDataResult<List<User>>(data);
		}

		public IDataResult<List<UserDetailDto>> GetAllUserDetails()
		{
			var data = _userDal.GetAllUserDetails();
			return new SuccessDataResult<List<UserDetailDto>>(data);
		}

		public IDataResult<User> GetById(int Id)
		{
			var data = _userDal.Get(u => u.Id == Id);
			return new SuccessDataResult<User>(data);
		}

		public IDataResult<User> GetByMail(string Email)
		{
			var data = _userDal.Get(u => u.Email == Email);
			return new SuccessDataResult<User>(data);
		}

		public List<OperationClaim> GetUserClaims(User user)
		{
			return _userDal.GetUserClaims(user);
		}

		public IDataResult<UserDetailDto> GetUserDetail(int userId)
		{
			var data = _userDal.GetUserDetail(userId);
			return new SuccessDataResult<UserDetailDto>(data);
		}

		public IResult Remove(User user)
		{
			_userDal.Delete(user);
			return new SuccessResult("Kullanıcı silindi");
		}

		public IResult Update(User user)
		{
			_userDal.Update(user);
			return new SuccessResult("Kullanıcı güncellendi");
		}
	}
}
