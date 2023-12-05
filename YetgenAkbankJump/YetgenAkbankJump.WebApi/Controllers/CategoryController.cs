using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YetgenAkbankJump.Domain.Dtos;
using YetgenAkbankJump.Domain.Entities;
using YetgenAkbankJump.Persistence.Contexts;

namespace YetgenAkbankJump.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoryController : ControllerBase
	{
		private readonly ApplicationDbContext _applicationDbContext;
		public CategoryController(ApplicationDbContext applicationDbContext)
		{
			this._applicationDbContext = applicationDbContext;
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetByIdAsync(Guid id, CancellationToken cancellationToken)
		{
			var category = await _applicationDbContext
				.Categories
				.AsNoTracking()
				.Include(x => x.Products)
				.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);

			return Ok(category);
		}	

		[HttpGet]
		public async Task<IActionResult> GetAlldAsync(CancellationToken cancellationToken)
		{
			var categoryies = await _applicationDbContext
				.Categories
				.AsNoTracking()
				.ToListAsync(cancellationToken);

			return Ok(categoryies);
		}

		[HttpPost]
		public async Task<IActionResult> AddAsync(CategoryAddDto categoryAddDto, CancellationToken cancellation)
		{
			if (categoryAddDto.Name is null)
				return BadRequest("cannot be null");

			var category = new Category()
			{
				Id= Guid.NewGuid(),
				Name= categoryAddDto.Name,
				CreatedByUserId="sak master",
				CreatedOn = DateTime.UtcNow,
				IsDeleted=false
			};

			await _applicationDbContext.Categories.AddAsync(category);

			await _applicationDbContext.SaveChangesAsync();

			return Ok(category);
		}

	}
}
