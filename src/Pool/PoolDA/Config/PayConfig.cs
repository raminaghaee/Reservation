using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PoolBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolDA.Config;
internal class PayConfig : IEntityTypeConfiguration<Pay>
{
    public void Configure(EntityTypeBuilder<Pay> builder)
    {
        builder
          .Property(e => e.ActivedId)
          .HasDefaultValue(1);
        builder.Property(e => e.CreateDateTime)
            .HasDefaultValueSql("GETDATE()");

    }
}
