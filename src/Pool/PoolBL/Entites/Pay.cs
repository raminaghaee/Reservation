using System.ComponentModel.DataAnnotations.Schema;
using static CMN.Enums;

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


    public TicketType TicketTypeId { get; set; }
    /// <summary>
    ///Paid, used , Ebtal , faskh
    ///In Const Table
    /// </summary>
    public PayType PayTypeId { get; set; }
    /// <summary>
    /// Internet , Operator , Stand
    /// </summary>
    public CreateType CreateTypeId { get; set; }
    public decimal Price { get; set; }

    #endregion
}

