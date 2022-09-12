
namespace OOPs.Inheritance
{
    public class Order
    {
        public string OrderNumber { get; set; }
        public Customer Customer { get; set; } = new Customer();
    }

}
