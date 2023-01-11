using Admin.Filters;
using Admin.Libs;
using Admin.Models.Product;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repository.ProductRepository;
using Repository.Services;
using System.Collections;
using System.Collections.Generic;

namespace Admin.Controllers
{
	[TypeFilter(typeof(Auth))]
	public class ProductsController : Controller
	{
		private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
		private readonly IMapper _mapper;
		private readonly IProductRepository _productRepository;
		private readonly ICloudinaryService _cloudinaryService;
		private readonly IFileManager _fileManager;

		public ProductsController(IMapper mapper, 
								  IProductRepository productRepository,
								  ICloudinaryService cloudinaryService,
								  IFileManager fileManager)
		{
			_mapper = mapper;
			_productRepository = productRepository;
			_cloudinaryService = cloudinaryService;
			_fileManager = fileManager;
		}
		public IActionResult Index()
		{
			var products = _productRepository.GetAllProducts();

			var model = _mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(products);
			return View(model);
		}
		public IActionResult Create()	
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create(ProductViewModel prodmodel )
		{
			if (ModelState.IsValid)
			{
				var product = _mapper.Map<ProductViewModel, Product>(prodmodel);
				product.AddedBy = _admin.Fullname;
				_productRepository.CreateProduct(product);
				return RedirectToAction("index");
			}
			return View(prodmodel);
		}

		[HttpPost]
		public IActionResult Upload(IFormFile file)
		{
			var filename = _fileManager.Upload(file);
			var publicId = _cloudinaryService.Store(filename);
			_fileManager.Delete(filename);
			return Ok(new
			{
				filename = publicId,
				src = _cloudinaryService.BuildUrl(publicId)
			}) ;
		}

		[HttpPost]
		public IActionResult Remove(string name)
		{
			_cloudinaryService.Delete(name);
			return Ok(new {status=200});
		}
        public IActionResult Edit()
        {
            return View();
        }
    }
}
