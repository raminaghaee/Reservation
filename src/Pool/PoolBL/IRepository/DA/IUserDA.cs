using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolBL;
public interface IUserDA : IBaseDA<User>
{
    ICollection<User> GetByDate(int poolId, DateOnly startDate, DateOnly endDate);
    ICollection<User> GetByDate(int poolId, DateOnly date);

    IQueryable<User> GetIQueryableByDate(int poolId, DateOnly startDate, DateOnly endDate);
    IQueryable<User> GetIQueryableByDate(int poolId, DateOnly date);

    int GetCountCostumerByDate(int poolId, DateOnly startDate, DateOnly endDate);
    int GetCountCostumerByDate(int poolId, DateOnly date);
}
