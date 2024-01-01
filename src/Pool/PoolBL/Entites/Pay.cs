using System.ComponentModel.DataAnnotations.Schema;

namespace PoolBL;

[Table("Pay", Schema = "Pool")]
public class Pay : BaseEntity 
{
    #region Realation
    public int TicketId { get; set; }
    public Ticket Ticket { get; set; }
    #endregion

    #region Properties
   
    public DateTime CreateDateTime { get; set; }

    /// <summary>
    /// VIP , Regolar , New
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
    public decimal Price { get; set; }

    #endregion
}

