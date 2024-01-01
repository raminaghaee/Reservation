using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PoolBL;
using System.Reflection.Emit;


namespace PoolDA.Config;
internal class PoolConfig : IEntityTypeConfiguration<Pool>
{
    public void Configure(EntityTypeBuilder<Pool> builder)
    {
        builder
          .Property(e => e.ActivedId)
          .HasDefaultValue(1);
        builder
            .HasMany(r => r.Reserveds)
            .WithOne()
            .HasForeignKey(s => s.PoolId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
