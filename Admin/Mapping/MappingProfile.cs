using AutoMapper;
using Admin.Models;
using Repository.Models;
using System.Linq;
using Admin.Models.Addings;

namespace Nurgo.Mapping
{
	public class MappingProfile:Profile
	{
		public MappingProfile() 
		{
			CreateMap<SliderItem, SliderItemViewModel>();
            CreateMap<SliderItemViewModel,SliderItem>();
			CreateMap<Advantage, AdvantageViewModel>();
            CreateMap<AdvantageViewModel, Advantage>();


        }
	}
}
