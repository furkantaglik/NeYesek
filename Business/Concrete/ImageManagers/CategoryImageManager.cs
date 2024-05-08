﻿using Business.Abstract.ImageServices;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilites.FileHelper;
using Core.Utilites.Results;
using DataAccess.Abstract;
using Microsoft.AspNetCore.Http;

namespace Business.Concrete.ImageManagers
{
	public class CategoryImageManager : ICategoryImageService
	{
		private ICategoryImageDal _categoryImageDal;
		private IFileHelper _fileHelper;
		public CategoryImageManager(ICategoryImageDal categoryImageDal, IFileHelper fileHelper)
		{
			_categoryImageDal = categoryImageDal;
			_fileHelper = fileHelper;
		}

		public IResult Add(IFormFile file, CategoryImage categoryImage)
		{

			categoryImage.ImagePath = _fileHelper.Upload(file, PathConstant.CategoryImagesPath);
			_categoryImageDal.Add(categoryImage);
			return new SuccessResult("Menü resmi eklendi");
		}

		public IDataResult<CategoryImage> GetImageByCategoryId(int categoryId)
		{
			return new SuccessDataResult<CategoryImage>(_categoryImageDal.Get(x => x.Category.Id == categoryId));
		}

		public IDataResult<List<CategoryImage>> GetAll()
		{
			return new SuccessDataResult<List<CategoryImage>>(_categoryImageDal.GetAll());
		}

		public IDataResult<CategoryImage> GetByImageId(int id)
		{
			return new SuccessDataResult<CategoryImage>(_categoryImageDal.Get(x => x.Id == id));
		}

		public IResult Remove(CategoryImage categoryImage)
		{
			_fileHelper.Delete(PathConstant.CategoryImagesPath + categoryImage.ImagePath);
			_categoryImageDal.Delete(categoryImage);
			return new SuccessResult("Menü resmi silindi");
		}

		public IResult Update(IFormFile file, CategoryImage categoryImage)
		{
			categoryImage.ImagePath = _fileHelper.Update(file, PathConstant.CategoryImagesPath + categoryImage.ImagePath, PathConstant.CategoryImagesPath);
			_categoryImageDal.Update(categoryImage);
			return new SuccessResult("Menü resmi güncellendi");
		}
	}
}