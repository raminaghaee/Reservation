using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PoolBL;
using System.Reflection.Emit;


namespace PoolDA.Config;
internal class ReservedConfig : IEntityTypeConfiguration<Reserved>
{
    public void Configure(EntityTypeBuilder<Reserved> builder)
    {
        builder
          .Property(e => e.ActivedId)
          .HasDefaultValue(1);
        builder.Property(e => e.DateTime)
           .HasDefaultValueSql("GETDATE()");
    }
}
