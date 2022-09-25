namespace MarketPlace_Orders.Models
{
    public class DeliveryBoy
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Phone { get; set; } = "9999999999";
        public string Status { get; set; } = "Free";
    }
}
