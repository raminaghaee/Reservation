using PoolBL;
using PoolDA.Contexts;

namespace PoolDA;
public class PayDA : BaseDA<Pay>, IPayDA
{
    public PayDA(PoolDbContext Db) : base(Db)
    {
    }
}
