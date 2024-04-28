using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
	public  class Menu:IEntity
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public  decimal TotalPrice { get; set; }
        public int RestaurantId { get; set; }
        public List<Product> Products { get; set; }
    }
}
