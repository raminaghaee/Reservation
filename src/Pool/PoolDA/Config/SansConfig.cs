using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PoolBL;


namespace PoolDA.Config;
internal class SansConfig : IEntityTypeConfiguration<Sans>
{
    public void Configure(EntityTypeBuilder<Sans> builder)
    {
        builder
          .Property(e => e.ActivedId)
          .HasDefaultValue(1);
        builder
          .HasMany(r => r.Reserved)
          .WithOne()
          .HasForeignKey(s => s.SansId)
          .OnDelete(DeleteBehavior.NoAction);
    }
}
