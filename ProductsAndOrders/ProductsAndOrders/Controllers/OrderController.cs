using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductsAndOrders.Entities;
using ProductsAndOrders.Repositories;
namespace ProductsAndOrders.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly OrderRepository repo;
        public OrderController()
        {
            this.repo = new OrderRepository();
        }
        [Route("GetAllOrders")]
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Order> orders = repo.GetAll();
            return StatusCode(200, orders);
        }
        [HttpGet]
        [Route("GetOrderById/{id}")]
        public IActionResult GetOrdertById(int id)
        {
            Order order = repo.GetOrderById(id);
            return StatusCode(200, order);
        }
        [HttpPost]
        [Route("Add")]
        public IActionResult Add(Order order)
        {
            repo.Add(order);
            return StatusCode(200, order);
        }

    }
}
