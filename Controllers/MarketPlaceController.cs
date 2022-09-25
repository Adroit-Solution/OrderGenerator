using MarketPlace_Orders.Database;
using MarketPlace_Orders.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Linq;

namespace MarketPlace_Orders.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MarketPlaceController : ControllerBase
    {
        private readonly MarketPlaceContext marketPlaceContext;

        public MarketPlaceController(MarketPlaceContext marketPlaceContext)
        {
            this.marketPlaceContext = marketPlaceContext;
        }

        [HttpGet]
        public async Task<IEnumerable<MarketPlace>> GetMarketPlace()
        {
            var list = await marketPlaceContext.MarketPlaces.ToListAsync();
            return (list);
        }

        [HttpPost]
        public async Task<ActionResult> PostMarketPlace()
        {
            List<MarketPlace> marketPlaces = new() {
                new MarketPlace
                {
                    Id = Guid.NewGuid(),
                    Name = "Zomato"
                },
                new MarketPlace
                {
                    Id = Guid.NewGuid(),
                    Name = "Swiggy"
                },
                new MarketPlace
                {
                    Id = Guid.NewGuid(),
                    Name = "Uber Eats"
                },
                new MarketPlace
                {
                    Id = Guid.NewGuid(),
                    Name = "Food Panda"
                }
            };
            await marketPlaceContext.MarketPlaces.AddRangeAsync(marketPlaces);
            var result = await marketPlaceContext.SaveChangesAsync();
            if (result > 0)
                return Ok();
            else
                return BadRequest();
        }        
    }
}
