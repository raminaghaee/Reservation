namespace PoolBL;
public class TicketBL : BaseBL<ITicketDA, Ticket, DtoTicket>, ITicketBL
{
    public TicketBL(ITicketDA baseDA) : base(baseDA)
    {
    }
}
