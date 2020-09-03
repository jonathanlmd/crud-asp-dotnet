using Microsoft.EntityFrameworkCore;

namespace crud.Database {
	public class ApplicationDBContext : DbContext {
		public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) {

		}

	}
}