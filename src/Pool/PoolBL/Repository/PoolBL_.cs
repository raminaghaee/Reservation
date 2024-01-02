

namespace PoolBL;
public class PoolBL_ : BaseBL<IPoolDA, Pool, DtoPool>, IPoolBL
{
    public PoolBL_(IPoolDA baseDA) : base(baseDA)
    {
    }

    public Pool GetMaxNotConfirm(DateTime startDateTime, DateTime endDateTime)
            => GetMaxNotConfirm(startDateTime, endDateTime);

    public Pool GetMaxTickets(DateOnly startDateTime, DateOnly endDateTime)
            => GetMaxTickets(startDateTime, endDateTime);

    public List<DtoPoolGetCount> GetNotConfirm(DateTime startDateTime, DateTime endDateTime) 
                =>  GetNotConfirm(startDateTime, endDateTime).ToList();
}
