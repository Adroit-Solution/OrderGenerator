using MarketPlace_Orders.Database;
using MarketPlace_Orders.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MarketPlace_Orders.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly MarketPlaceContext marketPlaceContext;

        public CustomerController(MarketPlaceContext marketPlaceContext)
        {
            this.marketPlaceContext = marketPlaceContext;
        }

        [HttpGet]
        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            var list = await marketPlaceContext.Customer.ToListAsync();
            return (list);
        }

        [HttpPost]
        public async Task<ActionResult> PostCustomer()
        {
            List<string> Names = new List<string>() { "Kush", "Aelish", "Darshil", "Vishesh", "Tejas", "Harsh", "Naisarg", "Amit", "Raj", "Ramesh" };
            List<string> Surname = new List<string>() { "Parmar", "Virani", "Kanzariya", "Agrawal", "Maheriya", "Vaghasiya", "Sharma", "Rathod", "Kushwah", "Verma" };
            List<string> Location = new List<string>() { "Ahmedabad", "Gandhinagar", "Mumbai", "Kolkata", "Delhi", "Chennai", "Kerala", "Bangalore", "Pune", "Goa" };
            List<Customer> customers = new();
            for (int i = 0; i < 50; i++)
            {
                Customer customer = new()
                {
                    Id = Guid.NewGuid(),
                    Name = Names[Random.Shared.Next(0, 6)] + " " + Surname[Random.Shared.Next(0, 6)],
                    Location = Location[Random.Shared.Next(0, Location.Count)]
                };
                customers.Add(customer);
            }

            await marketPlaceContext.Customer.AddRangeAsync(customers);
            var result = await marketPlaceContext.SaveChangesAsync();
            if (result > 0)
                return Ok();
            else
                return BadRequest();
        }
    }
}
