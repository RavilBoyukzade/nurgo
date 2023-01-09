using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Nurgo.Models;
using Repository.Models;
using Repository.Repository.ProductRepository;

namespace Nurgo.Controllers
{
	public class ProductController : Controller
	{
		private readonly IMapper _mapper;
		private readonly IProductRepository _productRepository;

		public ProductController(IMapper mapper, 
								 IProductRepository productRepository)
		{
			_mapper= mapper;
			_productRepository= productRepository;
		}

		public IActionResult Index(int id)
		{
			var product = _productRepository.GetProductById(id);
			if(product == null) return NotFound();
			var model = _mapper.Map<Product, ProductViewModel>(product);
			return View(model);
		}
	}
}
