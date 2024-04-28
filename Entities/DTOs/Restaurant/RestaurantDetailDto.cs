using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.Restaurant
{
	public class RestaurantDetailDto:IDto
	{
        public int RestrauntId { get; set; }
        public string Name { get; set; }
        public string TelNo { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public List<String> Comments  { get; set; }
    }
}
