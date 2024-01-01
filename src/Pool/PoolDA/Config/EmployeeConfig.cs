using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PoolBL;


namespace PoolDA.Config;
internal class EmployeeConfig : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder
          .Property(e => e.ActivedId)
          .HasDefaultValue(1);
    }
}
