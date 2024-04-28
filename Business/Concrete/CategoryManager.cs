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
	public class CategoryManager : ICategoryService
	{
		public IResult Add(Category category)
		{
			throw new NotImplementedException();
		}

		public IDataResult<Category> GetById(int Id)
		{
			throw new NotImplementedException();
		}

		public IDataResult<List<Category>> GetList()
		{
			throw new NotImplementedException();
		}

		public IResult Remove(Category category)
		{
			throw new NotImplementedException();
		}

		public IResult Update(Category category)
		{
			throw new NotImplementedException();
		}
	}
}
