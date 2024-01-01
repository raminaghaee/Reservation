
namespace PoolBL;
public class PoolBL_ : BaseBL<IPoolDA, Pool, DtoPool>, IPoolBL
{
    private readonly IPoolDA _baseDA;

    public PoolBL_(IPoolDA baseDA) : base(baseDA)
    {
        _baseDA = baseDA;
    }

    public List<DtoPoolGetCount> GetNotConfirm() =>  _baseDA.GetNotConfirm().ToList();

    public Pool GetPoolMaxNotConfirm() => _baseDA.GetMaxNotConfirm();

    public Pool GetPoolMaxTicket() => _baseDA.GetMaxTickets();
}
