using Microsoft.EntityFrameworkCore;
using PoolBL;
using PoolDA.Contexts;


namespace PoolDA;
public class ConstantDA : BaseDA<Constant>, IConstantDA
{
    public ConstantDA(PoolDbContext Db) : base(Db)
    {
    }
}
