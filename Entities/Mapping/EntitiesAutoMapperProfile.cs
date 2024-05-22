using AutoMapper;
using Core.Entities.Concrete;
using Entities.Concrete.DTOs.RestaurantDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Mapping
{
	public class EntitiesAutoMapperProfile : Profile
	{
		public EntitiesAutoMapperProfile()
		{
			CreateMap<RestaurantDetailDto, Restaurant>();
			CreateMap<Restaurant, RestaurantDetailDto>();
		}
	
    }
}
