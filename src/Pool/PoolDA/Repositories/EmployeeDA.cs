using Microsoft.EntityFrameworkCore;
using PoolBL;
using PoolDA.Contexts;


namespace PoolDA;
public class EmployeeDA : BaseDA<Employee>, IEmployeeDA
{
    public EmployeeDA(PoolDbContext Db) : base(Db)
    {
    }
}
