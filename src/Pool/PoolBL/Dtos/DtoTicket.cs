using CMN;

namespace PoolBL;
public class DtoTicket : IBaseDto
{
    /// <summary>
    /// New, Regolar, VIP
    /// </summary>
    public int TicketTypeId { get; set; }
    /// <summary>
    /// Internet , Operator , Stand
    /// </summary>
    public int CreateTypeId { get; set; }

    public decimal Price { get; set; }
    /// <summary>
    /// Active = 102 , Not Active = 103
    /// In Constant Table
    /// </summary>
    public int ActivedId { get; set; }
}
