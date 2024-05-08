using Business.Abstract.ImageServices;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilites.FileHelper;
using Core.Utilites.Results;
using DataAccess.Abstract;
using Microsoft.AspNetCore.Http;

namespace Business.Concrete.ImageManagers
{
	public class ProductImageManager : IProductImageService
	{
		private IProductImageDal _productImageDal;
		private IFileHelper _fileHelper;
		public ProductImageManager(IProductImageDal productImageDal, IFileHelper fileHelper)
		{
			_productImageDal = productImageDal;
			_fileHelper = fileHelper;
		}

		public IResult Add(IFormFile file, ProductImage productImage)
		{
			productImage.ImagePath = _fileHelper.Upload(file, PathConstant.ProductImagesPath + productImage.Product.Id + "\\");
			_productImageDal.Add(productImage);
			return new SuccessResult("Ürün resmi eklendi");
		}

		public IDataResult<ProductImage> GetImageByProductId(int categoryId)
		{
			return new SuccessDataResult<ProductImage>(_productImageDal.Get(x => x.Product.Id == categoryId));
		}

		public IDataResult<List<ProductImage>> GetAll()
		{
			return new SuccessDataResult<List<ProductImage>>(_productImageDal.GetAll());
		}

		public IDataResult<ProductImage> GetByImageId(int id)
		{
			return new SuccessDataResult<ProductImage>(_productImageDal.Get(x => x.Id == id));
		}

		public IResult Remove(ProductImage productImage)
		{
			_fileHelper.Delete(PathConstant.RestaurantImagesPath + productImage.Product.Id + "\\" + productImage.ImagePath);
			_productImageDal.Delete(productImage);
			return new SuccessResult("Ürün resmi silindi");
		}

		public IResult Update(IFormFile file, ProductImage productImage)
		{
			productImage.ImagePath = _fileHelper.Update(file, PathConstant.RestaurantImagesPath + productImage.Product.Id + "\\" + productImage.ImagePath, PathConstant.ProductImagesPath + productImage.Product.Id + "\\");
			_productImageDal.Update(productImage);
			return new SuccessResult("Ürün resmi güncellendi");
		}
	}
}
