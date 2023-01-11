using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repository.ProductRepository
{
	public class ProductRepository : IProductRepository
	{
		private readonly NurgoDbContext _context;

		public ProductRepository(NurgoDbContext context)
		{
			_context = context;
		}

        public void AddPhoto(ProductPhoto productPhoto)
        {
           _context.ProductPhotos.Add(productPhoto);
			_context.SaveChanges();
        }

        public Product CreateProduct(Product product)
        {
            product.AddedDate= DateTime.Now;
			_context.Products.Add(product);
			_context.SaveChanges();
			return product;
        }

        public IEnumerable<Product> GetAllProducts()
		{
			return _context.Products.Include("Photos")
									.Include("Futures")
									.Where(p => p.Status)
                                    .OrderByDescending(p => p.AddedDate)
                                    .ToList();
		}

		public IEnumerable<Product> GetLastAddedProducts(int limit)
		{
			return _context.Products.Include("Photos")
									.Where(p=>p.Status)
									.OrderByDescending(p=>p.AddedDate)
									.Take(limit)
									.ToList();
		}

        public Product GetProductById(int id)
        {
           return _context.Products.Include("Photos")
                                   .Include("Futures")
                                   .FirstOrDefault(p=>p.Status && p.Id == id);
        }

        public IEnumerable<Product> GetProducts()
		{
			return _context.Products.Include("Photos")
									.Where(p=>p.Status)
									.OrderByDescending(p=>p.AddedDate)
									.ToList();
		}

        public Product GetProductsById(int id)
        {
            return _context.Products.Include("Photos")
									.FirstOrDefault(p=>p.Status && p.Id == id);
        }

        public IEnumerable<Product> GetProductsWithStatus()
        {
            return _context.Products.Include("Photos")
                                    .Include("Futures")
                                    .OrderByDescending(p => p.AddedDate)
                                    .ToList();
        }

        public void RemovePhotosById(int id)
        {
			ProductPhoto productPhoto = _context.ProductPhotos.Find(id);
			_context.ProductPhotos.Remove(productPhoto);
			_context.SaveChanges();
        }

        public void UpdateProduct(Product productToUpdate, Product product)
        {
            productToUpdate.Status= product.Status;
            productToUpdate.Price = product.Price;
            productToUpdate.Title = product.Title;
            productToUpdate.Description = product.Description;
            productToUpdate.Marka = product.Marka;
            productToUpdate.Model = product.Model;
            productToUpdate.BodyStyle = product.BodyStyle;
            productToUpdate.Year = product.Year;
            productToUpdate.Condition = product.Condition;
            productToUpdate.Killometer = product.Killometer;
            productToUpdate.İnteryer = product.İnteryer;
            productToUpdate.Transmissiya = product.Transmissiya;
            productToUpdate.Engine = product.Engine;
            productToUpdate.FuelType = product.FuelType;
            productToUpdate.ModifiedBy = product.ModifiedBy;
            productToUpdate.ModifiedDate = DateTime.Now;

            _context.SaveChanges();
        }
    }
}
