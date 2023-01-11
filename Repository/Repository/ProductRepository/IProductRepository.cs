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
        IEnumerable<Product> GetProductsWithStatus();
        Product CreateProduct(Product product);
        Product GetProductsById(int id);
        void RemovePhotosById(int id);
        void AddPhoto(ProductPhoto productPhoto);
        void UpdateProduct(Product productToUpdate, Product product);
		void DeleteProduct(Product product);
		Product GetProductId(int id);
	}
}
