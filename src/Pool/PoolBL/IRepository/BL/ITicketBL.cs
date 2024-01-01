namespace PoolBL;
public interface ITicketBL : IBaseBL<ITicketDA,Ticket,DtoTicket>
{
    int GetCountCoustomerByDateBL(int poolId, DateOnly startDate, DateOnly endDate);
    int GetCountCoustomerByDateDA(int poolId, DateOnly startDate, DateOnly endDate);
    int GetCountCoustomerByDateQuery(int poolId, DateOnly startDate, DateOnly endDate);

    int GetCountCostumerByPoolName(string Name);

}
