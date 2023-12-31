using System.ComponentModel.DataAnnotations.Schema;

namespace PoolBL;

[Table("Reserved", Schema = "Pool")]
public class Reserved : BaseEntity
{
    #region Realation
    public int PoolId { get; set; }
    //public Pool Pool { get; set; }


    public int SansId { get; set; }
    // public Sans Sans { get; set; }

    public int UserId { get; set; }
    //public User User { get; set; }

    public int TicketId { get; set; }
    public Ticket Ticket { get; set; }

    public int? EmployeeId { get; set; }
    public Employee? Employee { get; set; }
    #endregion

    #region Properties
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
    #endregion

}

