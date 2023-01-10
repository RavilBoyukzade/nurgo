using AutoMapper;
using Admin.Models;
using Repository.Models;
using System.Linq;
using Admin.Models.Addings;
using Admin.Models.Product;

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
			CreateMap<Product, ProductViewModel>();
			CreateMap<ProductPhoto, ProductPhotoViiewModel>();
			CreateMap<ProductVideo, ProductVideoViewModel>();
			CreateMap<ProductFuture, ProductFutureViewModel>();


        }
	}
}
