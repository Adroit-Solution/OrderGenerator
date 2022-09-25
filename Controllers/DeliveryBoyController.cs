using MarketPlace_Orders.Database;
using MarketPlace_Orders.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MarketPlace_Orders.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DeliveryBoyController : ControllerBase
    {
        private readonly MarketPlaceContext marketPlaceContext;

        public DeliveryBoyController(MarketPlaceContext marketPlaceContext)
        {
            this.marketPlaceContext = marketPlaceContext;
        }

        [HttpPost]
        public async Task<ActionResult> PostDeliveryBoy()
        {
            List<string> Names = new List<string>() { "Kush", "Aelish", "Darshil", "Vishesh", "Tejas", "Harsh", "Naisarg", "Amit", "Raj", "Ramesh" };
            List<string> Surname = new List<string>() { "Parmar", "Virani", "Kanzariya", "Agrawal", "Maheriya", "Vaghasiya", "Sharma", "Rathod", "Kushwah", "Verma" };

            List<DeliveryBoy> deliveryBoy = new();
            for (int i = 0; i < 20; i++)
            {
                DeliveryBoy boy = new()
                {
                    Id = Guid.NewGuid(),
                    Name = Names[Random.Shared.Next(6, 10)] + " " + Surname[Random.Shared.Next(6, 10)],
                    Phone = Random.Shared.NextInt64(9000000000, 9999999999).ToString(),
                    Status = "Free"
                };
                deliveryBoy.Add(boy);
            }
            await marketPlaceContext.DeliveryBoys.AddRangeAsync(deliveryBoy);
            var result = await marketPlaceContext.SaveChangesAsync();
            if (result > 0)
                return Ok();
            else
                return BadRequest();
        }
    }
}
