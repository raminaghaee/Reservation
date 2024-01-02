using PoolBL;
using PoolDA;
using PoolDA.Repositories;

namespace PoolUI.IOC;

public static class UnityConfig
{
    public static void IsRegister(this IServiceCollection services)
    {
        

        #region Constant
        services.AddTransient<IConstantDA, ConstantDA>();
        services.AddTransient<IConstantBL, ConstantBL>();
        #endregion
        #region Employee
        services.AddTransient<IEmployeeDA, EmployeeDA>();
        services.AddTransient<IEmployeeBL, EmployeeBL>();
        #endregion
        #region Pay
        services.AddTransient<IPayDA, PayDA>();
        services.AddTransient<IPayBL, PayBL>();
        #endregion
        #region Pool
        services.AddTransient<IPoolDA, PoolDA_>();
        services.AddTransient<IPoolBL, PoolBL_>();
        #endregion
        #region Reserved
        services.AddTransient<IReservedDA, ReservedDA>();
        services.AddTransient<IReservedBL, ReservedBL>();
        #endregion
        #region Sans
        services.AddTransient<ISansDA, SansDA>();
        services.AddTransient<ISansBL, SansBL>();
        #endregion
        #region Ticket
        services.AddTransient<ITicketDA, TicketDA>();
        services.AddTransient<ITicketBL, TicketBL>();
        #endregion
        #region User
        services.AddTransient<IUserDA, UserDA>();
        services.AddTransient<IUserBL, UserBl>();
        #endregion

        services.AddTransient<ISampleAdoDA,SampleAdoDA>();


    }
}
