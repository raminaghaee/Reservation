namespace PoolBL;
public class TicketBL : BaseBL<ITicketDA, Ticket, DtoTicket>, ITicketBL
{
    private readonly ITicketDA _baseDA;

    public TicketBL(ITicketDA baseDA) : base(baseDA)
    {
        _baseDA = baseDA;
    }
    public int GetCountCoustomerByDateBL(int poolId, DateOnly startDate, DateOnly endDate)
           => _baseDA.GetByDate(poolId, startDate, endDate).Count();

    public int GetCountCoustomerByDateDA(int poolId, DateOnly startDate, DateOnly endDate)
            => _baseDA.GetCountCostumerByDate(poolId, startDate, endDate);

    public int GetCountCoustomerByDateQuery(int poolId, DateOnly startDate, DateOnly endDate)
            => _baseDA.GetIQueryableByDate(poolId, startDate, endDate).Count();



    public int GetCountCostumerByPoolName(string Name)
            => _baseDA.GetCountCostumerByPoolName(Name).Count();
}
