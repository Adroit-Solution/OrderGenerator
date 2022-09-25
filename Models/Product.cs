using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarketPlace_Orders.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public Guid RestaurantId { get; set; }
        public Guid MarketPlaceId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Price { get; set; }
        public string Description { get; set; } = string.Empty;
        public int InStock { get; set; } = 1;

    }
}
