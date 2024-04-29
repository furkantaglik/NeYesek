using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;

namespace DataAccess.Concrete.EntityFramework;

public class EfRestaurantDal : EfEntityRepositoryBase<Restaurant, SqlContext>, IRestaurantDal
{
	//public List<OperationClaim> GetRestaurantClaims(Restaurant restaurant)
	//{
	//	using (var context = new SqlContext())
	//	{
	//		var result = from OperationClaim in context.OperationClaims
	//					 join RestaurantOperationClaim in context.RestaurantOperationClaims
	//					 on OperationClaim.Id equals RestaurantOperationClaim.Id
	//					 where RestaurantOperationClaim.RestaurantId == restaurant.Id
	//					 select new OperationClaim { Id = OperationClaim.Id, Name = OperationClaim.Name, };
	//		return result.ToList();
	//	}
	//}

	//public List<RestaurantDetailDto> GetRestaurantDetails()
	//{
	//	using var context = new SqlContext();
	//	var result = from r in context.Restaurants
	//				 join c in context.Comments on r.Id equals c.RestaurantId
	//				 join m in context.Menus on r.Id equals m.RestaurantId
	//				 join p in context.Products on r.Id equals p.RestaurantId
	//				 group new { r, c, m } by new { r.Id, r.Name, r.TelNo, r.Email, r.Adress } into grouped
	//				 select new RestaurantDetailDto
	//				 {
	//					 RestrauntId = grouped.Key.Id,
	//					 Name = grouped.Key.Name,
	//					 TelNo = grouped.Key.TelNo,
	//					 Email = grouped.Key.Email,
	//					 Adress = grouped.Key.Adress,
	//					 Menus = grouped.Select(g => g.m).ToList(),
	//					 Comments = grouped.Select(g => g.c).ToList()
	//				 };
	//	return result.ToList();
	//}
}