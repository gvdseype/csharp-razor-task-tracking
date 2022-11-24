using Microsoft.EntityFrameworkCore;

namespace Tasker
{
	public class ApplicationDbContext : DbContext
	{
		public DbSet<Task> Tasks;
		public ApplicationDbContext(DbContextOptions options) :base(options)
		{

		}
	}
}
