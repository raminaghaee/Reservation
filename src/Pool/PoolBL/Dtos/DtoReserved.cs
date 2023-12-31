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
    /// yyyy-mm-dd
    /// </summary>
    [Column(TypeName = "NCHAR(10)")]
    public string ConfirmDate { get; set; }
    /// <summary>
    /// 00:00
    /// </summary>
    [Column(TypeName = "NCHAR(5)")]
    public string ConfirmTime { get; set; }

    /// <summary>
    /// yyyy-mm-dd
    /// </summary>

    [Column(TypeName = "NCHAR(10)")]
    public string CreateDate { get; set; }

    /// <summary>
    /// 00:00
    /// </summary>
    [Column(TypeName = "NCHAR(5)")]
    public string CreateTime { get; set; }


    /// <summary>
    /// Internet , Operator , Stand
    /// </summary>
    public int CreateTypeId { get; set; }
}
