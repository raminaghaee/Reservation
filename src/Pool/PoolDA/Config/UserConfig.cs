using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PoolBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace PoolDA.Config;
internal class UserConfig : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder
          .Property(e => e.ActivedId)
          .HasDefaultValue(1);
        builder
           .HasMany(r => r.Reserveds)
           .WithOne()
           .HasForeignKey(s => s.UserId)
           .OnDelete(DeleteBehavior.NoAction);
    }
}
