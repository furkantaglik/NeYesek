using Business.Abstract;
using Core.Utilites.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class CommentManager : ICommentService
	{
		public IResult Add(Comment comment)
		{
			throw new NotImplementedException();
		}

		public IDataResult<Comment> GetById(int Id)
		{
			throw new NotImplementedException();
		}

		public IDataResult<List<Comment>> GetByRestaurantId(int Id)
		{
			throw new NotImplementedException();
		}

		public IDataResult<List<Comment>> GetList()
		{
			throw new NotImplementedException();
		}

		public IResult Remove(Comment comment)
		{
			throw new NotImplementedException();
		}

		public IResult Update(Comment comment)
		{
			throw new NotImplementedException();
		}
	}
}
