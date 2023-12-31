namespace PoolBL;
public class ConstantBL : BaseBL<IConstantDA, Constant, dtoConstant>, IConstantBL
{
    public ConstantBL(IConstantDA baseDA) : base(baseDA)
    {
    }
}
