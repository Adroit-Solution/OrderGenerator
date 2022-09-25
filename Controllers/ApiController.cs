using MarketPlace_Orders.Database;
using MarketPlace_Orders.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MarketPlace_Orders.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private readonly MarketPlaceContext marketPlaceContext;

        public ApiController(MarketPlaceContext marketPlaceContext)
        {
            this.marketPlaceContext = marketPlaceContext;
        }

        [HttpGet("{merchantId}")]
        public async Task<ActionResult> OrderApi(Guid merchantId)//Order API to use
        {
            List<OrderApi> toReturn = new();
            var orders = await marketPlaceContext.Orders.Where(a => a.RestauranId == merchantId).ToListAsync();
            foreach (var order in orders)
            {
                var boy = await marketPlaceContext.DeliveryBoys.FindAsync(order.DeliveryBoyId);
                var customer = await marketPlaceContext.Customer.FindAsync(order.ClientId);
                var marketPlace = await marketPlaceContext.MarketPlaces.FindAsync(order.MarketPlaceId);
                var item = await marketPlaceContext.Products.FindAsync(order.OutletId);
                OrderApi orderApi = new();
                if (order.Status == "Accepted")
                {
                    orderApi = new()
                    {
                        BoyPhone = boy.Phone,
                        CustomerName = customer.Name,
                        DeliveryBoyName = boy.Name,
                        ItemName = item.Name,
                        Location = customer.Location,
                        MarketPlaceName = marketPlace.Name,
                        OrderId = order.Id,
                        OrderNo = order.OrderNo,
                        OrderTime = order.OrderTime,
                        Price = item.Price,
                        Status = order.Status,
                        ToPrepare = order.ToComplete
                    };
                }
                else
                {
                    orderApi = new()
                    {
                        BoyPhone = "Not Assigned",
                        DeliveryBoyName = "Not Assigned",
                        CustomerName = customer.Name,
                        ItemName = item.Name,
                        Location = customer.Location,
                        MarketPlaceName = marketPlace.Name,
                        OrderId = order.Id,
                        OrderNo = order.OrderNo,
                        OrderTime = order.OrderTime,
                        Price = item.Price,
                        Status = order.Status
                    };
                }
                toReturn.Add(orderApi);
            }
            return Ok(toReturn);
        }


        [HttpPut("{orderId}/{toPrepare}")]
        public async Task<ActionResult> PutOrderAccept(Guid orderId, DateTime toPrepare)
        {
            var order = await marketPlaceContext.Orders.FindAsync(orderId);
            if (order is null)
                return NotFound("Given Order Id is not Found");

            var count = marketPlaceContext.DeliveryBoys.Where(a => a.Status == "Free").Count();
            var deliveryBoy = marketPlaceContext.DeliveryBoys.Where(a => a.Status == "Free").ToList().ElementAt(Random.Shared.Next(count));

            order.DeliveryBoyId = deliveryBoy.Id;
            order.Status = "Accepted";
            order.ToComplete = DateTime.Now.AddMinutes(toPrepare.Minute);

            marketPlaceContext.Orders.Attach(order);
            var a = await marketPlaceContext.SaveChangesAsync();
            if (a > 0)
                return Ok();
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("{restaurantId}")]
        public async Task<IEnumerable<Product>> GetZomatoProduct(Guid restaurantId)
        {
            var market = await marketPlaceContext.MarketPlaces.TakeWhile(a => a.Name == "Zomato").ToListAsync();
            var list = await marketPlaceContext.Products.TakeWhile(a => a.RestaurantId == restaurantId && a.MarketPlaceId == market[0].Id).ToListAsync();
            return (list);
        }

        [HttpGet("{restaurantId}")]
        public async Task<IEnumerable<Product>> GetSwiggyProduct(Guid restaurantId)
        {
            var market = await marketPlaceContext.MarketPlaces.TakeWhile(a => a.Name == "Swiggy").FirstOrDefaultAsync();
            var list = await marketPlaceContext.Products.TakeWhile(a => a.RestaurantId == restaurantId && a.MarketPlaceId == market.Id).ToListAsync();
            return (list);
        }

        [HttpGet("{restaurantId}")]
        public async Task<IEnumerable<Product>> GetPandaProduct(Guid restaurantId)
        {
            var market = await marketPlaceContext.MarketPlaces.TakeWhile(a => a.Name == "Food Panda").FirstOrDefaultAsync();
            var list = await marketPlaceContext.Products.TakeWhile(a => a.RestaurantId == restaurantId && a.MarketPlaceId == market.Id).ToListAsync();
            return (list);
        }

        [HttpGet("{restaurantId}")]
        public async Task<IEnumerable<Product>> GetUberProduct(Guid restaurantId)
        {
            var market = await marketPlaceContext.MarketPlaces.TakeWhile(a => a.Name == "Uber Eats").FirstOrDefaultAsync();
            var list = await marketPlaceContext.Products.TakeWhile(a => a.RestaurantId == restaurantId && a.MarketPlaceId == market.Id).ToListAsync();
            return (list);
        }


        [HttpPost]
        public async Task<ActionResult> PostProduct([FromBody] Product product)
        {
            var marketPlace = await marketPlaceContext.MarketPlaces.FindAsync(product.MarketPlaceId);
            if (marketPlace is null)
                return NotFound("MarketPlace not Found");
            var restaurant = await marketPlaceContext.Restaurants.FindAsync(product.RestaurantId);
            if (restaurant is null)
                return NotFound("Restaurant not Found");
            var relation = await marketPlaceContext.RestMarketRelate.FindAsync(marketPlace.Id, restaurant.Id);
            if (relation is null)
                return NotFound("Restaurant is not available on this MarketPlace");
            Product product1 = new()
            {
                Description = product.Description,
                MarketPlaceId = product.MarketPlaceId,
                RestaurantId = product.RestaurantId,
                Name = product.Name,
                Price = product.Price,
                InStock = product.InStock
            };

            await marketPlaceContext.AddAsync(product1);
            int changes = await marketPlaceContext.SaveChangesAsync();
            if (changes > 0)
                return Ok();
            else
                return BadRequest();
        }

        [HttpPut]
        public async Task<ActionResult> PutProduct([FromBody] Product product)
        {
            var item = await marketPlaceContext.Products.FindAsync(product.Id);
            if (item is null)
                return NotFound("Product not Found");
            var marketPlace = await marketPlaceContext.MarketPlaces.FindAsync(item.MarketPlaceId);
            if (marketPlace is null)
                return NotFound("Market Place not Found");
            var restaurant = await marketPlaceContext.Restaurants.FindAsync(item.RestaurantId);
            if (restaurant is null)
                return NotFound("Restaurant not Found");
            var relation = await marketPlaceContext.RestMarketRelate.FindAsync(marketPlace.Id, restaurant.Id);
            if (relation is null)
                return NotFound("Restaurant is not available on this MarketPlace");

            item.Description = product.Description;
            item.Name = product.Name;
            item.Price = product.Price;
            item.InStock = product.InStock;
            
            marketPlaceContext.Entry(item).State = EntityState.Modified;
            int changes = await marketPlaceContext.SaveChangesAsync();
            if (changes > 0)
                return Ok("Item Updated Successfully");
            else
                return BadRequest("Item not Updated Successfully");

        }

        [HttpDelete("{prductId}")]
        public async Task<ActionResult> DeleteProduct(Guid productId)
        {
            var orders = await marketPlaceContext.Orders.Where(a => a.OutletId == productId && a.Status != "Completed").ToListAsync();
            if (orders.Count > 0)
                return BadRequest("Product is in Order");
            var item = await marketPlaceContext.Products.FindAsync(productId);
            if (item is null)
                return NotFound("Product not Found");
            marketPlaceContext.Products.Remove(item);
            int changes = await marketPlaceContext.SaveChangesAsync();
            if (changes > 0)
                return Ok("Item Deleted Successfully");
            else
                return BadRequest("Item not Deleted Successfully");
        }
    }
}
