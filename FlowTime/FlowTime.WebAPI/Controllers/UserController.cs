using FlowTime.Domain.Entities;
using FlowTime.Domain.Enum;
using FlowTime.Persistance.Context;
using FlowTime.WebAPI.Models;
using FlowTime.WebAPI.Validators;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlowTime.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public FlowAppDbContext _flowAppDbContext;

        public UserController(FlowAppDbContext flowAppDbContext)
        {
            _flowAppDbContext = flowAppDbContext;
        }



        [HttpPost("[action]")]
        public void SetDefaultUsersData()
        {
            List<User> users = new List<User>
    {
        new User
        {
            Id = Guid.Parse("f4ee11a6-9d8e-4584-8d7f-8ed2d83119c9"),
            FirstName = "James",
            LastName = "Smith",
            Country = "USA",
            City = "New York",
            WorkTime = 40,
            IsGraduated = true,
            Age = 30,
            Gender = Gender.Male,
            CreatedByUserId = "1" // Placeholder value, replace with actual logic
        },
        new User
        {
            Id = Guid.Parse("73af4318-299e-41c8-9544-6bd131d6b651"),
            FirstName = "Mary",
            LastName = "Johnson",
            Country = "USA",
            City = "Los Angeles",
            WorkTime = 35,
            IsGraduated = false,
            Age = 28,
            Gender = Gender.Female,
            CreatedByUserId = "1" // Gerçek mantıkla değiştirilecek yerine geçen değer
        },
        new User
        {
            Id = Guid.Parse("d3c4bad1-5b5e-45ed-969c-63cdd1474397"),
            FirstName = "John",
            LastName = "Williams",
            Country = "Canada",
            City = "Toronto",
            WorkTime = 45,
            IsGraduated = true,
            Age = 32,
            Gender = Gender.Male,
            CreatedByUserId = "1" // Gerçek mantıkla değiştirilecek yerine geçen değer
        },
        new User
        {
            Id = Guid.Parse("96ee8bd8-7604-4ca2-be17-9b4480ce3410"),
            FirstName = "Patricia",
            LastName = "Brown",
            Country = "UK",
            City = "London",
            WorkTime = 38,
            IsGraduated = true,
            Age = 29,
            Gender = Gender.Female,
            CreatedByUserId = "1" // Gerçek mantıkla değiştirilecek yerine geçen değer
        },
        new User
        {
            Id = Guid.Parse("df4a398a-7faa-4d25-998a-7fcbdb074565"),
            FirstName = "Robert",
            LastName = "Jones",
            Country = "USA",
            City = "Chicago",
            WorkTime = 42,
            IsGraduated = false,
            Age = 31,
            Gender = Gender.Male,
            CreatedByUserId = "1" // Gerçek mantıkla değiştirilecek yerine geçen değer
        },

    };

            _flowAppDbContext.Users.AddRange(users);

            _flowAppDbContext.SaveChanges();
        }




        [HttpGet("[action]/{userId:guid}")]
        public ActionResult<GetUserDataResponseModel> GetUserData(Guid userId)
        {
            var user = _flowAppDbContext.Users.FirstOrDefault(x => x.Id == userId);

            if (user != null)
            {
                var userModel = new GetUserDataResponseModel
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Country = user.Country,
                    City = user.City,
                    WorkTime = user.WorkTime,
                    IsGraduated = user.IsGraduated,
                    Age = user.Age,
                    Gender = user.Gender
                };

                return Ok(userModel);
            }
            else
            {
                return NotFound("User not found");
            }
        }

            [HttpPost("[action]")]
            public IActionResult CreateUser([FromBody] CreateUserRequestModel createUserRequest)
            {
                if (createUserRequest == null)
                {
                    return BadRequest("Invalid request");
                }

                // Doğrulama işlemi
                var createUserValidator = new CreateUserRequestModelValidator();
                var validationResult = createUserValidator.Validate(createUserRequest);

            if (!validationResult.IsValid)
            {
                var errorMessages = string.Join(", ", validationResult.Errors.Select(e => e.ErrorMessage));
                return BadRequest($"Validation failed: {errorMessages}");
            }

            // Kullanıcı oluşturma işlemi
            var newUser = new User
                {
                    Id = Guid.NewGuid(), // Yeni bir GUID oluşturabilirsiniz
                    FirstName = createUserRequest.FirstName,
                    LastName = createUserRequest.LastName,
                    Country = createUserRequest.Country,
                    City = createUserRequest.City,
                    WorkTime = createUserRequest.WorkTime,
                    IsGraduated = createUserRequest.IsGraduated,
                    Age = createUserRequest.Age,
                    Gender = createUserRequest.Gender,
                    CreatedByUserId = "1"
                };

                _flowAppDbContext.Users.Add(newUser);
                _flowAppDbContext.SaveChanges();

                // Oluşturulan kullanıcının bilgilerini döndür
                var createdUserModel = new GetUserDataResponseModel
                {
                    Id = newUser.Id,
                    FirstName = newUser.FirstName,
                    LastName = newUser.LastName,
                    Country = newUser.Country,
                    City = newUser.City,
                    WorkTime = newUser.WorkTime,
                    IsGraduated = newUser.IsGraduated,
                    Age = newUser.Age,
                    Gender = newUser.Gender
                };

                return CreatedAtAction(nameof(GetUserData), new { userId = newUser.Id }, createdUserModel);
            }



    }
}
