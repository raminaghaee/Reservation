using CMN;
using System.ComponentModel.DataAnnotations.Schema;

namespace PoolBL;
public class DtoPay : IBaseDto
{
    /// <summary>
    /// Active = 102 , Not Active = 103
    /// In Constant Table
    /// </summary>
    public int ActivedId { get; set; }
    #region Properties
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
    /// VIP , Regolar
    /// in Const Table
    /// </summary>
    public int TicketTypeId { get; set; }
    /// <summary>
    ///Paid, used , Ebtal , faskh
    ///In Const Table
    /// </summary>
    public int PayTypeId { get; set; }
    /// <summary>
    /// Internet , Operator , Stand
    /// </summary>
    public int CreateTypeId { get; set; }
}
