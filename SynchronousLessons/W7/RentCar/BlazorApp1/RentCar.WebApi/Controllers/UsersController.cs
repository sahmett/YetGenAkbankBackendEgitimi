using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentCar.Domain.Entities;
using RentCar.Persistence.Contexts;
using RentCar.WebApi.Models;

namespace RentCar.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly RentCarDbContext _context;

        public UsersController()
        {
            _context = new RentCarDbContext();
        }

        [HttpGet]
        public List<User> GetUsers()
        {
            return _context.Users.ToList();
        }

        [HttpPost] //iki body aynı anda alamadığı için hata verir
        public void CreateUser([FromBody] CreateUserRequest createUserRequest)
        {
            User user = new User()
            {
                FirstName = createUserRequest.FirstName,
                LastName = createUserRequest.LastName,
                CreatedOn = DateTime.UtcNow,
                CreatedByUserId = "admin"
            };

            _context.Users.Add(user);
            _context.SaveChanges();
            
        }
    }
}
