using Microsoft.EntityFrameworkCore;
using PoolBL;
using PoolDA.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolDA;
public class TicketDA : BaseDA<Ticket>, ITicketDA
{
    public TicketDA(PoolDbContext Db) : base(Db)
    {
    }
}
