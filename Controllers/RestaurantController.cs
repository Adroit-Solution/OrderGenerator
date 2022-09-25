using MarketPlace_Orders.Database;
using MarketPlace_Orders.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MarketPlace_Orders.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private readonly MarketPlaceContext marketPlaceContext;

        public RestaurantController(MarketPlaceContext marketPlaceContext)
        {
            this.marketPlaceContext = marketPlaceContext;
        }

        [HttpGet]
        public async Task<IEnumerable<Restaurant>> GetRestaurants()
        {
            return (await marketPlaceContext.Restaurants.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult> PostRestaurent()
        {
            List<Restaurant> restaurants = new() {
                new Restaurant
                {
                    Id = Guid.NewGuid(),
                    Name = "KFC"
                },
                new Restaurant
                {
                    Id = Guid.NewGuid(),
                    Name = "Dominos"
                },
                new Restaurant
                {
                    Id = Guid.NewGuid(),
                    Name = "Pizza Hut"
                },
                new Restaurant
                {
                    Id = Guid.NewGuid(),
                    Name = "City Point"
                },
                new Restaurant
                {
                    Id = Guid.NewGuid(),
                    Name = "Farki "
                },
            };
            await marketPlaceContext.Restaurants.AddRangeAsync(restaurants);
            var result = await marketPlaceContext.SaveChangesAsync();
            if (result > 0)
                return Ok();
            else
                return BadRequest();
        }

        [HttpGet]
        public async Task<IEnumerable<RestaurantMarketPlace>> GetRestaurantMarket()
        {
            return await marketPlaceContext.RestMarketRelate.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult> PostRelation()
        {
            var restuarants = await marketPlaceContext.Restaurants.ToListAsync();
            var marketPlaces = await marketPlaceContext.MarketPlaces.ToListAsync();
            List<RestaurantMarketPlace> relations = new();
            foreach (var restaurant in restuarants)
            {
                int n = Random.Shared.Next(1, marketPlaces.Count);
                List<int> range = new();
                range.AddRange(Enumerable.Range(0, n)
                               .OrderBy(i => Random.Shared.Next(0, marketPlaces.Count)).Distinct()
                               .Take(n));
                for (int i = 0; i < n; i++)
                {
                    RestaurantMarketPlace restaurantMarketPlace = new() { Restaurant = restaurant.Id, MarketPlace = marketPlaces[range[i]].Id };
                    var relate = await marketPlaceContext.RestMarketRelate.FindAsync(marketPlaces[range[i]].Id, restaurant.Id);
                    if (relate is null)
                        relations.Add(restaurantMarketPlace);
                }
            }

            await marketPlaceContext.RestMarketRelate.AddRangeAsync(relations);
            int changes = await marketPlaceContext.SaveChangesAsync();
            if (changes > 0)
                return Ok();
            else
            {
                return BadRequest();
            }
        }
    }
}
