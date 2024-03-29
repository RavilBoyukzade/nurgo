﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Nurgo.Models;
using Repository.Models;
using Repository.Repository.ContentRepository;
using System.Collections;
using System.Collections.Generic;

namespace Nurgo.ViewComponents
{
	public class SliderViewComponent :ViewComponent
	{
		private readonly IMapper _mapper;
		private readonly IContentRepository _contentRepository;

		public SliderViewComponent(IMapper mapper,
									IContentRepository contentRepository)
		{
			_mapper = mapper;
			_contentRepository = contentRepository;
		}

		public IViewComponentResult Invoke()
		{
			var sliderItems = _contentRepository.GetSliderItems();
			var model = _mapper.Map<IEnumerable<SliderItem>, IEnumerable<SliderItemViewModel>>(sliderItems);

			return View(model);
		}
	}
}
