namespace PoolBL;
public interface ITicketBL : IBaseBL<ITicketDA,Ticket,DtoTicket>
{
    int GetCountCostumerByDate(int poolId, DateOnly startDate, DateOnly endDate);
    int GetCountCostumerByDate(int poolId, DateOnly date);
    ICollection<Ticket> GetCountCostumerByPoolName(string Name);

}
