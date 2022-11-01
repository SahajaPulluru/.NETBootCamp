using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductsAndOrders.Database;
using ProductsAndOrders.Entities;
namespace ProductsAndOrders.Repositories
{

    public class ProductRepository 
    {
        private readonly AppDbContext context;
        public ProductRepository()
        {
            this.context = new AppDbContext();
        }
        public void Add(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            Product product = context.Products.SingleOrDefault(i => i.ProductId == id);
            context.Products.Remove(product);
            context.SaveChanges();
        }

        public void Edit(Product product)
        {
            context.Products.Update(product);
            context.SaveChanges();
        }

        public Product GetProductById(int id)
        {
            Product product = context.Products.SingleOrDefault(i => i.ProductId == id);
            return product;
        }
        public List<Product> GetAll()
        {
            return context.Products.ToList();
        }
    }
}
