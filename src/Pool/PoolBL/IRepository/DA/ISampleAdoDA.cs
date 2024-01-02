using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolBL;
public interface ISampleAdoDA 
{
    public int GetCountCostumerByDateADO(int poolId, DateTime startDate, DateTime endDate);
    public ICollection<Ticket> GetCostumerByDateADO(int poolId, DateOnly startDate, DateOnly endDate);
}
