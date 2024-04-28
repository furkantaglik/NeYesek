﻿using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
	public class Product :IEntity
	{
		public int Id { get; set; }
        public string Name { get; set; }
		public decimal UnitPrice { get; set; }
		public int UnitsInStock { get; set; }
        public int CategoryId { get; set; }
		public int RestaurantId { get; set; }

	}
}
