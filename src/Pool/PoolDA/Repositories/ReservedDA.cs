using Microsoft.EntityFrameworkCore;
using PoolBL;
using PoolDA.Contexts;

namespace PoolDA;
public class ReservedDA : BaseDA<Reserved>, IReservedDA
{
    private readonly PoolDbContext _db;

    public ReservedDA(PoolDbContext Db) : base(Db)
    {
        _db = Db;
    }
                    
}
