using CMN;

namespace PoolBL;
public interface ITicket : IEntity
{
    int TicketTypeId { get; set; }
    int CreateTypeId { get; set; }
    decimal Price { get; set; }
}
