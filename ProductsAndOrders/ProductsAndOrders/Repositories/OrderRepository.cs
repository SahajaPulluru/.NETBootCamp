using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductsAndOrders.Database;
using ProductsAndOrders.Entities;
namespace ProductsAndOrders.Repositories
{

    public class OrderRepository
    {
        private readonly AppDbContext context;
        public OrderRepository()
        {
            this.context = new AppDbContext();
        }
        public void Add(Order order)
        {
            context.Orders.Add(order);
            context.SaveChanges();
        }
        public Order GetOrderById(int id)
        {
            Order order = context.Orders.SingleOrDefault(i => i.OrderId == id);
            return order;
        }
        public List<Order> GetAll()
        {
            return context.Orders.ToList();
        }
    }
}
