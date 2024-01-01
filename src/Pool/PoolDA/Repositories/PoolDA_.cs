﻿using Microsoft.EntityFrameworkCore;
using PoolBL;
using PoolDA.Contexts;

namespace PoolDA;
public class PoolDA_ : BaseDA<Pool>, IPoolDA
{
    private readonly PoolDbContext _db;

    public PoolDA_(PoolDbContext Db) : base(Db)
    {
        _db = Db;
    }

    public Pool GetMaxNotConfirm()
    {
        var result = _db.Pool
                    .Select(p=> new
                    {
                        Pool = p,
                        count = p.Reserveds.Count(r=>r.IsConfirm == 21)
                    })
                    .OrderByDescending(n=>n.count)
                    .FirstOrDefault();
        return result?.Pool;
    }

    public Pool GetMaxTickets()
    {
        var result = _db.Pool
            .Select(p => new
            {
                Pool = p,
                count = p.Tickets.Count()
            })
            .OrderByDescending(p=>p.count)
            .FirstOrDefault();

        return result?.Pool;
    }

    public List<DtoPoolGetCount> GetNotConfirm()
    {
        //اگر هر جایی مثل اینجا از دی تی او استفاده کنم هتوی خرواری از دی تی او ها گم میشم
        //return _db.Pool
        //         .Select(p => new
        //         {
        //             pool = p,
        //             CountNotCounfirm = p.Reserveds.Count(r => r.IsConfirm == 21)
        //         })
        //         .OrderByDescending(p=>p.CountNotCounfirm)
        //         .Cast<object>().ToList();

        return _db.Pool
                 .Select(p => new DtoPoolGetCount
                 {
                     Pool = p,
                     Count = p.Reserveds.Count(r => r.IsConfirm == 21)
                 })
                 .OrderByDescending(p => p.Count)
                 .ToList();
    }
}


