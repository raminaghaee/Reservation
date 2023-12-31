using Microsoft.EntityFrameworkCore;
using PoolBL;
using PoolDA.Contexts;

namespace PoolDA;
public class SansDA : BaseDA<Sans>, ISansDA
{
    public SansDA(PoolDbContext Db) : base(Db)
    {
    }
}
