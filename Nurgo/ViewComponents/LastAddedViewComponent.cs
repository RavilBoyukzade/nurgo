using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Nurgo.Models;
using Repository.Models;
using Repository.Repository.ProductRepository;
using System.Collections;
using System.Collections.Generic;

namespace Nurgo.ViewComponents
{
	public class LastAddedViewComponent :ViewComponent
	{
		private readonly IMapper _mapper;
		private readonly IProductRepository _productRepository;

		public LastAddedViewComponent(IMapper mapper, IProductRepository productRepository)
		{
			_mapper = mapper;
			_productRepository = productRepository;
		}

		public IViewComponentResult Invoke()
		{
			var lastAdded = _productRepository.GetLastAddedProducts(6);
			var model = _mapper.Map<IEnumerable<Product>, IEnumerable<LastAddedViewModel>>(lastAdded);
			return View(model);
		}
	}
}
