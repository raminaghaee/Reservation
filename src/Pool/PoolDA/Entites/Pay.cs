using PoolBL;
using PoolDA.Entites;
using System.ComponentModel.DataAnnotations.Schema;

namespace PoolDA;

[Table("Pay", Schema = "Pool")]
public class Pay : BaseEntity , IPay
{
    #region Realation
    public int TicketId { get; set; }
    public Ticket Ticket { get; set; }
    #endregion

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
    #endregion
}

