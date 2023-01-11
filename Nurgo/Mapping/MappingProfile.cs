using AutoMapper;
using Nurgo.Models;
using Repository.Models;
using System.Linq;

namespace Nurgo.Mapping
{
	public class MappingProfile:Profile
	{
		public MappingProfile() 
		{
			CreateMap<SliderItem, SliderItemViewModel>();
			CreateMap<Advantage, AdvantageViewModel>();
			CreateMap<Product,LastAddedViewModel>()
				.ForMember(d=>d.Photos,opt=>opt
				.MapFrom(src=>src.Photos.OrderBy(p=>p.OrderBy)
										.Select(p=>p.Image)));
			CreateMap<Product, ProductViewModel>()
				.ForMember(d => d.Photos, opt => opt
				.MapFrom(src => src.Photos.OrderBy(p => p.OrderBy)
										.Select(p => p.Image)))
                .ForMember(d => d.Futures, opt => opt
                .MapFrom(src => src.Futures.Select(p => p.Future)));
			CreateMap<Setting, SettingViewModel>();
				
		}
	}
}
