using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PoolBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolDA.Config;
internal class TicketConfig : IEntityTypeConfiguration<Ticket>
{
    public void Configure(EntityTypeBuilder<Ticket> builder)
    {
        builder
          .Property(e => e.ActivedId)
          .HasDefaultValue(1);
        builder.Property(e => e.StartDate)
            .HasDefaultValueSql("GETDATE()");
        builder.Property(e => e.EndDate)
            .HasDefaultValueSql("GETDATE()");
    }
}
