using Business.Abstract.ImageServices;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilites.FileHelper;
using Core.Utilites.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
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

		public IDataResult<CategoryImage> Add(IFormFile file, CategoryImage categoryImage)
		{

			categoryImage.ImagePath = _fileHelper.Upload(file, PathConstant.CategoryImagesPath);
			_categoryImageDal.Add(categoryImage);
			var data = _categoryImageDal.Get(c => c.Id == categoryImage.Id);
			return new SuccessDataResult<CategoryImage>(data, "Kategori resmi eklendi");
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
			return new SuccessResult("Kategori resmi silindi");
		}

		public IDataResult<CategoryImage> Update(IFormFile file, CategoryImage categoryImage)
		{
			categoryImage.ImagePath = _fileHelper.Update(file, PathConstant.CategoryImagesPath + categoryImage.ImagePath, PathConstant.CategoryImagesPath);
			_categoryImageDal.Update(categoryImage);
			var data = _categoryImageDal.Get(c => c.Id == categoryImage.Id);
			return new SuccessDataResult<CategoryImage>(data, "Kategori resmi güncellendi");
		}
	}
}
