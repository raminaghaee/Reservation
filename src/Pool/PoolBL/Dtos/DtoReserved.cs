using CMN;
using System.ComponentModel.DataAnnotations.Schema;

namespace PoolBL;
public class DtoReserved : IBaseDto
{
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

    public DateOnly ConfirmDate { get; set; }

    public TimeOnly ConfirmTime { get; set; }

    public DateOnly CreateDate { get; set; }

    public TimeOnly CreateTime { get; set; }
}
