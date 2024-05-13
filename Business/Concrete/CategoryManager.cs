using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilites.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete.DTOs.CategoryDto;

namespace Business.Concrete;

public class CategoryManager : ICategoryService
{
	ICategoryDal _categoryDal;
	ICategoryImageDal _categoryImageDal;
	public CategoryManager(ICategoryDal categoryDal, ICategoryImageDal categoryImageDal)
	{
		_categoryDal = categoryDal;
		_categoryImageDal = categoryImageDal;
	}

	public IResult Add(Category category)
	{
		_categoryDal.Add(category);
		if (category.CategoryImage != null)
		{
			category.CategoryImage.CategoryId = category.Id;
			category.CategoryImage.Category = category;
			_categoryImageDal.Add(category.CategoryImage);
		}
		return new SuccessResult("Kategori Eklendi");
	}

	public IDataResult<List<Category>> GetAll()
	{
		var data = _categoryDal.GetAll();
		return new SuccessDataResult<List<Category>>(data);
	}

	public IDataResult<List<CategoryDetailDto>> GetAllCategoryDetails()
	{
		var data = _categoryDal.GetAllCategoryDetails();
		return new SuccessDataResult<List<CategoryDetailDto>>(data);
	}

	public IDataResult<Category> GetById(int Id)
	{
		var data = _categoryDal.Get(p => p.Id == Id);
		return new SuccessDataResult<Category>(data);
	}

	public IDataResult<CategoryDetailDto> GetCategoryDetail(int categoryId)
	{
		var data = _categoryDal.GetCategoryDetail(categoryId);
		return new SuccessDataResult<CategoryDetailDto>(data);
	}

	public IDataResult<List<CategoryDetailDto>> GetCategoryDetailsByProduct(int productId)
	{
		var data = _categoryDal.GetCategoryDetailsByProduct(productId);
		return new SuccessDataResult<List<CategoryDetailDto>>(data);
	}

	public IDataResult<List<CategoryDetailDto>> GetCategoryDetailsByResturant(int restaurantId)
	{
		var data = _categoryDal.GetCategoryDetailsByRestaurant(restaurantId);
		return new SuccessDataResult<List<CategoryDetailDto>>(data);
	}

	public IResult Remove(Category category)
	{
		_categoryDal.Delete(category);
		return new SuccessResult("Kategori silindi");
	}

	public IResult Update(Category category)
	{
		_categoryDal.Update(category);
		if (category.CategoryImage != null)
		{
			category.CategoryImage.CategoryId = category.Id;
			category.CategoryImage.Category = category;
			_categoryImageDal.Add(category.CategoryImage);
		}
		return new SuccessResult("Kategori Güncellendi");
	}
}