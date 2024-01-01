namespace PoolBL;
public class ConstantBL : BaseBL<IConstantDA, Constant, DtoConstant>, IConstantBL
{
    public ConstantBL(IConstantDA baseDA) : base(baseDA)
    {
    }
}
