using CMN;

namespace PoolBL;
public class DtoTicket : IBaseDto
{
    public int PoolId { get; set; }
    public int? UserId { get; set; }
    public int? EmployeeId { get; set; }

    /// <summary>
    /// New, Regolar, VIP
    /// </summary>
    public int TicketTypeId { get; set; }
    /// <summary>
    /// Internet , Operator , Stand
    /// </summary>
    public int CreateTypeId { get; set; }

    /// <summary>
    /// Active = 102 , Not Active = 103
    /// In Constant Table
    /// </summary>
    public int ActivedId { get; set; }

    public DateOnly CreatDate { get; set; }
    /// <summary>
    /// if Regolar or New  => CreateDate == EndDate
    /// else EndDate = Any
    /// </summary>
    public DateOnly EndDate { get; set; }
}
