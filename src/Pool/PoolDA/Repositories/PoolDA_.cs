using PoolBL;
using PoolDA.Contexts;

namespace PoolDA;
public class PoolDA_ : BaseDA<Pool>, IPoolDA
{
    public PoolDA_(PoolDbContext Db) : base(Db)
    {
    }
}
