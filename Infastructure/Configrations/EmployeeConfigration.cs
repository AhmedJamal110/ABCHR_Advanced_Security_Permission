
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infastructure.Configrations
{
    internal class EmployeeConfigration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees", SchemaConfigration.HR);

            builder.HasIndex(x => x.FirstName)
                      .HasDatabaseName("IX_Employees_FirstName");

            builder.HasIndex(x => x.LastName)
                      .HasDatabaseName("IX_Employees_LastName");
        }
    }
}
