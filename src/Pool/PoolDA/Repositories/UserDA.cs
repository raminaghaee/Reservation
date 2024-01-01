using Microsoft.EntityFrameworkCore;
using PoolBL;
using PoolDA.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PoolDA;
public class UserDA : BaseDA<User>, IUserDA
{
    private readonly PoolDbContext _db;

    public UserDA(PoolDbContext Db) : base(Db)
    {
        _db = Db;
    }


    public ICollection<User> GetByDate(int poolId, DateOnly startDate, DateOnly endDate)
             => _db.User
                    .Where(u => u.Tickets.Any(t => t.PoolId == poolId && t.StartDate >= startDate && t.EndDate <= endDate))
                    .ToList();


    public ICollection<User> GetByDate(int poolId, DateOnly date)
            => _db.User
                    .Where(u => u.Tickets.Any(t => t.PoolId == poolId && t.StartDate == date))
                    .ToList();

    public int GetCountCostumerByDate(int poolId, DateOnly startDate, DateOnly endDate)
            => _db.User
                    .Where(u => u.Tickets.Any(t => t.PoolId == poolId && t.StartDate >= startDate && t.EndDate <= endDate))
                    .Count();

    public int GetCountCostumerByDate(int poolId, DateOnly date)
            => _db.User
                    .Where(u => u.Tickets.Any(t => t.PoolId == poolId && t.StartDate == date))
                    .Count();

    public IQueryable<User> GetIQueryableByDate(int poolId, DateOnly startDate, DateOnly endDate)
             => _db.User
                    .Where(u => u.Tickets.Any(t => t.PoolId == poolId && t.StartDate >= startDate && t.EndDate <= endDate));

    public IQueryable<User> GetIQueryableByDate(int poolId, DateOnly date)
            => _db.User
                    .Where(u => u.Tickets.Any(t => t.PoolId == poolId && t.StartDate == date));
}
