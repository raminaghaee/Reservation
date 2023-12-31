namespace PoolBL;
public class ReservedBL : BaseBL<IReservedDA, Reserved, DtoReserved>, IReservedBL
{
    public ReservedBL(IReservedDA baseDA) : base(baseDA)
    {
    }
}
