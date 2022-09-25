using System.ComponentModel.DataAnnotations;

namespace MarketPlace_Orders.Models
{
    public class Orders
    {
        public Guid Id { get; set; }
        public Guid ClientId { get; set; }
        public Guid RestauranId { get; set; }
        public Guid MarketPlaceId { get; set; }
        public Guid OutletId { get; set; }
        public DateTime OrderTime { get; set; }
        public int? OrderNo { get; set; }
        public Guid DeliveryBoyId { get; set; }
        public DateTime ToComplete { get; set; }
        public string Status { get; set; } = "NotAccepted"; // Five State 1.NotAccepted 2.Accepted 3.Ready 4.Completed 5. Cancelled
    }
}
