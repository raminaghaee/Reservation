namespace PoolBL;
public interface IPoolBL : IBaseBL<IPoolDA,Pool,DtoPool>
{
    List<DtoPoolGetCount> GetNotConfirm(DateTime startDateTime, DateTime endDateTime);
    Pool GetMaxNotConfirm(DateTime startDateTime, DateTime endDateTime);
    Pool GetMaxTickets(DateOnly startDateTime, DateOnly endDateTime);
}


