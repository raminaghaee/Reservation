namespace PoolBL;
public class PayBL : BaseBL<IPayDA, Pay, DtoPay>, IPayBL
{
    public PayBL(IPayDA baseDA) : base(baseDA)
    {
    }
}
