using Core.Entities.Concrete;
using Core.Utilites.Results;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract.ImageServices
{
	public interface IMenuImageService
	{
		IDataResult<List<MenuImage>> GetAll();
		IDataResult<MenuImage> GetByImageId(int id);
		IDataResult<MenuImage> GetImageByMenuId(int menuId);
		IDataResult<MenuImage> Add(IFormFile file, MenuImage menuImage);
		IDataResult<MenuImage> Update(IFormFile file, MenuImage menuImage);
		IResult Remove(MenuImage menuImage);
	}
}
