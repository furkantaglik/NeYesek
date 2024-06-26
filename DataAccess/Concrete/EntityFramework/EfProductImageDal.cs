﻿using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfProductImageDal : EfEntityRepositoryBase<ProductImage, SqlContext>, IProductImageDal
	{
	}
}
