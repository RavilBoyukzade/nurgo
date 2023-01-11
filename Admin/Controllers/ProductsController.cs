using Admin.Filters;
using Admin.Libs;
using Admin.Models.Product;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repository.ProductRepository;
using Repository.Services;
using System;
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
			var products = _productRepository.GetProductsWithStatus();

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
		[ValidateAntiForgeryToken]
		public IActionResult Edit(ProductViewModel productmodel)
		{
			if (ModelState.IsValid)
			{
				var product = _mapper.Map<ProductViewModel, Product>(productmodel);
				var productToUpdate = _productRepository.GetProductById(productmodel.Id);

				product.ModifiedBy =_admin.Fullname;

				if (productToUpdate == null) return NotFound();
				_productRepository.UpdateProduct(productToUpdate,product);
				return RedirectToAction("index");

            }
			return View(productmodel);
		}

		[HttpPost]
		public IActionResult Upload(IFormFile file, int? productId, int? orderBy)
		{
			var filename = _fileManager.Upload(file);
			var publicId = _cloudinaryService.Store(filename);
			_fileManager.Delete(filename);

			if (productId != null)
			{
				ProductPhoto productPhoto = new ProductPhoto
				{
					AddedBy = _admin.Fullname,
					AddedDate = DateTime.Now,
					Image = publicId,
					ProductId = (int)productId,
					OrderBy = (int)orderBy

				};
				_productRepository.AddPhoto(productPhoto);
			}

			return Ok(new
			{
				filename = publicId,
				src = _cloudinaryService.BuildUrl(publicId)
			}) ;
		}

		[HttpPost]
		public IActionResult Remove(string name, int? id)
		{
			if (id != 0)
			{
				_productRepository.RemovePhotosById((int)id);
			}

			_cloudinaryService.Delete(name);
			return Ok(new {status=200});
		}
        public IActionResult Edit(int id)
        {
			var product = _productRepository.GetProductsById(id);
			if (product == null) return NotFound();

			var model =_mapper.Map<Product,ProductViewModel>(product);

            return View(model);
        }
		public IActionResult Delete(int id)
		{
			Product product = _productRepository.GetProductId(id);
			if (product == null) return NotFound();
			_productRepository.DeleteProduct(product);

			return RedirectToAction("index");
		}
	}
}
