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

		[HttpPost]
		public async Task<IActionResult> AddAsync(CategoryAddDto categoryAddDto, CancellationToken cancellationToken)
		{

			if (categoryAddDto is null)
				return BadRequest("Category's name cannot be null");

			var category = new Category()
			{
				Id = Guid.NewGuid(),
				Name = categoryAddDto.Name,
				CreatedByUserId = "kalaymaster",
				CreatedOn = DateTimeOffset.UtcNow,
				IsDeleted = false,
			};

			await _applicationDbContext.Categories.AddAsync(category, cancellationToken);

			await _applicationDbContext.SaveChangesAsync(cancellationToken);

			return Ok(category);
		}


		[HttpGet("{id:guid}")]
		public async Task<IActionResult> GetByIdAsync(Guid id, CancellationToken cancellationToken)
		{
			var category = await _applicationDbContext
				.Categories
				.AsNoTracking()
				.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);

			return Ok(category);
		}

		[HttpGet]
		public async Task<IActionResult> GetAllAsync(CancellationToken cancellationToken)
		{
			var categories = await _applicationDbContext
				.Categories
				.AsNoTracking()
				.ToListAsync(cancellationToken);

			return Ok(categories);
		}

	}
}
