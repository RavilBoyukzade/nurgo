using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repository.ProductRepository
{
	public interface IProductRepository
	{
		IEnumerable<Product> GetLastAddedProducts(int limit);
		IEnumerable<Product> GetProducts();
		Product GetProductById(int id);
		IEnumerable<Product> GetAllProducts();
        Product CreateProduct(Product product);
    }
}
