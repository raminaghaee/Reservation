using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PoolBL;


namespace PoolDA.Config;
internal class ConstantConfig : IEntityTypeConfiguration<Constant>
{
    public void Configure(EntityTypeBuilder<Constant> builder)
    {
        builder
          .Property(e => e.ActivedId)
          .HasDefaultValue(1);
    }
}
