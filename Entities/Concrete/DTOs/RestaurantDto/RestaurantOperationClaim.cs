using Core.Entities.Concrete;

namespace Entities.Concrete.DTOs.RestaurantDto
{
	public class RestaurantOperationClaim
	{
		public int Id { get; set; }
		public Restaurant Restaurant { get; set; }
		public OperationClaim OperationClaim { get; set; }
	}
}
