using Core.Utilites.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	internal interface ICommentService
	{
		IDataResult<List<Comment>> GetList();
		IDataResult<List<Comment>> GetByRestaurantId(int Id);
		IDataResult<Comment> GetById(int Id);
		IResult Add(Comment comment);
		IResult Remove(Comment comment);
		IResult Update(Comment comment);
	}
}
