using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Nurgo.Models;
using Repository.Models;
using Repository.Repository.ProductRepository;
using System.Collections.Generic;

namespace Nurgo.ViewComponents
{
	public class ProductViewComponent : ViewComponent
	{
		private readonly IMapper _mapper;
		private readonly IProductRepository _productRepository;

		public ProductViewComponent(IMapper mapper, IProductRepository productRepository)
		{
			_mapper = mapper;
			_productRepository = productRepository;
		}

		public IViewComponentResult Invoke()
		{
			var products = _productRepository.GetProducts();
			var model = _mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(products);
			return View(model);
		}
	}
}
