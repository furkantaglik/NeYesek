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

			productImage.ImagePath = _fileHelper.Upload(file, PathConstant.ProductImagesPath);
			_productImageDal.Add(productImage);
			return new SuccessResult("Menü resmi eklendi");
		}

		public IDataResult<ProductImage> GetImageByProductId(int productId)
		{
			return new SuccessDataResult<ProductImage>(_productImageDal.Get(x => x.Product.Id == productId));
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
			_fileHelper.Delete(PathConstant.ProductImagesPath + productImage.ImagePath);
			_productImageDal.Delete(productImage);
			return new SuccessResult("Menü resmi silindi");
		}

		public IResult Update(IFormFile file, ProductImage productImage)
		{
			productImage.ImagePath = _fileHelper.Update(file, PathConstant.ProductImagesPath + productImage.ImagePath, PathConstant.ProductImagesPath);
			_productImageDal.Update(productImage);
			return new SuccessResult("Menü resmi güncellendi");
		}
	}
}
