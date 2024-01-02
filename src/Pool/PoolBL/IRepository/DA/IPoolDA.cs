namespace PoolBL;
public interface IPoolDA : IBaseDA<Pool>
{
    Pool GetMaxNotConfirm(DateTime startDateTime, DateTime endDateTime);
    Pool GetMaxTickets(DateOnly startDateTime, DateOnly endDateTime);
    List<DtoPoolGetCount> GetNotConfirm(DateTime startDateTime, DateTime endDateTime);


}
