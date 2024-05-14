using Business.Abstract.ImageServices;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilites.FileHelper;
using Core.Utilites.Results;
using DataAccess.Abstract;
using Microsoft.AspNetCore.Http;

namespace Business.Concrete.ImageManagers
{
	public class RestaurantImageManager : IRestaurantImageService
	{
		private IRestaurantImageDal _restaurantImageDal;
		private IFileHelper _fileHelper;
		public RestaurantImageManager(IRestaurantImageDal restaurantImageDal, IFileHelper fileHelper)
		{
			_restaurantImageDal = restaurantImageDal;
			_fileHelper = fileHelper;
		}

		public IDataResult<RestaurantImage> Add(IFormFile file, RestaurantImage restaurantImage)
		{

			restaurantImage.ImagePath = _fileHelper.Upload(file, PathConstant.RestaurantImagesPath);
			_restaurantImageDal.Add(restaurantImage);
			var data = _restaurantImageDal.Get(r => r.Id == restaurantImage.Id);
			return new SuccessDataResult<RestaurantImage>(data, "Restoran resmi eklendi");

		}

		public IDataResult<RestaurantImage> GetImageByRestaurantId(int restaurantId)
		{
			return new SuccessDataResult<RestaurantImage>(_restaurantImageDal.Get(x => x.Restaurant.Id == restaurantId));
		}

		public IDataResult<List<RestaurantImage>> GetAll()
		{
			return new SuccessDataResult<List<RestaurantImage>>(_restaurantImageDal.GetAll());
		}

		public IDataResult<RestaurantImage> GetByImageId(int id)
		{
			return new SuccessDataResult<RestaurantImage>(_restaurantImageDal.Get(x => x.Id == id));
		}

		public IResult Remove(RestaurantImage restaurantImage)
		{
			_fileHelper.Delete(PathConstant.RestaurantImagesPath + restaurantImage.ImagePath);
			_restaurantImageDal.Delete(restaurantImage);
			return new SuccessResult("Restoran resmi silindi");
		}

		public IDataResult<RestaurantImage> Update(IFormFile file, RestaurantImage restaurantImage)
		{
			restaurantImage.ImagePath = _fileHelper.Update(file, PathConstant.RestaurantImagesPath + restaurantImage.ImagePath, PathConstant.RestaurantImagesPath);
			_restaurantImageDal.Update(restaurantImage);
			var data = _restaurantImageDal.Get(r => r.Id == restaurantImage.Id);
			return new SuccessDataResult<RestaurantImage>(data, "Restoran resmi güncellendi");
		}
	}
}
