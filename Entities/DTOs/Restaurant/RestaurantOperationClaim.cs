using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.Restaurant
{
	public class RestaurantOperationClaim:IEntity
	{
		public int Id { get; set; }
		public int RestaurantId { get; set; }
		public int OperationClaimId { get; set; }
	}
}
