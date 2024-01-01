namespace PoolBL;
public interface ITicketDA : IBaseDA<Ticket>
{
    ICollection<Ticket> GetByDate(int poolId, DateOnly startDate, DateOnly endDate);
    ICollection<Ticket> GetByDate(int poolId, DateOnly date);

    IQueryable<Ticket> GetIQueryableByDate(int poolId, DateOnly startDate, DateOnly endDate);
    IQueryable<Ticket> GetIQueryableByDate(int poolId, DateOnly date);

    int GetCountCostumerByDate(int poolId, DateOnly startDate, DateOnly endDate);
    int GetCountCostumerByDate(int poolId, DateOnly date);


    ICollection<Ticket> GetCountCostumerByPoolName(string Name);
}
