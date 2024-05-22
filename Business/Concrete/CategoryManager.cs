using AutoMapper;
using AutoMapper.Configuration.Annotations;
using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilites.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete.DTOs.CategoryDto;
using Microsoft.EntityFrameworkCore;

namespace Business.Concrete;

public class CategoryManager : ICategoryService
{
	ICategoryDal _categoryDal;
	ICategoryImageDal _categoryImageDal;
	IRestaurantDal _restaurantDal;
	private readonly IRestaurantService _restaurantService;
	private readonly IMapper _mapper;
	public CategoryManager(ICategoryDal categoryDal, ICategoryImageDal categoryImageDal, IRestaurantDal restaurantDal, IRestaurantService restaurantService, IMapper mapper)
	{
		_categoryDal = categoryDal;
		_categoryImageDal = categoryImageDal;
		_restaurantDal = restaurantDal;
		_restaurantService = restaurantService;
		_mapper = mapper;
	}

	public IDataResult<Category> Add(Category category)
	{
		_categoryDal.Add(category);

		if (category.CategoryImage != null)
		{
			category.CategoryImage.CategoryId = category.Id;
			category.CategoryImage.Category = category;
			_categoryImageDal.Add(category.CategoryImage);
		}
		//if (category.Restaurants != null)
		//{
		//	category.Restaurants[0].Categories.Add(category);
		//	_restaurantService.Update(category.Restaurants[0]);
		//}

		return new SuccessDataResult<Category>(category,"Kategori Eklendi");

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
		if(category.Restaurants != null)
		{
			category.Restaurants.Add(category.Restaurants[0]);
			_restaurantDal.Update(category.Restaurants[0]);
		
		}
		return new SuccessResult("Kategori Güncellendi");
	}
}