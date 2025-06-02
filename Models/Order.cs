namespace Grocery.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string userId { get; set; }
        public DateTime orderDate { get; set; } = DateTime.Now;
        public string status { get; set; } = "Pending";
        public decimal totalAmount { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    }
}
