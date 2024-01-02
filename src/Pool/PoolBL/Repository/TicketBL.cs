namespace PoolBL;
public class TicketBL : BaseBL<ITicketDA, Ticket, DtoTicket>, ITicketBL
{


    public TicketBL(ITicketDA baseDA) : base(baseDA)
    {
    }
    public int GetCountCostumerByDate(int poolId, DateOnly startDate, DateOnly endDate)
           => GetCountCostumerByDate(poolId, startDate, endDate);

    public int GetCountCostumerByPoolName(string Name)
            => GetCountCostumerByPoolName(Name);

    public int GetCountCostumerByDate(int poolId, DateOnly date)
    {
        throw new NotImplementedException();
    }
}
