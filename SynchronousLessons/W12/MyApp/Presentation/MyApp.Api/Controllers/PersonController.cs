using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApp.Domain.Entities;
using MyApp.Infrastructure.Contexts;

namespace MyApp.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PersonController : ControllerBase
	{
		private readonly MyAppDbContext _context;

		public PersonController(MyAppDbContext context)
		{
			_context = context;
			List<Person> defraudedPeople = new List<Person> {
			new Person { Id = Guid.NewGuid(), FirstName = "John", LastName = "Doe" },
			new Person { Id = Guid.NewGuid(), FirstName = "Jane", LastName = "Smith" },
			new Person { Id = Guid.NewGuid(), FirstName = "Alice", LastName = "Johnson" },
			new Person { Id = Guid.NewGuid(), FirstName = "Bob", LastName = "Brown" },
			new Person { Id = Guid.NewGuid(), FirstName = "Charlie", LastName = "Davis" }
			 };
			_context.DefraudedPeople.AddRange(defraudedPeople);
			_context.SaveChanges();
			Console.WriteLine(string.Join("\n",defraudedPeople.Select(p => p.Id).ToList()));

		}

		public string GetDefraudedPersonName(Guid defraudedPersonId)
		{
			var person = _context.DefraudedPeople.FirstOrDefault(x => x.Id == defraudedPersonId);
			
			return person is null ? "Coulnd't Find!" : person.FirstName;
		}
	}
}
