using Microsoft.EntityFrameworkCore;
using PoolBL;
using PoolDA.Contexts;
using static CMN.Enums;

namespace PoolDA;
public class PoolDA_ : BaseDA<Pool>, IPoolDA
{

    public PoolDA_(PoolDbContext Db) : base(Db)
    {

    }

    public Pool GetMaxNotConfirm(DateTime startDateTime, DateTime endDateTime)
    {
        var result = GetAllAsQueryable()
                    .Select(p => new
                    {
                        Pool = p,
                        count = p.Reserveds.Count(r => r.IsConfirm == IsConfirm.NotConfirm && (r.DateTime >= startDateTime || r.DateTime <= endDateTime))
                    })
                    .OrderByDescending(n => n.count)
                    .FirstOrDefault();
        return result?.Pool;
    }

    public Pool GetMaxTickets(DateOnly startDateTime, DateOnly endDateTime)
    {
        var result = GetAllAsQueryable()
            .Select(p => new
            {
                Pool = p,
                count = p.Tickets.Count(r => r.StartDate >= startDateTime || r.StartDate <= endDateTime)
            })
            .OrderByDescending(p => p.count)
            .FirstOrDefault();

        return result?.Pool;
    }

    public List<DtoPoolGetCount> GetNotConfirm(DateTime startDateTime, DateTime endDateTime)
    {
        return GetAllAsQueryable()
                 .Select(p => new DtoPoolGetCount
                 {
                     Pool = p,
                     Count = p.Reserveds.Count(r => r.IsConfirm == IsConfirm.NotConfirm && (r.DateTime >= startDateTime || r.DateTime <= endDateTime))
                 })
                 .OrderByDescending(p => p.Count)
                 .ToList();
    }
}


