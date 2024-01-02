namespace PoolBL;
public interface IPoolBL : IBaseBL<IPoolDA,Pool,DtoPool>
{
    List<DtoPoolGetCount> GetNotConfirm(DateTime startDateTime, DateTime endDateTime);
    Pool GetPoolMaxTicket(DateOnly startDateTime, DateOnly endDateTime);
    Pool GetPoolMaxNotConfirm(DateTime startDateTime, DateTime endDateTime);

}


