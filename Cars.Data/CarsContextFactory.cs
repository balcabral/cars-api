using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Cars.Data
{
	public class CarsContextFactory : IDesignTimeDbContextFactory<CarsContext>
    {
		public CarsContext CreateDbContext(string[] args)
        {
			// TODO: Refactor Hardcoded Connection String
			var optionsBuilder = new DbContextOptionsBuilder<CarsContext>()
                .UseSqlServer("Server=localhost;Database=Cars;User=sa;Password=Suporte_123456;Integrated Security=false;");
            
			return new CarsContext(optionsBuilder.Options);
        }
    }
}
