using Domain;
using Infastructure.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Reflection.Emit;

namespace Infastructure.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser,ApplicationRole , string
        ,IdentityUserClaim<string> ,IdentityUserRole<string> ,IdentityUserLogin<string> , ApplicationRoleClaim
        ,IdentityUserToken<string>>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option):base(option)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            // configration decimel to avoid warning in migrations using Reflection
            var decimalData = builder.Model.GetEntityTypes()
                                                          .SelectMany(x => x.GetProperties()
                                                          .Where(x => x.ClrType == typeof(decimal) 
                                                          || x.ClrType == typeof(decimal?)));

            foreach (var property in decimalData)
            {
                property.SetColumnType("decimal(18,2)");
            }

            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Employee> Employees => Set<Employee>();
    }
}
