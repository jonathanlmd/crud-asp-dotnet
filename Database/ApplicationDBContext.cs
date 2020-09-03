using Microsoft.EntityFrameworkCore;
using crud.Models;

namespace crud.Database {
	public class ApplicationDBContext : DbContext {

		public DbSet<Employee> Employees { get; set; }

		public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) {

		}

	}
}