using MarketPlace_Orders.Database;
using MarketPlace_Orders.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MarketPlace_Orders.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly MarketPlaceContext marketPlaceContext;

        public ProductController(MarketPlaceContext marketPlaceContext)
        {
            this.marketPlaceContext = marketPlaceContext;
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> GetProduct()
        {
            var list = await marketPlaceContext.Products.ToListAsync();
            return (list);
        }

        [HttpPost]
        public async Task<ActionResult> PostProduct()
        {
            var relate = await marketPlaceContext.RestMarketRelate.ToListAsync();
            List<Product> products = new();

            List<string> items = new List<string>() { "Chocolate Shake", "Finger Chips", "Bread Jam", "Cheese Pasta", "Cheese Pizza", "Cookies", "Pastries", "Ice Creams", "Cup Cakes", "Maggie", "Smoothies", "Noodles", "Brownie", "Chocolate Sandwich", "Burger", "Puri Achaar", "Corn Bhel" };

            foreach (var item in relate)
            {
                List<int> range = new();
                range.AddRange(Enumerable.Range(0, 10)
                               .OrderBy(i => Random.Shared.Next(0, items.Count)).Distinct()
                               .Take(10));

                var restaurant = await marketPlaceContext.Restaurants.FindAsync(item.Restaurant);
                var marketPlace = await marketPlaceContext.MarketPlaces.FindAsync(item.MarketPlace);
                for (int j = 0; j < 10; j++)
                {
                    Product product = new()
                    {
                        Name = items[range[j]],
                        RestaurantId = restaurant.Id,
                        Price = (Random.Shared.Next(70, 200)) * 5,
                        MarketPlaceId = marketPlace.Id,
                        InStock = 1
                    };
                    products.Add(product);
                }
            }

            await marketPlaceContext.Products.AddRangeAsync(products);
            var result = await marketPlaceContext.SaveChangesAsync();
            if (result > 0)
                return Ok("10 Products Added for each Restaurant");
            else
                return BadRequest();

        }
    }
}
