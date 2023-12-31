﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using YetgenAkbankJump.Domain.Dtos;
using YetgenAkbankJump.Domain.Entities;
using YetgenAkbankJump.Persistence.Contexts;

namespace YetgenAkbankJump.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{

		private readonly ApplicationDbContext _applicationDbContext;
		public ProductController(ApplicationDbContext applicationDbContext)
		{
			this._applicationDbContext = applicationDbContext;
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetByIdAsync(Guid id,CancellationToken cancellationToken)
		{
			var product = await _applicationDbContext
				.Products
				.AsNoTracking ()
				.Include(x=>x.Category)
				.FirstOrDefaultAsync (x=>x.Id==id,cancellationToken);

			return Ok(product);
		}

		[HttpGet]
		public async Task<IActionResult> GetAlldAsync(CancellationToken cancellationToken)
		{
			var products = await _applicationDbContext
				.Products
				.AsNoTracking()
				.Select (x=> new ProductDto()
				{
					Id = x.Id,
					Name = x.Name,
					CategoryId = x.CategoryId,
					CategoryName = x.Category.Name,
					CreatedOn = x.CreatedOn
				})
				.ToListAsync(cancellationToken);

			return Ok(products);
		}

		[HttpPost]
		public async Task<IActionResult> AddAsync(ProductAddDto productAddDto, CancellationToken cancellation)
		{
			if (productAddDto.Name is null)
				return BadRequest("cannot be null");

			var product = new Product()
			{
				Id = Guid.NewGuid(),
				Name = productAddDto.Name,
				CategoryId = productAddDto.CategoryId,
				CreatedByUserId = "sak master",
				CreatedOn = DateTime.UtcNow,
				IsDeleted = false
			};

			await _applicationDbContext.Products.AddAsync(product);

			await _applicationDbContext.SaveChangesAsync();

			return Ok(product);
		}

	}
}
