using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Nurgo.Models;
using Repository.Models;
using Repository.Repository.ContentRepository;
using System.Collections.Generic;

namespace Nurgo.ViewComponents
{
	public class AdvantageViewComponent : ViewComponent
	{
		private readonly IMapper _mapper;
		private readonly IContentRepository _contentRepository;

		public AdvantageViewComponent(IMapper mapper, 
									  IContentRepository contentRepository)
		{
			_mapper = mapper;
			_contentRepository = contentRepository;
		}

		public IViewComponentResult Invoke()
		{
			var advantage = _contentRepository.GetAdvantages();
			var model = _mapper.Map<IEnumerable<Advantage>, IEnumerable<AdvantageViewModel>>(advantage);

			return View(model);
		}
	}
}
