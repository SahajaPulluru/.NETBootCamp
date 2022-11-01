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
    public class ProductController : ControllerBase
    {
        private readonly ProductRepository repo;
        public ProductController()
        {
            this.repo = new ProductRepository();
        }
        [Route("GetAllProducts")]
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Product> products = repo.GetAll();
            return StatusCode(200, products);
        }
        [HttpGet]
        [Route("GetProductById/{id}")]
        public IActionResult GetProductById(int id)
        {
            Product product = repo.GetProductById(id);
            return StatusCode(200, product);
        }
        [HttpPost]
        [Route("Add")]
        public IActionResult Add(Product product)
        {
            repo.Add(product);
            return StatusCode(200, product);
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            repo.Delete(id);
            return StatusCode(200, "Product with " + id + " Deleted");
        }
        [HttpPut]
        [Route("Edit")]
        public IActionResult Edit(Product product)
        {
            repo.Edit(product);
            return StatusCode(200, product);
        }

    }
}
