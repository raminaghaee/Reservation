namespace PoolBL;
public class PoolBL_ : BaseBL<IPoolDA, Pool, DtoPool>, IPoolBL
{
    public PoolBL_(IPoolDA baseDA) : base(baseDA)
    {
    }
}
