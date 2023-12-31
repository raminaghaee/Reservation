namespace PoolBL;
public class EmployeeBL : BaseBL<IEmployeeDA, Employee, DtoEmployee>, IEmployeeBL
{
    public EmployeeBL(IEmployeeDA baseDA) : base(baseDA)
    {
    }
}
