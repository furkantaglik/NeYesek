﻿using Business.Abstract.ImageServices;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilites.FileHelper;
using Core.Utilites.Results;
using DataAccess.Abstract;
using Microsoft.AspNetCore.Http;

namespace Business.Concrete.ImageManagers
{
	public class MenuImageManager : IMenuImageService
	{
		private IMenuImageDal _menuImageDal;
		private IFileHelper _fileHelper;
		public MenuImageManager(IMenuImageDal menuImageDal, IFileHelper fileHelper)
		{
			_menuImageDal = menuImageDal;
			_fileHelper = fileHelper;
		}

		public IResult Add(IFormFile file, MenuImage menuImage)
		{

			menuImage.ImagePath = _fileHelper.Upload(file, PathConstant.MenuImagesPath);
			_menuImageDal.Add(menuImage);
			return new SuccessResult("Menü resmi eklendi");
		}
		public IResult AddMenuEntity(MenuImage menuImage)
		{
			_menuImageDal.Add(menuImage);
			return new SuccessResult();
		}

		public IDataResult<MenuImage> GetImageByMenuId(int menuId)
		{
			return new SuccessDataResult<MenuImage>(_menuImageDal.Get(x => x.Menu.Id == menuId));
		}

		public IDataResult<List<MenuImage>> GetAll()
		{
			return new SuccessDataResult<List<MenuImage>>(_menuImageDal.GetAll());
		}

		public IDataResult<MenuImage> GetByImageId(int id)
		{
			return new SuccessDataResult<MenuImage>(_menuImageDal.Get(x => x.Id == id));
		}

		public IResult Remove(MenuImage menuImage)
		{
			_fileHelper.Delete(PathConstant.MenuImagesPath + menuImage.ImagePath);
			_menuImageDal.Delete(menuImage);
			return new SuccessResult("Menü resmi silindi");
		}

		public IResult Update(IFormFile file, MenuImage menuImage)
		{
			menuImage.ImagePath = _fileHelper.Update(file, PathConstant.MenuImagesPath +  menuImage.ImagePath, PathConstant.MenuImagesPath);
			_menuImageDal.Update(menuImage);
			return new SuccessResult("Menü resmi güncellendi");
		}
	}
}
