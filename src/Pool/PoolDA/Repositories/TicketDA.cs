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
    private readonly PoolDbContext _db;

    public TicketDA(PoolDbContext Db) : base(Db)
    {
        _db = Db;
    }

    public ICollection<Ticket> GetByDate(int poolId, DateOnly startDate, DateOnly endDate)
             => _db.Ticket.AsNoTracking()
                    .Where(t => t.PoolId == poolId && t.StartDate >= startDate && t.EndDate <= endDate)
                    .ToList();


    public ICollection<Ticket> GetByDate(int poolId, DateOnly date)
            => _db.Ticket.AsNoTracking()
                    .Where(t => t.PoolId == poolId && t.StartDate == date)
                    .ToList();

    public int GetCountCostumerByDate(int poolId, DateOnly startDate, DateOnly endDate)
            => _db.Ticket.AsNoTracking()
                    .Where(t => t.PoolId == poolId && t.StartDate >= startDate && t.EndDate <= endDate)
                    .Count();

    public int GetCountCostumerByDate(int poolId, DateOnly date)
            => _db.Ticket.AsNoTracking()
                    .Where(t => t.PoolId == poolId && t.StartDate == date)
                    .Count();

    public IQueryable<Ticket> GetIQueryableByDate(int poolId, DateOnly startDate, DateOnly endDate)
             => _db.Ticket
                    .Where(t => t.PoolId == poolId && t.StartDate >= startDate && t.EndDate <= endDate);

    public IQueryable<Ticket> GetIQueryableByDate(int poolId, DateOnly date)
            => _db.Ticket
                    .Where(t => t.PoolId == poolId && t.StartDate == date);




    public ICollection<Ticket> GetCountCostumerByPoolName(string Name)
    {
        return _db.Ticket.AsNoTracking()
                        .Where(t=>t.Pool.Name.Contains(Name)).ToList();
    }
}
