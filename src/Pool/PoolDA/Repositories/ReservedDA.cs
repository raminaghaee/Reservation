using PoolBL;
using PoolDA.Contexts;

namespace PoolDA;
public class ReservedDA : BaseDA<Reserved>, IReservedDA
{
    public ReservedDA(PoolDbContext Db) : base(Db)
    {
        
    }
                    
}
