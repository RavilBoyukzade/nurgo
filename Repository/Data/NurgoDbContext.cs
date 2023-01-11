using Microsoft.EntityFrameworkCore;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace Repository.Data
{
	public class NurgoDbContext : DbContext
	{
		public NurgoDbContext(DbContextOptions<NurgoDbContext> options) : base(options) { }

		public DbSet<Advantage> Advantages { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<ProductPhoto> ProductPhotos { get; set; }
		public DbSet<Setting> Settings { get; set; }
		public DbSet<SliderItem> SliderItems { get; set; }
		public DbSet<ProductFuture> ProductFutures { get; set; }
		public DbSet<Admin> Admins { get; set; }


	}
}
