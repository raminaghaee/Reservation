namespace PoolBL;
public interface IPoolBL : IBaseBL<IPoolDA,Pool,DtoPool>
{
    List<DtoPoolGetCount> GetNotConfirm();
    Pool GetPoolMaxTicket();
    Pool GetPoolMaxNotConfirm();
}


