

namespace PoolBL;
public class PoolBL_ : BaseBL<IPoolDA, Pool, DtoPool>, IPoolBL
{
    private readonly IPoolDA _baseDA;

    public PoolBL_(IPoolDA baseDA) : base(baseDA)
    {
        _baseDA = baseDA;
    }

    public List<DtoPoolGetCount> GetNotConfirm(DateTime startDateTime, DateTime endDateTime) 
                =>  _baseDA.GetNotConfirm(startDateTime, endDateTime).ToList();
    public Pool GetPoolMaxNotConfirm(DateTime startDateTime, DateTime endDateTime) 
                => _baseDA.GetMaxNotConfirm(startDateTime, endDateTime);
    public Pool GetPoolMaxTicket(DateOnly startDateTime, DateOnly endDateTime) 
                => _baseDA.GetMaxTickets(startDateTime, endDateTime);


}
