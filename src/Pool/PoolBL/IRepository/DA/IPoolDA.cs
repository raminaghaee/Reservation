namespace PoolBL;
public interface IPoolDA : IBaseDA<Pool>
{
    List<DtoPoolGetCount> GetNotConfirm();
    Pool GetMaxTickets();
    Pool GetMaxNotConfirm();


}
