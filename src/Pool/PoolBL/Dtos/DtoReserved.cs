using CMN;
using System.ComponentModel.DataAnnotations.Schema;

namespace PoolBL;
public class DtoReserved : IBaseDto
{
    public int PoolId { get; set; }
    public int SansId { get; set; }
    public int? UserId { get; set; }
    public int? EmployeeId { get; set; }
    public int TicketId { get; set; }
    /// <summary>
    /// Active = 102 , Not Active = 103
    /// In Constant Table
    /// </summary>
    public int ActivedId { get; set; }
    /// <summary>
    /// Confirm or Not Confirm
    /// in Constant table
    /// </summary>
    public int IsConfirm { get; set; }

    /// <summary>
    /// Internet , Operator , Stand
    /// </summary>
    public int CreateTypeId { get; set; }
}
