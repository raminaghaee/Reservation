using Microsoft.EntityFrameworkCore;
using PoolBL;
using PoolDA.Contexts;


namespace PoolDA;
public class TicketDA : BaseDA<Ticket>, ITicketDA
{
    public TicketDA(PoolDbContext Db) : base(Db)
    {

    }

    /// <summary>
    /// روش صحیح که به ازای هر سوال یک متد ایجاد شود
    /// </summary>
    /// <param name="poolId"></param>
    /// <param name="startDate"></param>
    /// <param name="endDate"></param>
    /// <returns></returns>
    public int GetCountCostumerByDate(int poolId, DateOnly startDate, DateOnly endDate)
            => GetAllAsQueryable().AsNoTracking()
                    .Where(t => t.PoolId == poolId && t.StartDate >= startDate && t.EndDate <= endDate)
                    .Count();

    /// <summary>
    /// روش نسبتا اشتباه چون باید به ازای هر سوال یک متد تعریف شود
    /// </summary>
    /// <param name="poolId"></param>
    /// <param name="startDate"></param>
    /// <param name="endDate"></param>
    /// <returns></returns>
    public ICollection<Ticket> GetByDate(int poolId, DateOnly startDate, DateOnly endDate)
             => GetAllAsQueryable().AsNoTracking()
                    .Where(t => t.PoolId == poolId && t.StartDate >= startDate && t.EndDate <= endDate)
                    .ToList();

    
    /// <summary>
    /// این روش درستی نیست و باید اناموریبل برگردانیم
    /// </summary>
    /// <param name="poolId"></param>
    /// <param name="date"></param>
    /// <returns></returns>
    public IQueryable<Ticket> GetIQueryableByDate(int poolId, DateOnly startDate, DateOnly endDate)
             => GetAllAsQueryable()
                    .Where(t => t.PoolId == poolId && t.StartDate >= startDate && t.EndDate <= endDate);

    




    public ICollection<Ticket> GetCountCostumerByPoolName(string Name)
    {
        return GetAllAsQueryable().AsNoTracking()
                        .Where(t=>t.Pool.Name.Contains(Name)).ToList();
    }

    public int GetCountCostumerByDate(int poolId, DateOnly date)
            => GetAllAsQueryable().AsNoTracking()
                    .Where(t => t.PoolId == poolId && t.StartDate == date)
                    .Count();


}
