
using JobHunter.Domain.Entities;
using JobHunter.Domain.Enums;
using JobHunter.Persistence.Contexts;

JobHunterDbContext _context = new();

JobPost jobPost1 = new JobPost()
{
	Title = "Test",
	Company = "Test1",
	Description = "Test",
	WorkMode=WorkMode.InOffice,
	CreatedOn = DateTime.UtcNow,
};

var state1 = _context.Entry(jobPost1).State;

_context.JobPosts.Add(jobPost1);

var state2 = _context.Entry(jobPost1).State;

_context.SaveChanges();

var state3 = _context.Entry(jobPost1).State;

jobPost1.WorkMode = WorkMode.Hybrid;

var state4 = _context.Entry(jobPost1).State;

Console.WriteLine("");


var query1 = _context. JobPosts. ToList().Where(x => x.WorkMode == WorkMode.InOffice).OrderBy(x => x.CreatedOn);
var query2 = _context.JobPosts.Where(x => x.WorkMode == WorkMode.InOffice).OrderBy(x => x.CreatedOn).ToList();

#region IEnumerable
//var result = query. ToList();
#endregion
Console.WriteLine();