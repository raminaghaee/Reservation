using PoolBL;
using PoolDA.Contexts;

namespace PoolDA;
public class UserDA : BaseDA<User>, IUserDA
{
    public UserDA(PoolDbContext Db) : base(Db)
    {

    }


}
