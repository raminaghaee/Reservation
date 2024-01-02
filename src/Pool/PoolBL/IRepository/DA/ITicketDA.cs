namespace PoolBL;
public interface ITicketDA : IBaseDA<Ticket> 
{

    int GetCountCostumerByDate(int poolId, DateOnly startDate, DateOnly endDate);
    int GetCountCostumerByDate(int poolId, DateOnly date); 

    int GetCountCostumerByPoolName(string Name);
}
