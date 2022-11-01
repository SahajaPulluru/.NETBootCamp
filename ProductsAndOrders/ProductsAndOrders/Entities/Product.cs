using System.ComponentModel.DataAnnotations;

namespace ProductsAndOrders.Entities
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string PName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
