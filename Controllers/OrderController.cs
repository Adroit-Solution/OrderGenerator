using MarketPlace_Orders.Database;
using MarketPlace_Orders.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MarketPlace_Orders.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly MarketPlaceContext marketPlaceContext;

        public OrderController(MarketPlaceContext marketPlaceContext)
        {
            this.marketPlaceContext = marketPlaceContext;
        }

        [HttpGet]
        public async Task<ActionResult> GetOrders()
        {
            var list = await marketPlaceContext.Orders.ToListAsync();
            return Ok(list);
        }

        [HttpPost]
        public async Task<ActionResult> PostOrders()
        {

            for (int i = 0; i < 10; i++)
            {
                var availableproduct = await marketPlaceContext.Products.Where(a => a.InStock == 1).ToListAsync();
                var product = availableproduct.ElementAt(Random.Shared.Next(availableproduct.Count));
                //var product = marketPlaceContext.Products.ElementAt(Random.Shared.Next(marketPlaceContext.Products.Count()));
                var customer = marketPlaceContext.Customer.ToList().ElementAt(Random.Shared.Next(marketPlaceContext.Customer.Count()));
                var marketPlace = await marketPlaceContext.MarketPlaces.FindAsync(product.MarketPlaceId);
                var restaurant = await marketPlaceContext.Restaurants.FindAsync(product.RestaurantId);

                Orders orders = new()
                {
                    ClientId = customer.Id,
                    MarketPlaceId = marketPlace.Id,
                    OutletId = product.Id,
                    RestauranId = restaurant.Id,
                    Status = "NotAccepted",
                    OrderTime = DateTime.Now,
                    OrderNo = marketPlaceContext.Orders.Where(a => a.ClientId == customer.Id && a.RestauranId == restaurant.Id && a.MarketPlaceId == marketPlace.Id && a.Status != "Cancelled").Count() + 1
                };
                await marketPlaceContext.Orders.AddAsync(orders);
                await marketPlaceContext.SaveChangesAsync();
                //Thread.Sleep(120000);
            }

            return Ok();
        }

        //This for Generating a Order for particular any Restaurant
        
        [HttpPost("{merchantId}")]
        public async Task<ActionResult> PostOrder(Guid merchantId)
        {
            var products = marketPlaceContext.Products.Where(a => a.RestaurantId == merchantId).ToList();
            var product = products.ElementAt(Random.Shared.Next(products.Count()));
            //var product = marketPlaceContext.Products.ElementAt(Random.Shared.Next(marketPlaceContext.Products.Count()));
            var customer = marketPlaceContext.Customer.ToList().ElementAt(Random.Shared.Next(marketPlaceContext.Customer.Count()));
            var marketPlace = await marketPlaceContext.MarketPlaces.FindAsync(product.MarketPlaceId);
            var restaurant = await marketPlaceContext.Restaurants.FindAsync(product.RestaurantId);

            Orders orders = new()
            {
                ClientId = customer.Id,
                MarketPlaceId = marketPlace.Id,
                OutletId = product.Id,
                RestauranId = restaurant.Id,
                Status = "NotAccepted",
                OrderTime = DateTime.Now,
                OrderNo = marketPlaceContext.Orders.Where(a => a.ClientId == customer.Id && a.RestauranId == restaurant.Id && a.MarketPlaceId == marketPlace.Id && a.Status != "Cancelled").Count() + 1
            };
            await marketPlaceContext.Orders.AddAsync(orders);
            int changes = await marketPlaceContext.SaveChangesAsync();
            if (changes > 0)
                return Ok(orders.Id);
            else
                return BadRequest();
        }

    }
}
