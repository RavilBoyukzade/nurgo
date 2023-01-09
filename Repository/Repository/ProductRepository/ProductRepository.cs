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
								   .Include("Videos")
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
	}
}
